using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;

namespace Interface_UI.BUS.Controllers
{
    public class HangHoaController
    {
        #region fields
        public string MessageFailure { get; set; }
        private QuanLyDaiLyEntities db;
        #endregion

        #region controls
        public TextBox MaHangHoaTextBox { get; set; }
        public TextBox TenHangHoaTextBox { get; set; }
        public TextBox DonGiaTextBox { get; set; }
        public TextBox DonViTinhTextBox { get; set; }
        public DataGridView HangHoaData { get; set; }
        #endregion

        #region constructor
        public HangHoaController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();
            this.HangHoaData.RowEnter += HangHoaData_RowEnter;
            this.MaHangHoaTextBox.Enabled = false;
        }
        #endregion

        #region methods
        public void LoadLanDau()
        {
            var hanghoas = from hh in db.tb_HangHoa.ToList()
                           select new { MaHangHoa = hh.Ma_HangHoa, TenHangHoa = hh.Ten_HangHoa, DonGia = hh.Don_Gia, DonViTinh = hh.DonVi_Tinh };
            this.HangHoaData.DataSource = null;
            this.HangHoaData.DataSource = hanghoas;

        }

       

        public bool ThemHangHoa()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            //lay thong tin hang hoa tren form
            //
            int mahanghoa = 1;
            if (this.db.tb_HangHoa.Any())
            {
                mahanghoa = this.db.tb_HangHoa.Max(p => p.Ma_HangHoa) + 1;
            }
            string tenhanghoa = this.TenHangHoaTextBox.Text;
            double dongia = double.Parse(this.DonGiaTextBox.Text);
            string donvitinh = this.DonViTinhTextBox.Text;
            //
            //thuc thi them hang hoa vao csdl
            //
            this.db.tb_HangHoa.Add(new tb_HangHoa { Ma_HangHoa = mahanghoa, Ten_HangHoa = tenhanghoa, Don_Gia = dongia, DonVi_Tinh = donvitinh });
            //
            //kiem tra them co thanh cong
            //
            if (db.SaveChanges() == 0)
            {

                this.MessageFailure = "them hang hoa khong thanh cong";
                return false;
            }
            else
            {
                //
                //reset form
                //
                var hanghoas = from hh in db.tb_HangHoa.ToList()
                               select new { MaHangHoa = hh.Ma_HangHoa, TenHangHoa = hh.Ten_HangHoa, DonGia = hh.Don_Gia, DonViTinh = hh.DonVi_Tinh };
                this.HangHoaData.DataSource = null;
                this.HangHoaData.DataSource = hanghoas;

                return true;
            }
        }

        public bool XoaHangHoa()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            //lay thong tin
            //
            int mahanghoa = int.Parse(this.MaHangHoaTextBox.Text);
            //
            //kiem tra hang hoa co ton tai trong csdl
            //
            var hanghoa = this.db.tb_HangHoa.FirstOrDefault(hh => hh.Ma_HangHoa == mahanghoa);

            if (hanghoa == default)
            {
                this.MessageFailure = "hang hoa khong ton tai";
                return false;

            }
            else
            {
                //
                // thuc thi xoa va kiem tra thanh cong? 
                //
                this.db.tb_HangHoa.Remove(hanghoa);
                if (db.SaveChanges() == 0)
                {
                    this.MessageFailure = "xoa khong thanh cong";
                    return false;
                }
                else
                {
                    //
                    //reset form
                    //
                    var hanghoas = from hh in db.tb_HangHoa.ToList()
                                   select new { MaHangHoa = hh.Ma_HangHoa, TenHangHoa = hh.Ten_HangHoa, DonGia = hh.Don_Gia, DonViTinh = hh.DonVi_Tinh };
                    this.HangHoaData.DataSource = null;
                    this.HangHoaData.DataSource = hanghoas;
                    return true;
                }
            }
        }

        public bool SuaHangHoa()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            //lay thong tinhang hoa
            //
            int mahanghoa = int.Parse(this.MaHangHoaTextBox.Text);
            //
            //tim kiem hang hoa trong csdl 
            //
            var hanghoa = this.db.tb_HangHoa.FirstOrDefault(hh => hh.Ma_HangHoa == mahanghoa);

            if (hanghoa == default)
            {
                this.MessageFailure = "hang hoa khong ton tai";
                return false;
            }
            else
            {
                //
                //lay thong tin hang hoa va cap nhat
                //
                hanghoa.Ten_HangHoa = this.TenHangHoaTextBox.Text;
                hanghoa.Don_Gia = double.Parse(this.DonGiaTextBox.Text);
                hanghoa.DonVi_Tinh = this.DonViTinhTextBox.Text;
                //
                //kiem tra cap nhat co thanh cong ?
                //
                if (db.SaveChanges() == 0)
                {
                    this.MessageFailure = "Sua khong thanh cong";
                    return false;
                }
                else
                {
                    //
                    //reset form
                    //
                    var hanghoas = from hh in db.tb_HangHoa.ToList()
                                   select new { MaHangHoa = hh.Ma_HangHoa, TenHangHoa = hh.Ten_HangHoa, DonGia = hh.Don_Gia, DonViTinh = hh.DonVi_Tinh };
                    this.HangHoaData.DataSource = null;
                    this.HangHoaData.DataSource = hanghoas;
                    return true;
                }
            }
        }
        #endregion

        #region events
        private void HangHoaData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.MaHangHoaTextBox.Text = this.HangHoaData.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.TenHangHoaTextBox.Text = this.HangHoaData.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.DonGiaTextBox.Text = this.HangHoaData.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.DonViTinhTextBox.Text = this.HangHoaData.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        #endregion
    }
}
