using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;

namespace Interface_UI.BUS.Controllers
{
    public class BaoCaoDoanhSoController
    {
        public string MessageFailure { get; set; }

        QuanLyDaiLyEntities db;

        public ComboBox ThangComboBox { get; set; }
        public ComboBox NamConboBox { get; set; }
        public TextBox ThangNamTextBox { get; set; }
        public Button InButton { get; set; }
        public Button TimButton { get; set; }
        public DataGridView BaoCaoDoanhSoData { get; set; }

        public BaoCaoDoanhSoController()
        {
            this.db = new QuanLyDaiLyEntities();
            this.MessageFailure = "";
           
            


        }

        public void LoadLanDau()
        {
            this.MessageFailure = "";
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            //
            //load thang combobox
            //
            var result1 = (from pxh in this.db.tb_PhieuXuatHang.ToList()
                          select new { Thang = pxh.Ngay_Lap.Month }).Distinct();
            this.ThangComboBox.DataSource = result1;
            this.ThangComboBox.ValueMember = "Thang";
            this.ThangComboBox.DisplayMember = "Thang";
            //
            //load nam combobox
            //
            var result2 = (from pxh in this.db.tb_PhieuXuatHang.ToList()
                           select new { Nam = pxh.Ngay_Lap.Year }).Distinct();
            this.ThangComboBox.DataSource = result2;
            this.ThangComboBox.ValueMember = "Nam";
            this.ThangComboBox.DisplayMember = "Nam";
            //
            //load baocaodoanhso datagridview cua thang, nam hien tai
            //
            var dsphieuxuathang = from pxh in this.db.tb_PhieuXuatHang.ToList()
                          where pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam
                          select new { MaDaiLy = pxh.Ma_DaiLy, TenDaiLy = pxh.tb_DaiLy.Ten_DaiLy, TongTien = pxh.TongTien };
            //
            //tin tong gia tri
            //
            double bcds_tong = db.tb_PhieuXuatHang.ToList().Where(pxh => pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam).Sum(p => p.TongTien);
            // group theo ma dai ly 
            if (dsphieuxuathang.Count()>0)
            {
                var dsphieuxuathang2 = from dspx in dsphieuxuathang
                                       group dspx by dspx.MaDaiLy;

                var baocaodoanhso = from pxh in dsphieuxuathang2
                                    select new { MaDaiLy = pxh.Key, TenDaiLy = pxh.Select(p => p.TenDaiLy).Single(), SoPhieuThu = pxh.Count(), TongTriGia = pxh.Sum(p => p.TongTien), TyLe = pxh.Sum(p => p.TongTien) / bcds_tong };

                this.BaoCaoDoanhSoData.DataSource = null;
                this.BaoCaoDoanhSoData.DataSource = baocaodoanhso.ToList();

            }


        }

        public void TimKiem()
        {
            this.MessageFailure = "";
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamConboBox.SelectedValue.ToString());
            //
            //load baocaodoanhso datagridview cua thang, nam duoc chon
            //
            var dsphieuxuathang = from pxh in this.db.tb_PhieuXuatHang.ToList()
                                  where pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam
                                  select new { MaDaiLy = pxh.Ma_DaiLy, TenDaiLy = pxh.tb_DaiLy.Ten_DaiLy, TongTien = pxh.TongTien };
            //
            //tim tong gia tri
            //
            double bcds_tong = db.tb_PhieuXuatHang.ToList().Where(pxh => pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam).Sum(p => p.TongTien);
            // group theo ma dai ly 
            if (dsphieuxuathang.Count() > 0)
            {
                var dsphieuxuathang2 = from dspx in dsphieuxuathang
                                       group dspx by dspx.MaDaiLy;

                var baocaodoanhso = from pxh in dsphieuxuathang2
                                    select new { MaDaiLy = pxh.Key, TenDaiLy = pxh.Select(p => p.TenDaiLy).Single(), SoPhieuThu = pxh.Count(), TongTriGia = pxh.Sum(p => p.TongTien), TyLe = pxh.Sum(p => p.TongTien) / bcds_tong };

                this.BaoCaoDoanhSoData.DataSource = null;
                this.BaoCaoDoanhSoData.DataSource = baocaodoanhso.ToList();

            }
        }

        
    }
}
