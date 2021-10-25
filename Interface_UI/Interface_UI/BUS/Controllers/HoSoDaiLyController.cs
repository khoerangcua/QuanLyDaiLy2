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
    class HoSoDaiLyController
    {

        #region Fields and Properties
        public string MessageFailure { get; set; }
        //
        // Data Access
        //
        QuanLyDaiLyEntities db;

        //
        //Validator
        //
        HoSoDaiLyValidator hoSoDaiLyValidator;

        //
        //Controls
        //

        public TextBox MaDaiLyText { get; set; }
        public TextBox TenDaiLyText_HienThi { get; set; }
        public TextBox TenDaiLyText_TimKiem { get; set; }
        public TextBox DiaChiText { get; set; }
        public TextBox DienThoaiText { get; set; }
        public TextBox NgayTiepNhanText { get; set; }
        public TextBox EmailText { get; set; }
        public DataGridView HoSoDaiLyDataGridView { get; set; }
        public ComboBox LoaiDaiLyComboBox { get; set; }
        public ComboBox QuanComboBox_HienThi { get; set; }
        public ComboBox QuanComboBox_TimKiem { get; set; }
        public Button ThemButton { get; set; }
        public Button XoaButton { get; set; }
        public Button SuaButton { get; set; }
        public Button TimKiemButton { get; set; }
        public Button ResetButton { get; set; }
        #endregion

        #region Constructor
        public HoSoDaiLyController()
        {
            this.db = new QuanLyDaiLyEntities();
            this.hoSoDaiLyValidator = new HoSoDaiLyValidator();
            this.MessageFailure = "";
            
            

        }

      


        #endregion

        #region Methods

        public void ChayLanDau()
        {
            //
            // Load Quận ComboBox
            //
            var quans = from q in db.tb_Quan
                        select new
                        {
                            MaQuan = q.Ma_Quan,
                            TenQuan = q.Ten_Quan
                        };

            QuanComboBox_HienThi.DataSource = quans.ToList();
            QuanComboBox_HienThi.ValueMember = "MaQuan";
            QuanComboBox_HienThi.DisplayMember = "TenQuan";

            QuanComboBox_TimKiem.DataSource = quans.ToList();
            QuanComboBox_TimKiem.ValueMember = "MaQuan";
            QuanComboBox_TimKiem.DisplayMember = "TenQuan";
            //
            // Load loại đại lý ComboBox
            //

            var loaidailys = from ldl in db.tb_LoaiDaiLy
                             select new
                             {
                                 MaLoai = ldl.Ma_Loai_DaiLy,
                                 TenLoai = ldl.Ten_Loai

                             };

            LoaiDaiLyComboBox.DataSource = loaidailys.ToList();
            LoaiDaiLyComboBox.ValueMember = "MaLoai";
            LoaiDaiLyComboBox.DisplayMember = "TenLoai";
            //
            // Load danh sach dai ly 
            //
            LoadDaiLy();
            //
            //subcribe events
            //
            this.HoSoDaiLyDataGridView.RowEnter += HoSoDaiLyDataGridView_RowEnter;
            this.ThemButton.Click += ThemButton_Click;
            this.XoaButton.Click += XoaButton_Click;
            this.SuaButton.Click += SuaButton_Click;
            this.TimKiemButton.Click += TimKiemButton_Click;
            this.ResetButton.Click += ResetButton_Click;
            //
            //set state of controls
            //
            this.MaDaiLyText.Enabled = false;
            this.NgayTiepNhanText.Enabled = false;

        }

        private void LoadDaiLy()
        {
            var dailys = from dl in db.tb_DaiLy
                         select new { ID = dl.Ma_DaiLy, Ten = dl.Ten_DaiLy, SDT = dl.Dien_Thoai, MaQuan = dl.Ma_Quan, Email = dl.Email, MaLoai = dl.Ma_Loai_DaiLy, DiaChi = dl.Dia_Chi, NgayTiepNhan = dl.Ngay_Tiep_Nhan.ToString() };
   
            this.HoSoDaiLyDataGridView.DataSource = null;
            this.HoSoDaiLyDataGridView.DataSource = dailys.ToList();
        }

        private void ResetForm()
        {
            this.MaDaiLyText.Text = "";
            this.TenDaiLyText_HienThi.Text = "";
            this.DienThoaiText.Text = "";
            this.EmailText.Text = "";
            this.DiaChiText.Text = "";
            this.NgayTiepNhanText.Text = "";
            this.TenDaiLyText_TimKiem.Text = "";
            this.HoSoDaiLyDataGridView.DataSource = null;
        }

        private bool ThemDaiLy()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            // Lấy thông tin đại lý
            //
            int id = 1;
            if (db.tb_DaiLy.Any())
            {
                id = db.tb_DaiLy.Max(dl => dl.Ma_DaiLy) + 1;
            }
            string ten = this.TenDaiLyText_HienThi.Text;
            string sdt = this.DienThoaiText.Text.All(char.IsDigit)? this.DienThoaiText.Text: "";
            int maquan = int.Parse(this.QuanComboBox_HienThi.SelectedValue.ToString());
            string email = this.EmailText.Text;
            int maloai = int.Parse(this.LoaiDaiLyComboBox.SelectedValue.ToString());
            string diachi = this.DiaChiText.Text;
            DateTime ngaytiepnhan = DateTime.Now;
            //
            //Kiểm tra thông tin đầu vào
            //
            bool checkinput = this.hoSoDaiLyValidator.KiemTraThongTinDaiLy(ten, sdt, email, diachi);
            if (checkinput == false)
            {
                this.MessageFailure = hoSoDaiLyValidator.MessageFailure;
                return false;
            }
            else
            {
                //
                // Tạo mới đối tượng Đại Lý và lưu vào csdl
                //
                db.tb_DaiLy.Add(new tb_DaiLy
                {
                    Ma_DaiLy = id,
                    Ten_DaiLy = ten,
                    Dien_Thoai = sdt,
                    Ma_Quan = maquan,
                    Email = email,
                    Ma_Loai_DaiLy = maloai,
                    Dia_Chi = diachi,
                    Ngay_Tiep_Nhan = ngaytiepnhan

                });                
                //
                //Kiểm tra lưu thành công
                //
                if (db.SaveChanges() == 0)
                {
                    this.MessageFailure = "Thêm đại lý không thành công";
                    return false;
                }
                else
                {
                    LoadDaiLy();
                    return true;
                }
            }
        }

        private bool XoaDaiLy()
        {
            //
            //Reset messagefailure
            //
            this.MessageFailure = "";
            //
            //Lấy thông tin
            //
            int id = string.IsNullOrEmpty(this.MaDaiLyText.Text) ? -1 : int.Parse(this.MaDaiLyText.Text);
            //
            //Kiểm tra thông tin đầu vào
            //
            if (id == -1)
            {
                this.MessageFailure = "Chưa chọn đại lý";
                return false;

            }
            else
            {
                //
                //Kiểm tra đại lý có tồn tại trong csdl
                //
                tb_DaiLy daily = db.tb_DaiLy.FirstOrDefault(dl => dl.Ma_DaiLy == id);
                if (daily == default)
                {
                    this.MessageFailure = "Đại lý không tồn tại";
                    return false;

                }
                else
                {
                    //
                    //Xóa đại lý khỏi csdl
                    //
                    db.tb_DaiLy.Remove(daily);
                    //
                    //Kiểm tra xóa thành công
                    //
                    if (db.SaveChanges() == 0)
                    {
                        this.MessageFailure = "Xóa đại lý không thành công";
                        return false;
                    }
                    else
                    {
                        LoadDaiLy();
                        return true;
                    }
                }
            }
        }

        private bool CapNhatDaiLy()
        {
            //
            //reset messagefailure
            //
            this.MessageFailure = "";
            //
            //Lấy thông tin đại lý
            //
            int id = string.IsNullOrEmpty(this.MaDaiLyText.Text) ? -1 : int.Parse(this.MaDaiLyText.Text);
            string ten = this.TenDaiLyText_HienThi.Text;
            string sdt = this.DienThoaiText.Text.All(char.IsDigit) ? this.DienThoaiText.Text : "";
            int maquan = int.Parse(this.QuanComboBox_HienThi.SelectedValue.ToString());
            string email = this.EmailText.Text;
            int maloai = int.Parse(this.LoaiDaiLyComboBox.SelectedValue.ToString());
            string diachi = this.DiaChiText.Text;
            //
            // Kiểm tra id có trống ?
            //
            if (id == -1)
            {
                this.MessageFailure = "Chua chon dai ly";
                return false;

            }
            else
            {
                //
                // Kiểm tra tồn tại
                //
                tb_DaiLy daily = db.tb_DaiLy.FirstOrDefault(dl => dl.Ma_DaiLy == id);
                if (daily == default)
                {
                    this.MessageFailure = "Đại lý không tồn tại";
                    return false;

                }
                else
                {
                    //
                    //Kiểm tra thông tin đầu vào
                    //
                    bool checkinput = this.hoSoDaiLyValidator.KiemTraThongTinDaiLy(ten, sdt, email, diachi);
                    if (checkinput == false)
                    {
                        this.MessageFailure = hoSoDaiLyValidator.MessageFailure;
                        return false;
                    }
                    else
                    {
                        //
                        //Thực hiện thay đổi thông tin đại lý và lưu vào csdl
                        //
                        daily.Ten_DaiLy = ten;
                        daily.Ma_Quan = maquan;
                        daily.Dien_Thoai = sdt;
                        daily.Email = email;
                        daily.Ma_Loai_DaiLy = maloai;
                        daily.Dia_Chi = diachi;
                        
                        //
                        //Kiểm tra lưu vào cơ sở dữ liệu
                        //
                        if (db.SaveChanges() == 0)
                        {
                            this.MessageFailure = "Thay đổi thông tin đại lý không thành công";
                            return false;
                        }
                        else
                        {
                            LoadDaiLy();
                            return true;
                        }
                    }

                }
            }
        }

        private void TimKiemDaiLy()
        {
            //
            //Lấy thông tin đại lý
            //
            string ten = this.TenDaiLyText_TimKiem.Text;
            int maquan = int.Parse(this.QuanComboBox_TimKiem.SelectedValue.ToString());
            //
            //Thực thi tìm kiếm
            //
            if (ten == "")
            {
                //
                //Load tất cả đại lý theo mã quận
                //
                var dailys = from dl in db.tb_DaiLy                             
                             where dl.Ma_Quan == maquan
                             select new { ID = dl.Ma_DaiLy, Ten = dl.Ten_DaiLy, SDT = dl.Dien_Thoai, MaQuan = dl.Ma_Quan, Email = dl.Email, MaLoai = dl.Ma_Loai_DaiLy, DiaChi = dl.Dia_Chi, NgayTiepNhan = dl.Ngay_Tiep_Nhan.ToString() };
                this.HoSoDaiLyDataGridView.DataSource = null;
                this.HoSoDaiLyDataGridView.DataSource = dailys.ToList();
            }
            else
            {
                //
                //Tìm kiếm đại lý gần đúng theo tên và mã quận
                //
                var result = from dl in db.tb_DaiLy                             
                             where dl.Ma_Quan == maquan && dl.Ten_DaiLy.Contains(ten)
                             select new { ID = dl.Ma_DaiLy, Ten = dl.Ten_DaiLy, SDT = dl.Dien_Thoai, MaQuan = dl.Ma_Quan, Email = dl.Email, MaLoai = dl.Ma_Loai_DaiLy, DiaChi = dl.Dia_Chi, NgayTiepNhan = dl.Ngay_Tiep_Nhan.ToString() };
                this.HoSoDaiLyDataGridView.DataSource = null;
                this.HoSoDaiLyDataGridView.DataSource = result.ToList();
            }
        }



        #endregion

        #region events
        private void HoSoDaiLyDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.MaDaiLyText.Text = this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.TenDaiLyText_HienThi.Text = this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.DienThoaiText.Text = this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.QuanComboBox_HienThi.SelectedValue = int.Parse(this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            this.EmailText.Text = this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();  
            this.LoaiDaiLyComboBox.SelectedValue = int.Parse(this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            this.DiaChiText.Text = this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.NgayTiepNhanText.Text = this.HoSoDaiLyDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            this.TimKiemDaiLy();
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            this.CapNhatDaiLy();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            this.XoaDaiLy();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            this.ThemDaiLy();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        #endregion

    }
}