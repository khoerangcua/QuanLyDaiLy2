using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;

namespace Interface_UI.BUS.Controllers
{
    public class TraCuuDaiLyController
    {
        #region fields
        public string MessageFailure { get; set; }
        QuanLyDaiLyEntities db;
        #endregion

        #region controls
        public TextBox DaiLyTextBox { get; set; }
        public ComboBox LoaiDaiLyComboBox { get; set; }
        public ComboBox QuanComboBox { get; set; }
        public DataGridView DaiLyData { get; set; }
        public Button TimButton { get; set; }
        #endregion

        #region constructor
        public TraCuuDaiLyController()
        {
            this.MessageFailure = "";
            db = new QuanLyDaiLyEntities();
                       

        }
        #endregion

        #region methods
        public void LoadLanDau()
        {
            //
            // load quan combobox
            //
            var quans = from q in db.tb_Quan
                        select new { Id = q.Ma_Quan, Name = q.Ten_Quan };
            this.QuanComboBox.DataSource = quans.ToList();
            this.QuanComboBox.ValueMember = "Id";
            this.QuanComboBox.DisplayMember = "Name";
            //
            // load loai dai ly combobox
            //
            var loaidailys = from ldl in db.tb_LoaiDaiLy
                             select new { Id = ldl.Ma_Loai_DaiLy, Name = ldl.Ten_Loai };
            this.LoaiDaiLyComboBox.DataSource = loaidailys.ToList();
            this.LoaiDaiLyComboBox.ValueMember = "Id";
            this.LoaiDaiLyComboBox.DisplayMember = "Name";
            //
            //subcribe events
            //
            this.TimButton.Click += TimButton_Click;

        }

        private void TimKiem()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            //lay thong tin ten, maloai, maquan
            //
            string tendaily = this.DaiLyTextBox.Text;
            int maloaidaily = int.Parse(this.LoaiDaiLyComboBox.SelectedValue.ToString());
            int maquan = int.Parse(this.QuanComboBox.SelectedValue.ToString());
            //
            // load tien no
            //
            var tienno_select = from pxh in db.tb_PhieuXuatHang
                                where pxh.tb_DaiLy.Ten_DaiLy.Contains(tendaily) && pxh.tb_DaiLy.Ma_Quan == maquan && pxh.tb_DaiLy.Ma_Loai_DaiLy == maloaidaily
                                select new { MaDaiLy = pxh.Ma_DaiLy, TenDaiLy = pxh.tb_DaiLy.Ten_DaiLy, LoaiDaiLy = pxh.tb_DaiLy.tb_LoaiDaiLy.Ten_Loai, Quan = pxh.tb_DaiLy.tb_Quan.Ten_Quan, TienNo = pxh.TongTien };

            var tienno_group = from pxh in tienno_select
                               group pxh by pxh.MaDaiLy;

            var dstienno = from pxh in tienno_group
                           select new { MaDaiLy = pxh.Key, TenDaiLy = pxh.Select(p => p.TenDaiLy).FirstOrDefault(), LoaiDaiLy = pxh.Select(p => p.LoaiDaiLy).FirstOrDefault(), Quan = pxh.Select(p => p.Quan).FirstOrDefault(), TienNo = pxh.Sum(p => p.TienNo) };
            //
            //load no phat sinh
            //

            var nophatsinh_select = from nps in db.tb_TienNoPhatSinh
                                    where nps.tb_DaiLy.Ten_DaiLy.Contains(tendaily) && nps.tb_DaiLy.Ma_Quan == maquan && nps.tb_DaiLy.Ma_Loai_DaiLy == maloaidaily
                                    select new { MaDaiLy = nps.Ma_DaiLy, TienNoPhatSinh = nps.SoTienPhatSinh };
            var nophatsinh_group = from nps in nophatsinh_select
                                   group nps by nps.MaDaiLy;
            var dsnophatsinh = from nps in nophatsinh_group
                               select new { MaDaiLy = nps.Key, TienNoPhatSinh = nps.Sum(p => p.TienNoPhatSinh) };
            //
            //load tien da thu
            //
            var tiendathu_select = from ptt in db.tb_PhieuThuTien
                                   where ptt.tb_DaiLy.Ten_DaiLy.Contains(tendaily) && ptt.tb_DaiLy.Ma_Quan == maquan && ptt.tb_DaiLy.Ma_Loai_DaiLy == maloaidaily
                                   select new { MaDaiLy = ptt.Ma_DaiLy, TienDaThu = ptt.So_Tien_Thu };
            var tiendathu_group = from ptt in tiendathu_select
                                  group ptt by ptt.MaDaiLy;
            var dstiendathu = from ptt in tiendathu_group
                              select new { MaDaiLy = ptt.Key, TienDaThu = ptt.Sum(p => p.TienDaThu) };
            //
            //join tien no, tien no phat sinh va tien da thu
            //

            // tien no va nophatsinh
            var nobandau_nophatsinh_groupjoin = dstienno.GroupJoin(dsnophatsinh, nd => nd.MaDaiLy, nps => nps.MaDaiLy, (nd, nps) => new { MaDaiLy = nd.MaDaiLy, TenDaiLy = nd.TenDaiLy, TienNoBanDau = nd.TienNo, NoPhatsinh = nps.Count() != 0 ? nps.Select(p => p.TienNoPhatSinh).FirstOrDefault() : 0 });
            var nobandau_nophatsinh_tiendathu_groupjoin = nobandau_nophatsinh_groupjoin.GroupJoin(dstiendathu, a => a.MaDaiLy, b => b.MaDaiLy, (a, b) => new { MaDaiLy = a.MaDaiLy, TenDaiLy = a.TenDaiLy, TienNoBanDau = a.TienNoBanDau, NoPhatSinh = a.NoPhatsinh, NoCuoi = (a.TienNoBanDau + a.NoPhatsinh) - (b.Count() != 0 ? b.Select(p => p.TienDaThu).FirstOrDefault() : 0) });
            var dsdaily = nobandau_nophatsinh_tiendathu_groupjoin.Join(this.db.tb_DaiLy, a => a.MaDaiLy, b => b.Ma_DaiLy, (a, b) => new { MaDaiLy = a.MaDaiLy, TenDaiLy = a.TenDaiLy, Loai = b.tb_LoaiDaiLy.Ten_Loai, b.tb_Quan.Ten_Quan, DiaChi = b.Dia_Chi, SoDienThoai = b.Dien_Thoai, Email = b.Email, NgayTiepNhan = b.Ngay_Tiep_Nhan,TienNoToiDa = b.tb_LoaiDaiLy.TienNo_ToiDa, NoHienTai = a.NoCuoi });
            
            this.DaiLyData.DataSource = null;
            this.DaiLyData.DataSource = dsdaily.ToList();

            


        }
        #endregion

        #region events
        private void TimButton_Click(object sender, EventArgs e)
        {
            this.TimKiem();
        }
        #endregion
    }
}
