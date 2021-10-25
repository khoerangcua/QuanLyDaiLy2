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
    public class ThemPhieuXuatHangController
    {

        #region Entities, MessageFailure and Validators
        public string MessageFailure { get; set; }
        private QuanLyDaiLyEntities db;
        
        
        #endregion

        #region Temp Objects
        private tb_PhieuXuatHang tempPhieuXuatHang;
        private List<tb_ChiTiet_XuatHang> tempListChiTietPhieuXuatHang;        
        private int currentIdChiTietPhieuXuatHang { get; set; }
        
        #endregion

        #region Reference Controls
        public ComboBox DaiLyComboBox { get; set; }
        public ComboBox HangHoaComboBox { get; set; }
        public TextBox SoLuongTextBox { get; set; }
        public TextBox NgayLapTextBox { get; set; }
        public TextBox TienNoHienTai { get; set; }
        public DataGridView ChiTietPhieuXuatDataGridView { get; set; }
        public Button ThemButton { get; set; }
        public Button XoaButton { get; set; }
        public Button LuuButton { get; set; }
        public Button HuyButton { get; set; }
        #endregion

        #region Contructor
        public ThemPhieuXuatHangController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();                        
            this.tempPhieuXuatHang = new tb_PhieuXuatHang();
            this.tempListChiTietPhieuXuatHang = new List<tb_ChiTiet_XuatHang>();
            
            
           

        }
        #endregion

        #region Methods
        public void ChayLanDau()
        {
            //
            // Load Đại lý ComboBox
            //
            var dailys = from dl in db.tb_DaiLy
                         select new { ID = dl.Ma_DaiLy, Ten = dl.Ten_DaiLy };
            this.DaiLyComboBox.DataSource = dailys.ToList();
            this.DaiLyComboBox.ValueMember = "ID";
            this.DaiLyComboBox.DisplayMember = "Ten";
            //
            //Load Hàng hóa ComboBox
            //
            var hanghoas = from hh in db.tb_HangHoa
                           select new { ID = hh.Ma_HangHoa, Ten = hh.Ten_HangHoa };
            this.HangHoaComboBox.DataSource = hanghoas.ToList();
            this.HangHoaComboBox.ValueMember = "ID";
            this.HangHoaComboBox.DisplayMember = "Ten";
            //
            //Load Ngày lập phiếu
            //
            this.NgayLapTextBox.Text = DateTime.Now.ToString();
            //
            //Load nợ hiện tại
            //
            LoadNoHienTai();
            //
            //subcribe events
            //
            this.ChiTietPhieuXuatDataGridView.RowEnter += ChiTietPhieuXuatDataGridView_RowEnter;
            this.ThemButton.Click += ThemButton_Click;
            this.XoaButton.Click += XoaButton_Click;
            this.LuuButton.Click += LuuButton_Click;
            this.HuyButton.Click += HuyButton_Click;
            this.DaiLyComboBox.SelectedValueChanged += DaiLyComboBox_SelectedValueChanged;
            //
            // set state of controle
            //
            this.ThemButton.Enabled = true;
            this.XoaButton.Enabled = false;
            this.LuuButton.Enabled = false;
            this.HuyButton.Enabled = false;
            this.HangHoaComboBox.Enabled = true;
            this.DaiLyComboBox.Enabled = true;
            this.SoLuongTextBox.Enabled = true;
            this.NgayLapTextBox.Enabled = false;
            this.TienNoHienTai.Enabled = false;
            this.ChiTietPhieuXuatDataGridView.DataSource = null;
        }

        private bool ThemPhieuXuatHang()
        {
            //
            // reset messagefailure
            //
            this.MessageFailure = "";
            //
            //Lấy thông tin phiếu xuất hàng
            //
            int maphieuxuat = 1;
            if (db.tb_PhieuXuatHang.Any())
            {
                maphieuxuat = db.tb_PhieuXuatHang.Max(pxh => pxh.Ma_PhieuXuat) + 1;
            }

            int madaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            DateTime ngaylap = DateTime.Now;
            //
            //Lấy thông tin chi tiết phiếu xuất hàng
            //
            int machitietphieuxuat = 1;
            if (db.tb_ChiTiet_XuatHang.Any())
            {
                machitietphieuxuat = db.tb_ChiTiet_XuatHang.Max(ctpxh => ctpxh.Ma_ChiTiet_XuatHang) + 1;
            }

            int soluong = (this.SoLuongTextBox.Text).All(char.IsDigit) && !string.IsNullOrEmpty(this.SoLuongTextBox.Text) ? int.Parse(this.SoLuongTextBox.Text) : -1;
            int masanpham = int.Parse(this.HangHoaComboBox.SelectedValue.ToString());
            double dongia = (from hh in db.tb_HangHoa
                             where hh.Ma_HangHoa == masanpham
                             select hh.Don_Gia).Single();
            double thanhtien = dongia * soluong;
            //
            // Kiểm tra thông tin phiếu xuất hàng và chi tiết phiếu xuất hàng
            //
            if (soluong == -1)
            {
                this.MessageFailure = "so luong khong hop le";
                return false;
            }
            //
            //Kiểm tra quy định nợ
            //

            //
            //Nợ tối đa
            //
            double notoida = (from dl in db.tb_DaiLy
                              where dl.Ma_DaiLy == madaily
                              select dl.tb_LoaiDaiLy.TienNo_ToiDa).Single();

            var phieuxuathangs = db.tb_PhieuXuatHang.Where(pxh => pxh.Ma_DaiLy == madaily);
            //
            //Nợ cứng
            //
            double nocung = 0;            
            if (phieuxuathangs.Any())
            {
                nocung = phieuxuathangs.Sum(pxh => pxh.TongTien);

            }

            //
            //Tiền đã thu
            //
            var phieuthutiens = db.tb_PhieuThuTien.Where(ptt => ptt.Ma_DaiLy == madaily);
            double tiendathu = 0;
            if (phieuthutiens.Any())
            {
                tiendathu = phieuthutiens.Sum(ptt => ptt.So_Tien_Thu);
            }

            //
            // Nợ tạm thời
            //
            double notamthoi = tempPhieuXuatHang.TongTien + thanhtien;

            if ((nocung + notamthoi)-tiendathu <= notoida)
            {
                if (this.tempListChiTietPhieuXuatHang.Count() == 0)
                {
                    //
                    //Thêm lần đầu
                    //
                    this.tempPhieuXuatHang.Ma_PhieuXuat = maphieuxuat;
                    this.tempPhieuXuatHang.Ma_DaiLy = madaily;
                    this.tempPhieuXuatHang.Ngay_Lap = ngaylap;
                    this.tempPhieuXuatHang.TongTien = thanhtien;
                    //this.tempPhieuXuatHang.GhiChu = ghichu;

                    this.tempListChiTietPhieuXuatHang.Add(new tb_ChiTiet_XuatHang()
                    {
                        Ma_ChiTiet_XuatHang = machitietphieuxuat,
                        Ma_PhieuXuat = maphieuxuat,
                        Ma_HangHoa = masanpham,
                        So_Luong = soluong,
                        Don_Gia = dongia,
                        Thanh_Tien = thanhtien,

                    });
                }
                else
                {
                    //
                    //Đã tồn tại tempphieuxuathang và cập nhật lại tông tiền
                    //
                    machitietphieuxuat = this.tempListChiTietPhieuXuatHang.Max(p => p.Ma_ChiTiet_XuatHang)+1;
                    this.tempListChiTietPhieuXuatHang.Add(new tb_ChiTiet_XuatHang()
                    {
                        
                        Ma_ChiTiet_XuatHang = machitietphieuxuat,
                        Ma_PhieuXuat = maphieuxuat,
                        Ma_HangHoa = masanpham,
                        So_Luong = soluong,
                        Don_Gia = dongia,
                        Thanh_Tien = thanhtien,

                    });

                    this.tempPhieuXuatHang.TongTien = this.tempListChiTietPhieuXuatHang.Sum(p => p.Thanh_Tien);

                }                
                //
                //update form
                //                
                this.DaiLyComboBox.Enabled = false;
                this.TienNoHienTai.Text = (nocung - tiendathu + this.tempListChiTietPhieuXuatHang.Sum(p=>p.Thanh_Tien)).ToString();
                this.NgayLapTextBox.Text = this.tempPhieuXuatHang.Ngay_Lap.ToString();
                
                this.XoaButton.Enabled = true;
                this.LuuButton.Enabled = true;
                this.HuyButton.Enabled = true;
                this.ChiTietPhieuXuatDataGridView.DataSource = null;
                this.ChiTietPhieuXuatDataGridView.DataSource = tempListChiTietPhieuXuatHang;
                
                return true;
            }
            else
            {
                this.MessageFailure = "Tiền nợ vượt quá tiền nợ tối đa";
                return false;
            }
        }

        private bool XoaPhieuXuatHang()
        {

            //reset messagefailure
            this.MessageFailure = "";
            // xóa chi tiết phiếu xuất đã chọn
            var chitietphieuxuathang_temp = this.tempListChiTietPhieuXuatHang.Where(p => p.Ma_ChiTiet_XuatHang == currentIdChiTietPhieuXuatHang).Single();
            bool result = this.tempListChiTietPhieuXuatHang.Remove(chitietphieuxuathang_temp);
            if (result == false)
            {
                this.MessageFailure = "Xoa không thành công";
                return false;
            }
            //
            //reset form
            //
            if (this.tempListChiTietPhieuXuatHang.Count() == 0)
            {
                this.XoaButton.Enabled = false;
                this.LuuButton.Enabled = false;
                this.ChiTietPhieuXuatDataGridView.DataSource = null;
            }
            else
            {
                this.ChiTietPhieuXuatDataGridView.DataSource = null;
                this.ChiTietPhieuXuatDataGridView.DataSource = tempListChiTietPhieuXuatHang;
            }
            LoadNoHienTai();
            this.tempPhieuXuatHang.TongTien = this.tempListChiTietPhieuXuatHang.Sum(p => p.Thanh_Tien);
            return true;
        }

        private bool LuuPhieuXuatHang()
        {
            db.tb_PhieuXuatHang.Add(this.tempPhieuXuatHang);
            foreach (var item in this.tempListChiTietPhieuXuatHang)
            {
                db.tb_ChiTiet_XuatHang.Add(item);
            }

            if (db.SaveChanges() == 0)
            {
                this.MessageFailure = "Lưu không thành công";
                return false;
            }
            else
            {
                this.ChiTietPhieuXuatDataGridView.DataSource = null;                
                this.tempPhieuXuatHang = new tb_PhieuXuatHang();
                this.tempListChiTietPhieuXuatHang.Clear();
                this.DaiLyComboBox.Enabled = true;
                this.SoLuongTextBox.Text = "";
                this.NgayLapTextBox.Text = DateTime.Now.ToString();
                this.XoaButton.Enabled = false;
                this.LuuButton.Enabled = false;
                this.HuyButton.Enabled = false;
                this.LoadNoHienTai();
                return true;
            }
        }

        private bool HuyPhieuXuatHang()
        {
            this.tempPhieuXuatHang = new tb_PhieuXuatHang();
            this.tempListChiTietPhieuXuatHang.Clear();
            //
            //reset form
            //
            this.ChiTietPhieuXuatDataGridView.DataSource = null;
            this.tempPhieuXuatHang = new tb_PhieuXuatHang();
            this.tempListChiTietPhieuXuatHang.Clear();
            this.DaiLyComboBox.Enabled = true;
            this.SoLuongTextBox.Text = "";
            this.NgayLapTextBox.Text = DateTime.Now.ToString();
            this.TienNoHienTai.Text = "";
            this.XoaButton.Enabled = false;
            this.LuuButton.Enabled = false;
            this.HuyButton.Enabled = false;
            this.LoadNoHienTai();
            return true;
        }

        private void LoadNoHienTai()
        {
            int madaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            var phieuxuathangs = db.tb_PhieuXuatHang.Where(pxh => pxh.Ma_DaiLy == madaily);
            var phieuthutiens = db.tb_PhieuThuTien.Where(ptt => ptt.Ma_DaiLy == madaily);
            double nocung = 0;
            double tiendathu = 0;
            if (phieuxuathangs.Any())
            {
                nocung = phieuxuathangs.Sum(pxh => pxh.TongTien);

            }
            if (phieuthutiens.Any())
            {
                tiendathu = phieuthutiens.Sum(ptt => ptt.So_Tien_Thu);
            }

            this.TienNoHienTai.Text = (nocung - tiendathu + this.tempListChiTietPhieuXuatHang.Sum(p => p.Thanh_Tien)).ToString();
        }
        #endregion

        #region Events
        private void ChiTietPhieuXuatDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.currentIdChiTietPhieuXuatHang = int.Parse(this.ChiTietPhieuXuatDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());            
        }
        private void HuyButton_Click(object sender, EventArgs e)
        {
            this.HuyPhieuXuatHang();
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            this.LuuPhieuXuatHang();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            this.XoaPhieuXuatHang();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            this.ThemPhieuXuatHang();
        }
        private void DaiLyComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadNoHienTai();
        }

        
        #endregion
    }
}
