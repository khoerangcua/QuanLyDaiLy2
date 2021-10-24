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
    public class SuaPhieuXuatHangController
    {
        #region messagefaiure, db, validators
        public string MessageFailure { get; set; }
        private QuanLyDaiLyEntities db;
        private ChiTietPhieuXuatValidator chiTietPhieuXuatValidator;

        #endregion

        #region temp fields
        private int currentIDPhieuXuatHang { get; set; }
        private int rowChiTietPhieuXuatHang { get; set; }
        private List<tb_ChiTiet_XuatHang> tempthemChiTiet_XuatHangs { get; set; }
        private List<tb_ChiTiet_XuatHang> tempxoaChiTiet_XuatHangs { get; set; }
        #endregion

        #region reference controlls
        public ComboBox DaiLyComboBox { get; set; }
        public ComboBox ThangComboBox { get; set; }
        public ComboBox NamComboBox { get; set; }
        public ComboBox HangHoaComboBox { get; set; }
        public TextBox SoLuongTextBox { get; set; }
        public TextBox NoHienTaiTextBox { get; set; }
        public TextBox GhiChuTexBox { get; set; }
        public DataGridView PhieuXuatHangData { get; set; }
        public DataGridView ChiTietPhieuXuatHangData { get; set; }
        public Button TimButton { get; set; }
        public Button XoaButton { get; set; }
        public Button ThemButton { get; set; }
        public Button LuuButton { get; set; }
        public Button HuyButton { get; set; }
        #endregion

        #region constructor
        public SuaPhieuXuatHangController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();
            this.chiTietPhieuXuatValidator = new ChiTietPhieuXuatValidator();
            this.PhieuXuatHangData.RowEnter += PhieuXuatHangData_RowEnter;
            this.ChiTietPhieuXuatHangData.RowEnter += ChiTietPhieuXuatHangData_RowEnter;
            this.tempthemChiTiet_XuatHangs = new List<tb_ChiTiet_XuatHang>();
            this.tempxoaChiTiet_XuatHangs = new List<tb_ChiTiet_XuatHang>();
            //
            // Thiet lap trang thai cua cac control
            //
            HangHoaComboBox.Enabled = false;
            SoLuongTextBox.Enabled = false;
            NoHienTaiTextBox.Enabled = false;
            GhiChuTexBox.Enabled = false;
            PhieuXuatHangData.Enabled = false;
            ChiTietPhieuXuatHangData.Enabled = false;
            XoaButton.Enabled = false;
            ThemButton.Enabled = false;
            LuuButton.Enabled = false;
            HuyButton.Enabled = false;

        }
        #endregion

        #region events
        private void ChiTietPhieuXuatHangData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.rowChiTietPhieuXuatHang = e.RowIndex;
        }

        private void PhieuXuatHangData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.currentIDPhieuXuatHang = int.Parse(this.PhieuXuatHangData.Rows[e.RowIndex].Cells[0].Value.ToString());
            LoadChiTietPhieuXuatHang();
            this.ThemButton.Enabled = true;
            this.SoLuongTextBox.Enabled = true;
            this.HangHoaComboBox.Enabled = true;
        }
        #endregion

        #region public methods
        public void LoadLanDau()
        {
            //
            //Load dai ly ComboBox
            //
            if (db.tb_DaiLy.Any())
            {
                var result = from dl in db.tb_DaiLy.ToList()
                             select new { ID = dl.Ma_DaiLy, Name = dl.Ten_DaiLy };
                this.DaiLyComboBox.DataSource = result;
            }
            //
            //Load Thang ComboBox
            //
            if (db.tb_PhieuXuatHang.Any())
            {
                var result = (from px in db.tb_PhieuXuatHang.ToList()
                              select new { ID = px.Ngay_Lap.Month, Name = px.Ngay_Lap.Month }).Single();
                this.ThangComboBox.DataSource = result;
                this.ThangComboBox.DisplayMember = "Name";
                this.ThangComboBox.ValueMember = "ID";
            }
            //
            //Load Nam ComboBox
            //
            if (db.tb_PhieuXuatHang.Any())
            {
                var result = (from px in db.tb_PhieuXuatHang.ToList()
                              select new { ID = px.Ngay_Lap.Year, Name = px.Ngay_Lap.Year }).Single();
                this.ThangComboBox.DataSource = result;
                this.ThangComboBox.DisplayMember = "Name";
                this.ThangComboBox.ValueMember = "ID";
            }
            //
            //Load Hang Hoa ComboBox
            //
            if (db.tb_HangHoa.Any())
            {
                var result = from hh in db.tb_HangHoa.ToList()
                             select new { ID = hh.Ma_HangHoa, Name = hh.Ten_HangHoa };
                this.HangHoaComboBox.DataSource = result;
                this.HangHoaComboBox.ValueMember = "ID";
                this.HangHoaComboBox.DisplayMember = "Name";

            }



        }

        public void TimKiem()
        {
            int madaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamComboBox.SelectedValue.ToString());
            if (db.tb_PhieuXuatHang.Any())
            {
                var result = from px in db.tb_PhieuXuatHang.ToList()
                             where px.Ma_DaiLy == madaily && px.Ngay_Lap.Month == thang && px.Ngay_Lap.Year == nam
                             select px;
                if (result.Count() > 0)
                {
                    this.PhieuXuatHangData.DataSource = null;
                    this.PhieuXuatHangData.DataSource = result;
                    this.PhieuXuatHangData.Enabled = true;
                    LoadNoHienTai();
                }
                else
                {
                    this.PhieuXuatHangData.DataSource = null;
                }
            }
        }


        public bool ThemChiTietPhieuXuat()
        {
            //
            //Lay thong tin
            //
            int idchitietphieuxuat = 1;
            if (db.tb_ChiTiet_XuatHang.Any())
            {
                idchitietphieuxuat = db.tb_ChiTiet_XuatHang.Max(p => p.Ma_ChiTiet_XuatHang) + 1;

            }

            int idphieuxuathang = this.currentIDPhieuXuatHang;
            int idhanghoa = int.Parse(this.HangHoaComboBox.SelectedValue.ToString());
            int soluong = this.SoLuongTextBox.Text.All(char.IsDigit) ? int.Parse(this.SoLuongTextBox.Text) : -1;
            double dongia = (from hh in db.tb_HangHoa
                             where hh.Ma_HangHoa == int.Parse(this.HangHoaComboBox.SelectedValue.ToString())
                             select hh.Don_Gia).Single();
            double thanhtien = soluong * dongia;
            //
            // kiem tra thong tin input
            //
            bool checkinput = this.chiTietPhieuXuatValidator.KiemTraChiTietPhieuXuat(idphieuxuathang, idhanghoa, soluong, dongia, thanhtien);
            if (checkinput == false)
            {
                this.MessageFailure = "chua dien day du thong tin";
                return false;
            }
            else
            {
                //
                //kiem tra tien no toi da
                // 
                double tiennotoida = (from dl in db.tb_DaiLy.ToList()
                                      join ldl in db.tb_LoaiDaiLy on dl.Ma_Loai_DaiLy equals ldl.Ma_Loai_DaiLy
                                      where dl.Ma_DaiLy == int.Parse(this.DaiLyComboBox.SelectedValue.ToString())
                                      select ldl.TienNo_ToiDa).Single();
                if (double.Parse(this.NoHienTaiTextBox.Text) + thanhtien > tiennotoida)
                {
                    this.MessageFailure = "Vuot qua tien no toi da";
                    return false;
                }
                else
                {
                    this.tempthemChiTiet_XuatHangs.Add(new tb_ChiTiet_XuatHang
                    {
                        Ma_ChiTiet_XuatHang = idchitietphieuxuat,
                        Ma_PhieuXuat = idphieuxuathang,
                        Ma_HangHoa = idhanghoa,
                        So_Luong = soluong,
                        Thanh_Tien = thanhtien,
                        Don_Gia = dongia

                    }

                        );
                    this.DaiLyComboBox.Enabled = false;
                    this.LuuButton.Enabled = true;
                    this.HuyButton.Enabled = true;
                    LoadNoHienTai();
                    return true;
                }
            }

        }

        public bool XoaChiTietPhieuXuat()
        {
            this.MessageFailure = "";

            //
            // lay thong tin chi tiet phieu xuat hang


            int idchitietphieuxuat = int.Parse(this.ChiTietPhieuXuatHangData.Rows[rowChiTietPhieuXuatHang].Cells[0].Value.ToString());
            int idphieuxuat = int.Parse(this.ChiTietPhieuXuatHangData.Rows[rowChiTietPhieuXuatHang].Cells[1].Value.ToString());
            int idhanghoa = int.Parse(this.ChiTietPhieuXuatHangData.Rows[rowChiTietPhieuXuatHang].Cells[2].Value.ToString());
            int soluong = int.Parse(this.ChiTietPhieuXuatHangData.Rows[rowChiTietPhieuXuatHang].Cells[3].Value.ToString());
            double dongia = int.Parse(this.ChiTietPhieuXuatHangData.Rows[rowChiTietPhieuXuatHang].Cells[4].Value.ToString());
            double thanhtien = int.Parse(this.ChiTietPhieuXuatHangData.Rows[rowChiTietPhieuXuatHang].Cells[5].Value.ToString());
            tb_ChiTiet_XuatHang chiTiet_XuatHang = new tb_ChiTiet_XuatHang()
            {
                Ma_ChiTiet_XuatHang = idchitietphieuxuat,
                Ma_PhieuXuat = idphieuxuat,
                Ma_HangHoa = idhanghoa,
                So_Luong = soluong,
                Don_Gia = dongia,
                Thanh_Tien = thanhtien

            };
            this.tempxoaChiTiet_XuatHangs.Add(chiTiet_XuatHang);
            LoadChiTietPhieuXuatHang();
            this.DaiLyComboBox.Enabled = false;
            this.LuuButton.Enabled = true;
            this.HuyButton.Enabled = true;
            return true;
        }

        public bool LuuThayDoi()
        {
            this.MessageFailure = "";
            if (this.tempthemChiTiet_XuatHangs.Count + this.tempxoaChiTiet_XuatHangs.Count > 0)
            {
                db.tb_ChiTiet_XuatHang.AddRange(this.tempthemChiTiet_XuatHangs);
                db.tb_ChiTiet_XuatHang.RemoveRange(this.tempxoaChiTiet_XuatHangs);
                if (db.SaveChanges() > 0)
                {

                    this.tempthemChiTiet_XuatHangs.Clear();
                    this.tempxoaChiTiet_XuatHangs.Clear();
                    LoadChiTietPhieuXuatHang();
                    this.LuuButton.Enabled = false;
                    this.HuyButton.Enabled = false;
                    this.DaiLyComboBox.Enabled = true;
                    return true;
                }
                else
                {
                    this.MessageFailure = "Thay doi khong thanh cong";
                    return false;
                }
            }
            else
            {
                this.MessageFailure = "Chua thuc hien thay doi";
                return false;
            }


        }
        public void HuyThayDoi()
        {
            this.tempthemChiTiet_XuatHangs.Clear();
            this.tempxoaChiTiet_XuatHangs.Clear();
            LoadChiTietPhieuXuatHang();
            this.LuuButton.Enabled = false;
            this.HuyButton.Enabled = false;
            this.DaiLyComboBox.Enabled = true;
        }

        #endregion

        #region private methods
        private void LoadNoHienTai()
        {
            var pxhs = from pxh in db.tb_PhieuXuatHang.ToList()
                       where pxh.Ma_DaiLy == int.Parse(this.DaiLyComboBox.SelectedValue.ToString())
                       select pxh;
            var ptts = from ptt in db.tb_PhieuThuTien.ToList()
                       where ptt.Ma_DaiLy == int.Parse(this.DaiLyComboBox.SelectedValue.ToString())
                       select ptt;

            this.NoHienTaiTextBox.Text = (pxhs.Sum(p => p.TongTien) + ptts.Sum(p => p.So_Tien_Thu) + this.tempthemChiTiet_XuatHangs.Sum(p => p.Thanh_Tien)).ToString();
        }

        private void LoadChiTietPhieuXuatHang()
        {
            var result = from ctpx in db.tb_ChiTiet_XuatHang.ToList()
                         where ctpx.Ma_PhieuXuat == this.currentIDPhieuXuatHang
                         select ctpx;
            result.ToList().AddRange(this.tempthemChiTiet_XuatHangs);
            foreach (var item in this.tempxoaChiTiet_XuatHangs)
            {
                result.ToList().Remove(item);
            }
            this.ChiTietPhieuXuatHangData.DataSource = null;
            this.ChiTietPhieuXuatHangData.DataSource = result;

        }
        #endregion


    }
}
