using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using Interface_UI.DAO;
namespace Interface_UI.BUS.Controllers
{
    public class XoaPhieuXuatHangController
    {
        #region fields
        public string MessageFailure { get; set; }
        private QuanLyDaiLyEntities db;
        private int CurrentIDPhieuXuat { get; set; }
        #endregion

        #region controls
        public ComboBox DaiLyComboBox { get; set; }
        public ComboBox ThangComboBox { get; set; }
        public ComboBox NamComboBox { get; set; }
        public DataGridView Data { get; set; }
        public Button TimKiemButton { get; set; }
        public Button XoaButton { get; set; }
        #endregion

        #region constructor
        public XoaPhieuXuatHangController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();
            this.Data.RowEnter += Data_RowEnter;
            this.TimKiemButton.Click += TimKiemButton_Click;
            this.XoaButton.Click += XoaButton_Click;
            //
            //set state of control
            //
            this.XoaButton.Enabled = false;
        }
        #endregion

        #region methods
        public void ChayLanDau()
        {
            //
            //Load Dai Ly ComboBox
            //

            var dailys = from dl in db.tb_DaiLy
                         select new { ID = dl.Ma_DaiLy, Name = dl.Ten_DaiLy };
            this.DaiLyComboBox.DataSource = dailys.ToList();

            //
            //Load Thang ComboBox
            //

            var thangs = (from thang in db.tb_PhieuXuatHang
                          select new { ID = thang.Ngay_Lap.Month, Value = thang.Ngay_Lap.Month }).Distinct();
            this.ThangComboBox.DataSource = thangs.ToList();
            this.ThangComboBox.ValueMember = "ID";
            this.ThangComboBox.DisplayMember = "Value";

            //Load Nam ComboBox
            //
            //

            var nams = (from thang in db.tb_PhieuXuatHang
                        select new { ID = thang.Ngay_Lap.Year, Value = thang.Ngay_Lap.Year }).Distinct();
            this.NamComboBox.DataSource = nams.ToList();
            this.NamComboBox.ValueMember = "ID";
            this.NamComboBox.DisplayMember = "Value";

        }

        public void TimKiem()
        {
            //
            //reset message failure
            //

            this.MessageFailure = "";
            //
            //Lay thong tin
            //

            int madaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamComboBox.SelectedValue.ToString());
            //
            //Thuc hien tim kiem
            //

            var phieuxuathangs = from px in db.tb_PhieuXuatHang.ToList()
                          where px.Ma_DaiLy == madaily && px.Ngay_Lap.Month == thang && px.Ngay_Lap.Year == nam
                          select px;
            if (phieuxuathangs.Count()>0)
            {
                this.XoaButton.Enabled = true;
                this.Data.DataSource = null;
                Data.DataSource = phieuxuathangs;
                
            }
            else
            {
                this.MessageFailure = "khong tim thay phieu xuat hang";
                this.Data.DataSource = null;
            }
                          
        }
        public bool XoaPhieuXuatHang()
        {
            //
            //kiem tra ton tai
            //
            tb_PhieuXuatHang phieuxuathang = (from pxh in db.tb_PhieuXuatHang
                           where pxh.Ma_PhieuXuat == this.CurrentIDPhieuXuat
                           select pxh).Single();
            //
            //thuc thi xoa phieu xuat hang
            //

            this.db.tb_PhieuXuatHang.Remove(phieuxuathang);
            //
            //kiem tra thuc thi co thanh cong
            //
            if (db.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                this.MessageFailure = "Xoa Khong Thanh Cong";
                return false;
            }
        }
        #endregion

        #region events

        private void XoaButton_Click(object sender, EventArgs e)
        {
            this.XoaPhieuXuatHang();
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            this.TimKiem();
        }

        private void Data_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.CurrentIDPhieuXuat = int.Parse(this.Data.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        #endregion
    }

}
