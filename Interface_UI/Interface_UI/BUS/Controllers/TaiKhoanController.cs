using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;
using Interface_UI.BUS.Validators;
namespace Interface_UI.BUS.Controllers
{
    public class TaiKhoanController
    {
        #region fields
        public string MessageFailure { get; set; }
        private TaiKhoanValidator taiKhoanValidator;
        public int CurrentID { get; set; }
        QuanLyDaiLyEntities db;
        #endregion
        
        #region controls
        //dang nhap
        public TextBox TaiKhoanTextBox { get; set; }
        public TextBox MatKhauTextBox { get; set; }
        public Button DangNhapButton { get; set; }
        //thay doi mat kahu
        public TextBox MatKhauCuTextBox { get; set; }
        public TextBox MatKhauMoiTextBox { get; set; }
        public TextBox NhapLaiMatKhauMoiTextBox { get; set; }
        public Button XacNhanButton { get; set; }
        #endregion


        public TaiKhoanController()
        {
            this.db = new QuanLyDaiLyEntities();
            this.taiKhoanValidator = new TaiKhoanValidator();
            this.MessageFailure = "";
            this.CurrentID = -1;
            //
            //subcribe events
            //
            this.DangNhapButton.Click += DangNhapButton_Click;
            this.XacNhanButton.Click += XacNhanButton_Click;
        }
        #region events
        private void XacNhanButton_Click(object sender, EventArgs e)
        {
            this.ThayDoiMatKhau(this.CurrentID);
        }

        private void DangNhapButton_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }
        #endregion

        private bool DangNhap()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            // Lấy thông tin
            //
            string taikhoan = this.TaiKhoanTextBox.Text;
            string matkhau = this.MatKhauTextBox.Text;
            //
            //kiểm tra thông tin đầu vào
            //            
            bool checkinput = taiKhoanValidator.KiemTraThongTinDangNhap(taikhoan, matkhau);
            if (checkinput == false)
            {
                this.MessageFailure = taiKhoanValidator.MessageFailure;
                return false;

            }
            else
            {
                //
                //Kiểm tra tài khoản và mật khẩu trong csdl
                //
                var result = db.tb_TaiKhoan.FirstOrDefault(tk => tk.TenTaiKhoan == taikhoan && tk.MatKhau == matkhau);
                if (result == default)
                {
                    this.MessageFailure = "Sai tài khoản hoặc mật khẩu";
                    return false;
                }
                else
                {
                    //
                    //reset form đăng nhập và lưu lại id tài khoản
                    //
                    this.TaiKhoanTextBox.Text = "";
                    this.MatKhauTextBox.Text = "";
                    this.CurrentID = result.ID_TaiKhoan;
                    return true;
                }
            }
        }

        private bool ThayDoiMatKhau(int currentID)
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            //Lấy thông tin
            //
            string mkcu = this.MatKhauCuTextBox.Text;
            string mkmoi = this.MatKhauMoiTextBox.Text;
            string nhaplaimkmoi = this.NhapLaiMatKhauMoiTextBox.Text;
            //
            //Kiểm tra thông tin đầu vào
            //
            bool checkinput = this.taiKhoanValidator.KiemTraThongTinDoiMatKhau(mkcu, mkmoi, nhaplaimkmoi);
            if (checkinput == false)
            {
                this.MessageFailure = taiKhoanValidator.MessageFailure;
                return false;
            }
            else
            {
                //
                //Xác thực id và mật khẩu hiện tại
                //
                var result = db.tb_TaiKhoan.FirstOrDefault(tk => tk.ID_TaiKhoan == currentID && tk.MatKhau == mkcu);
                if (result == default)
                {
                    this.MessageFailure = "Mật khẩu không đúng";
                    return false;
                }
                else
                {
                    result.MatKhau = mkmoi;
                    int result2 = db.SaveChanges();
                    //
                    //Kiểm tra lưu thay đổi thành công
                    //
                    if (result2 == 0)
                    {
                        this.MessageFailure = "Thay đổi mật khẩu không thành công";
                        return false;
                    }
                    else
                    {
                        //
                        //reset form thay đổi mật khẩu
                        //
                        this.MatKhauCuTextBox.Text = "";
                        this.MatKhauMoiTextBox.Text = "";
                        this.NhapLaiMatKhauMoiTextBox.Text = "";
                        return true;
                    }
                }
            }
        }
    }
}
