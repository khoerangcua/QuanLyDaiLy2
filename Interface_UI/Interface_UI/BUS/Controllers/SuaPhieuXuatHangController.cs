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
            this.tempthemChiTiet_XuatHangs = new List<tb_ChiTiet_XuatHang>();
            this.tempxoaChiTiet_XuatHangs = new List<tb_ChiTiet_XuatHang>();
            //
            //subcribe events
            //
            this.PhieuXuatHangData.RowEnter += PhieuXuatHangData_RowEnter;
            this.ChiTietPhieuXuatHangData.RowEnter += ChiTietPhieuXuatHangData_RowEnter;
            this.ThemButton.Click += ThemButton_Click;
            this.XoaButton.Click += XoaButton_Click;
            this.LuuButton.Click += LuuButton_Click;
            this.HuyButton.Click += HuyButton_Click;
            this.TimButton.Click += TimButton_Click;
            //
            // set state of controls
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

        #region methods
        public void LoadLanDau()
        {
            //
            //Load dai ly ComboBox
            //

            var dailys = from dl in db.tb_DaiLy
                         select new { ID = dl.Ma_DaiLy, Name = dl.Ten_DaiLy };
            this.DaiLyComboBox.DataSource = dailys.ToList();
            this.DaiLyComboBox.ValueMember = "ID";
            this.DaiLyComboBox.DisplayMember = "Name";

            //
            //Load Thang ComboBox
            //

            var thangs = (from px in db.tb_PhieuXuatHang
                          select new { ID = px.Ngay_Lap.Month, Name = px.Ngay_Lap.Month }).Distinct();
            this.ThangComboBox.DataSource = thangs.ToList();
            this.ThangComboBox.DisplayMember = "Name";
            this.ThangComboBox.ValueMember = "ID";

            //
            //Load Nam ComboBox
            //

            var nams = (from px in db.tb_PhieuXuatHang
                        select new { ID = px.Ngay_Lap.Year, Name = px.Ngay_Lap.Year }).Distinct();
            this.NamComboBox.DataSource = nams.ToList();
            this.NamComboBox.DisplayMember = "Name";
            this.NamComboBox.ValueMember = "ID";

            //
            //Load Hang Hoa ComboBox
            //

            var hanghoas = from hh in db.tb_HangHoa
                           select new { ID = hh.Ma_HangHoa, Name = hh.Ten_HangHoa };
            this.HangHoaComboBox.DataSource = hanghoas.ToList();
            this.HangHoaComboBox.ValueMember = "ID";
            this.HangHoaComboBox.DisplayMember = "Name";





        }

        private void TimKiem()
        {
            //
            //lay thong tin ma dai ly, thang ,nam
            //
            int madaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamComboBox.SelectedValue.ToString());

            var phieuxuathangs = from px in db.tb_PhieuXuatHang
                                 where px.Ma_DaiLy == madaily && px.Ngay_Lap.Month == thang && px.Ngay_Lap.Year == nam
                                 select px;

            this.PhieuXuatHangData.DataSource = null;
            this.PhieuXuatHangData.DataSource = phieuxuathangs.ToList();
            this.PhieuXuatHangData.Enabled = true;
            
            LoadNoHienTai();
        }

        private bool ThemChiTietPhieuXuat()
        {
            //
            //Lay thong tin chi tiet phieu xuat hang
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
                                      where dl.Ma_DaiLy == int.Parse(this.DaiLyComboBox.SelectedValue.ToString())
                                      select dl.tb_LoaiDaiLy.TienNo_ToiDa).Single();

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
                    LoadChiTietPhieuXuatHang();
                    LoadNoHienTai();
                    return true;
                }
            }

        }

        private bool XoaChiTietPhieuXuat()
        {
            this.MessageFailure = "";

            //
            // lay thong tin chi tiet phieu xuat hang
            //

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

        private bool LuuThayDoi()
        {
            //
            //reset message failure
            //
            this.MessageFailure = "";
            //
            //thuc thi luu thay doi
            //
            if (this.tempthemChiTiet_XuatHangs.Count() + this.tempxoaChiTiet_XuatHangs.Count() > 0)
            {
                db.tb_ChiTiet_XuatHang.AddRange(this.tempthemChiTiet_XuatHangs);
                db.tb_ChiTiet_XuatHang.RemoveRange(this.tempxoaChiTiet_XuatHangs);
                if (db.SaveChanges() > 0)
                {

                    this.tempthemChiTiet_XuatHangs.Clear();
                    this.tempxoaChiTiet_XuatHangs.Clear();
                    LoadNoHienTai();
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

        private void HuyThayDoi()
        {
            this.tempthemChiTiet_XuatHangs.Clear();
            this.tempxoaChiTiet_XuatHangs.Clear();
            LoadNoHienTai();
            LoadChiTietPhieuXuatHang();
            this.LuuButton.Enabled = false;
            this.HuyButton.Enabled = false;
            this.DaiLyComboBox.Enabled = true;
        }

        private void LoadNoHienTai()
        {
            var pxhs = from pxh in db.tb_PhieuXuatHang.ToList()
                       where pxh.Ma_DaiLy == int.Parse(this.DaiLyComboBox.SelectedValue.ToString())
                       select pxh;
            var ptts = from ptt in db.tb_PhieuThuTien.ToList()
                       where ptt.Ma_DaiLy == int.Parse(this.DaiLyComboBox.SelectedValue.ToString())
                       select ptt;
            this.NoHienTaiTextBox.Text = (pxhs.Sum(p => p.TongTien) - ptts.Sum(p => p.So_Tien_Thu) + this.tempthemChiTiet_XuatHangs.Sum(p => p.Thanh_Tien) - this.tempxoaChiTiet_XuatHangs.Sum(p => p.Thanh_Tien)).ToString();
        }

        private void LoadChiTietPhieuXuatHang()
        {
            var chitietphieuxuathangs = from ctpx in db.tb_ChiTiet_XuatHang
                                        where ctpx.Ma_PhieuXuat == this.currentIDPhieuXuatHang
                                        select ctpx;
            chitietphieuxuathangs.ToList().AddRange(this.tempthemChiTiet_XuatHangs);
            foreach (var item in this.tempxoaChiTiet_XuatHangs)
            {
                chitietphieuxuathangs.ToList().Remove(item);
            }
            this.ChiTietPhieuXuatHangData.DataSource = null;
            this.ChiTietPhieuXuatHangData.DataSource = chitietphieuxuathangs;

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
            this.XoaButton.Enabled = true;
            this.SoLuongTextBox.Enabled = true;
            this.HangHoaComboBox.Enabled = true;
        }
        private void HuyButton_Click(object sender, EventArgs e)
        {
            this.HuyThayDoi();
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            this.LuuThayDoi();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            this.XoaChiTietPhieuXuat();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            this.ThemChiTietPhieuXuat();
        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            this.TimKiem();
        }
        #endregion


    }
}
