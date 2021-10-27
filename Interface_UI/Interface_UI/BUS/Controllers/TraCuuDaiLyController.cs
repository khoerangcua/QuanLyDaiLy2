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
            //
            //load all
            //
            LoadAll();
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
            //loc thong tin dai ly
            //
            var dailys = this.db.tb_DaiLy.Where(dl => dl.Ten_DaiLy.Contains(tendaily) && dl.Ma_Loai_DaiLy == maloaidaily && dl.Ma_Quan == maquan)
                                            .Select(dl =>
                                            new
                                            {
                                                DaiLy = dl,
                                                NoCung = dl.tb_PhieuXuatHang.Any() ? dl.tb_PhieuXuatHang.Sum(p => p.TongTien) : 0,
                                                NoPhatSinh = dl.tb_TienNoPhatSinh.Any() ? dl.tb_TienNoPhatSinh.Sum(p => p.SoTienPhatSinh) : 0,
                                                TienDaThu = dl.tb_PhieuThuTien.Any() ? dl.tb_PhieuThuTien.Sum(p => p.So_Tien_Thu) : 0
                                            }
                                            );
            //
            //dinh dang thong tin daily
            //
            var daily_infor = dailys.Select(dl => new
            {
                MaDaiLy = dl.DaiLy.Ma_DaiLy,
                TenDaiLy = dl.DaiLy.Ten_DaiLy,
                Quan = dl.DaiLy.tb_Quan.Ten_Quan,
                Loai = dl.DaiLy.tb_LoaiDaiLy.Ten_Loai,
                SoDienThoai = dl.DaiLy.Dien_Thoai,
                DiaChi = dl.DaiLy.Dia_Chi,
                Email = dl.DaiLy.Email,
                NgayTiepNhan = dl.DaiLy.Ngay_Tiep_Nhan,
                TienNo = dl.NoCung + dl.NoPhatSinh - dl.TienDaThu
            });

            this.DaiLyData.DataSource = null;
            this.DaiLyData.DataSource = daily_infor.ToList();
        }
        private void LoadAll()
        {
            var dailys = this.db.tb_DaiLy.Select(dl =>
                                            new
                                            {
                                                DaiLy = dl,
                                                NoCung = dl.tb_PhieuXuatHang.Any() ? dl.tb_PhieuXuatHang.Sum(p => p.TongTien) : 0,
                                                NoPhatSinh = dl.tb_TienNoPhatSinh.Any() ? dl.tb_TienNoPhatSinh.Sum(p => p.SoTienPhatSinh) : 0,
                                                TienDaThu = dl.tb_PhieuThuTien.Any() ? dl.tb_PhieuThuTien.Sum(p => p.So_Tien_Thu) : 0
                                            }
                                            );
            //
            //dinh dang thong tin daily
            //
            var daily_infor = dailys.Select(dl => new
            {
                MaDaiLy = dl.DaiLy.Ma_DaiLy,
                TenDaiLy = dl.DaiLy.Ten_DaiLy,
                Quan = dl.DaiLy.tb_Quan.Ten_Quan,
                Loai = dl.DaiLy.tb_LoaiDaiLy.Ten_Loai,
                SoDienThoai = dl.DaiLy.Dien_Thoai,
                DiaChi = dl.DaiLy.Dia_Chi,
                Email = dl.DaiLy.Email,
                NgayTiepNhan = dl.DaiLy.Ngay_Tiep_Nhan,
                TienNo = dl.NoCung + dl.NoPhatSinh - dl.TienDaThu
            });




            this.DaiLyData.DataSource = null;
            this.DaiLyData.DataSource = daily_infor.ToList();
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
