using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;
using Interface_UI.Reports;

namespace Interface_UI.BUS.Controllers
{
    public class BaoCaoCongNoController
    {
        #region fields
        public string MessageFailure { get; set; }
        QuanLyDaiLyEntities db;
        #endregion

        #region controls
        public ComboBox ThangComboBox { get; set; }
        public ComboBox NamConboBox { get; set; }
        public Button InButton { get; set; }
        public Button TimButton { get; set; }
        public DataGridView BaoCaoDoanhSoData
        {
            get; set;
        }
        #endregion
        #region Current Data
        List<BaoCaoCongNoOj> BaoCaoCongNoOjs { get; set; }
        #endregion

        #region constructor
        public BaoCaoCongNoController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();
            this.BaoCaoCongNoOjs = new List<BaoCaoCongNoOj>();
           
        }


        #endregion

        #region methods
        public void LoadLanDau()
        {
            this.MessageFailure = "";
            //
            //load thang combobox
            //
            var thangs = (from pxh in this.db.tb_PhieuXuatHang
                          select new { Thang = pxh.Ngay_Lap.Month }).Distinct();
            this.ThangComboBox.DataSource = thangs.ToList();
            this.ThangComboBox.ValueMember = "Thang";
            this.ThangComboBox.DisplayMember = "Thang";
            //
            //load nam combobox
            //
            var nams = (from pxh in this.db.tb_PhieuXuatHang
                        select new { Nam = pxh.Ngay_Lap.Year }).Distinct();
            this.NamConboBox.DataSource = nams.ToList();
            this.NamConboBox.ValueMember = "Nam";
            this.NamConboBox.DisplayMember = "Nam";
            //
            //subcribe events
            //
            this.InButton.Click += InButton_Click;
            this.TimButton.Click += TimButton_Click;
            //
            //set state of controls
            //
            this.InButton.Enabled = false;


        }

        private void TimKiem()
        {
            //
            //reset messfailure
            //
            this.MessageFailure = "";
            //
            //lay thong tin thang, nam
            //
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamConboBox.SelectedValue.ToString());
            //
            //Load no dau
            //
            var dsnodau_select = from pxh in db.tb_PhieuXuatHang
                                 where pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam
                                 select new { MaDaiLy = pxh.Ma_DaiLy, TenDaiLy = pxh.tb_DaiLy.Ten_DaiLy, TongTien = pxh.TongTien };
            
            var dsnodau_group = from dsnd in dsnodau_select
                                group dsnd by dsnd.MaDaiLy;

            var dsnodau = from dsnd in dsnodau_group
                          select new { MaDaiLy = dsnd.Key, TenDaiLy = dsnd.Select(p => p.TenDaiLy).FirstOrDefault(), NoBanDau = dsnd.Sum(p => p.TongTien) };
            //
            //Load no phat sinh
            //
            var dsnophatsinh_select = from nps in db.tb_TienNoPhatSinh
                                      where nps.NgayLap.Month == thang && nps.NgayLap.Year == nam
                                      select new { MaDaiLy = nps.Ma_DaiLy, NoPhatSinh = nps.SoTienPhatSinh };
            var dsnophatsinh_group = from nps in dsnophatsinh_select
                                     group nps by nps.MaDaiLy;
            var dsnophatsinh = from nps in dsnophatsinh_group
                               select new { MaDaiLy = nps.Key, NoPhatSinh = nps.Sum(p => p.NoPhatSinh) };
            //
            //load tien da thu 
            //
            var dsphieuthutien_select = from ptt in db.tb_PhieuThuTien
                                        where ptt.Ngay_Lap.Month == thang && ptt.Ngay_Lap.Year == nam
                                        select new { MaDaiLy = ptt.Ma_DaiLy, TienDaThu = ptt.So_Tien_Thu };
            var dsphieuthutien_group = from ptt in dsphieuthutien_select
                                       group ptt by ptt.MaDaiLy;
            var dsphieuthutien = from ptt in dsphieuthutien_group
                                 select new { MaDaiLy = ptt.Key, TienDaThu = ptt.Sum(p => p.TienDaThu) };
            //
            // join tien no, tien phat sinh, tien da thu
            //
            var nobandau_nophatsinh_groupjoin = dsnodau.GroupJoin(dsnophatsinh, nd => nd.MaDaiLy, nps => nps.MaDaiLy, (nd, nps) => new { MaDaiLy = nd.MaDaiLy, TenDaiLy = nd.TenDaiLy, TienNoBanDau = nd.NoBanDau, NoPhatsinh = nps.Count()!= 0 ? nps.Select(p=>p.NoPhatSinh).FirstOrDefault() : 0 });
            var nobandau_nophatsinh_tiendathu_groupjoin = nobandau_nophatsinh_groupjoin.GroupJoin(dsphieuthutien, a => a.MaDaiLy, b => b.MaDaiLy, (a, b) => new { MaDaiLy = a.MaDaiLy, TenDaiLy = a.TenDaiLy, TienNoBanDau = a.TienNoBanDau, NoPhatSinh = a.NoPhatsinh, NoCuoi = (a.TienNoBanDau + a.NoPhatsinh) - (b.Count() != 0 ? b.Select(p => p.TienDaThu).FirstOrDefault() : 0) });

            if (nobandau_nophatsinh_tiendathu_groupjoin.Any())
            {
                this.BaoCaoDoanhSoData.DataSource = null;
                this.BaoCaoDoanhSoData.DataSource = nobandau_nophatsinh_tiendathu_groupjoin.ToList();
                this.InButton.Enabled = true;
                this.BaoCaoCongNoOjs.Clear();
                foreach (var item in nobandau_nophatsinh_tiendathu_groupjoin)
                {
                    this.BaoCaoCongNoOjs.Add(
                        new BaoCaoCongNoOj
                        {
                            DaiLy = item.TenDaiLy,
                            NoDau = item.TienNoBanDau,
                            PhatSinh = item.NoPhatSinh,
                            NoCuoi = item.NoCuoi
                        });
                }
                


            }
            else
            {
                this.BaoCaoDoanhSoData.DataSource = null;
                this.InButton.Enabled = false;

            }

            
            

        }
        #endregion

        #region events
        private void TimButton_Click(object sender, EventArgs e)
        {
            this.TimKiem();
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            BaoCaoCongNoReportViewerForm baoCaoCongNoReportViewerForm = new BaoCaoCongNoReportViewerForm { BaoCaoCongNoList = this.BaoCaoCongNoOjs };
            baoCaoCongNoReportViewerForm.ShowDialog();
        }
        #endregion
    }
}
