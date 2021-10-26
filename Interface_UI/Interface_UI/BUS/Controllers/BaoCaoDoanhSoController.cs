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
        #region fields
        public string MessageFailure { get; set; }
        QuanLyDaiLyEntities db;
        #endregion

        #region controls
        public ComboBox ThangComboBox { get; set; }
        public ComboBox NamConboBox { get; set; }
        public Button InButton { get; set; }
        public Button TimButton { get; set; }
        public DataGridView BaoCaoDoanhSoData { get; set; }
        #endregion

        #region constructor
        public BaoCaoDoanhSoController()
        {
            this.db = new QuanLyDaiLyEntities();
            this.MessageFailure = "";
            

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
            this.TimButton.Click += TimButton_Click;
            this.InButton.Click += InButton_Click;
            //
            //set state of controls
            //
            this.InButton.Enabled = false;
        }

        private void TimKiem()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            // lay thong tin thang, nam da chon
            //
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamConboBox.SelectedValue.ToString());
            //
            //load baocaodoanhso datagridview 
            //
            var dsphieuxuathang = from pxh in this.db.tb_PhieuXuatHang
                                  where pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam
                                  select new { MaDaiLy = pxh.Ma_DaiLy, TenDaiLy = pxh.tb_DaiLy.Ten_DaiLy, TongTien = pxh.TongTien };
            //
            //tim tong gia tri
            //
            double bcds_tong = db.tb_PhieuXuatHang.Where(pxh => pxh.Ngay_Lap.Month == thang && pxh.Ngay_Lap.Year == nam).Sum(p => p.TongTien);
            // group theo ma dai ly 
            if (dsphieuxuathang.Any())
            {
                var dsphieuxuathang2 = from dspx in dsphieuxuathang
                                       group dspx by dspx.MaDaiLy;

                var baocaodoanhso = from pxh in dsphieuxuathang2
                                    select new { MaDaiLy = pxh.Key, TenDaiLy = pxh.Select(p => p.TenDaiLy).FirstOrDefault(), SoPhieuThu = pxh.Count(), TongTriGia = pxh.Sum(p => p.TongTien), TyLe = Math.Round( pxh.Sum(p => p.TongTien) / bcds_tong,3 )};
                this.InButton.Enabled = true;
                this.BaoCaoDoanhSoData.DataSource = null;
                this.BaoCaoDoanhSoData.DataSource = baocaodoanhso.ToList();

            }
            else
            {
                this.MessageFailure = "khong ton tai phieu xuat hang tuong ung";
            }


        }
        #endregion

        #region event
        private void InButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            this.TimKiem();
        }
        #endregion

    }
}
