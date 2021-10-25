using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_UI.DAO;
using System.Windows.Forms;

namespace Interface_UI.BUS.Controllers
{
    public class PhieuThuTienController
    {
        #region fields
        QuanLyDaiLyEntities db;
        public string MessageFaiure { get; set; }
        #endregion

        #region controls
        public ComboBox DaiLyComboBox { get; set; }
        public ComboBox ThangComboBox_TimKiem { get; set; }
        public ComboBox NamComboBox_TimKiem { get; set; }
        public TextBox TienThuTextBox { get; set; }
        public TextBox NgayLapPhieuTextBox { get; set; }
        public TextBox TenDaiLyTextBox_TimKiem { get; set; }
        public TextBox MaPhieuThuTextBox { get; set; }
        public TextBox GhiChuTextBox { get; set; }
        public Button ThemButton { get; set; }
        public Button SuaButton { get; set; }
        public Button XoaButton { get; set; }
        public Button ResetButton { get; set; }
        public Button TimKiemButton { get; set; }
        public DataGridView PhieuXuatHangData { get; set; }
        #endregion

        #region constructor
        public PhieuThuTienController()
        {

            this.MessageFaiure = "";
            this.db = new QuanLyDaiLyEntities();
            //
            //subcribe events
            //
            this.ThemButton.Click += ThemButton_Click;
            this.SuaButton.Click += SuaButton_Click;
            this.XoaButton.Click += XoaButton_Click;
            this.ResetButton.Click += ResetButton_Click;
            this.TimKiemButton.Click += TimKiemButton_Click;
            //
            //set state
            //
            MaPhieuThuTextBox.Enabled = false;
            XoaButton.Enabled = false;
            SuaButton.Enabled = false;
            NgayLapPhieuTextBox.Enabled = false;
            PhieuXuatHangData.Enabled = false;
            this.PhieuXuatHangData.RowEnter += PhieuXuatHangData_RowEnter;

        }

       
        #endregion

        #region public methods
        public void LoadLanDau()
        {
            //
            //load dai ly combobox
            //            
            var dailys = from dl in db.tb_DaiLy
                         select new { ID = dl.Ma_DaiLy, Name = dl.Ten_DaiLy };
            this.DaiLyComboBox.DataSource = dailys.ToList();
            this.DaiLyComboBox.ValueMember = "ID";
            this.DaiLyComboBox.DisplayMember = "Name";
            //
            // load thang combobox
            //

            var thangs = from ptt in db.tb_PhieuThuTien
                         select new { ID = ptt.Ngay_Lap.Month, Name = ptt.Ngay_Lap.Month };
            this.ThangComboBox_TimKiem.DataSource = thangs.ToList();
            this.ThangComboBox_TimKiem.ValueMember = "ID";
            this.ThangComboBox_TimKiem.DisplayMember = "Name";

            // 
            //load nam combobox
            //
            
                var nams = from ptt in db.tb_PhieuThuTien
                           select new { ID = ptt.Ngay_Lap.Year, Name = ptt.Ngay_Lap.Year };
                this.NamComboBox_TimKiem.DataSource = nams.ToList();
                this.NamComboBox_TimKiem.ValueMember = "ID";
                this.NamComboBox_TimKiem.DisplayMember = "Name";

            //
            //load ngay lap phieu
            //
            this.NgayLapPhieuTextBox.Text = DateTime.Now.ToString();
        }

        private bool ThemPhieuThuTien()
        {
            //
            //reset message failure
            //
            this.MessageFaiure = "";

            //
            // lay thong tin phieu thu tien
            //

            int idphieuthutien = 1;
            if (db.tb_PhieuThuTien.Any())
            {
                idphieuthutien = db.tb_PhieuThuTien.Max(p => p.Ma_PhieuThu) + 1;
            }
            int iddaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            double tienthu = this.TienThuTextBox.Text.All(char.IsDigit) || !string.IsNullOrEmpty(this.TienThuTextBox.Text)? double.Parse(this.TienThuTextBox.Text) : -1;
            string ghichu = this.GhiChuTextBox.Text;
            double tienthutoida = 0;
            DateTime ngaylap = DateTime.Now;
            if (db.tb_PhieuXuatHang.Any())
            {
                double tongtienno = db.tb_PhieuXuatHang.Where(p => p.Ma_DaiLy == iddaily).Sum(p => p.TongTien);
                double tongtiendathu = db.tb_PhieuThuTien.Where(p => p.Ma_DaiLy == iddaily).Sum(p => p.So_Tien_Thu);
                tienthutoida = tongtienno - tongtiendathu;
            }
            else
            {
                this.MessageFaiure = "khong co no";
                return false;
            }
            

            //
            //kiem tra input
            //
            if (tienthu == -1)
            {
                this.MessageFaiure = "thien thu khong hop le";
                return false;
            }
            if (tienthu > tienthutoida)
            {
                this.MessageFaiure = "thien thu vuot qua tien no";
                return false;
            }

            db.tb_PhieuThuTien.Add(new tb_PhieuThuTien
            {
                Ma_PhieuThu = idphieuthutien,
                Ma_DaiLy = iddaily,
                So_Tien_Thu = tienthu,
                Ngay_Lap = ngaylap,
                GhiChu = ghichu
            });
            if (db.SaveChanges()==0)
            {
                this.MessageFaiure = "luu khong thanh cong";
                return false;
            }
            //
            // reset form
            //
            var phieuthutiens = from ptt in db.tb_PhieuThuTien
                                where ptt.Ma_DaiLy == iddaily && ptt.Ngay_Lap.Month == ngaylap.Month && ptt.Ngay_Lap.Year == ptt.Ngay_Lap.Year
                                select ptt;
            this.PhieuXuatHangData.DataSource = null;
            this.PhieuXuatHangData.DataSource = phieuthutiens.ToList();
            return true;
        }

        private void ResetForm()
        {
            this.MaPhieuThuTextBox.Text = "";
            this.TienThuTextBox.Text = "";
            this.NgayLapPhieuTextBox.Text = DateTime.Now.ToString();
            this.GhiChuTextBox.Text = "";
            this.TenDaiLyTextBox_TimKiem.Text = "";
            this.PhieuXuatHangData.DataSource = null;
            this.SuaButton.Enabled = false;
            this.XoaButton.Enabled = false;
        }

        private bool TimKiemPhieuThuTien()
        {
            //
            //reset messagefailur
            //
            this.MessageFaiure = "";
            //
            //lay thong tin (ten, thang, nam)
            //
            string key_tendaily = this.TenDaiLyTextBox_TimKiem.Text;
            int thang = int.Parse(this.ThangComboBox_TimKiem.SelectedValue.ToString());
            int nam = int.Parse(this.NamComboBox_TimKiem.SelectedValue.ToString());

            if (!db.tb_PhieuThuTien.Any())
            {
                this.MessageFaiure = "chua co phieu thu tien nao trong csdl";
                return false;
            }

            var phieuthutiens = from ptt in db.tb_PhieuThuTien.ToList()
                         where ptt.tb_DaiLy.Ten_DaiLy.Contains(key_tendaily) && ptt.Ngay_Lap.Month == thang && ptt.Ngay_Lap.Year == nam
                         select ptt;
            if (phieuthutiens.Count()==0)
            {
                this.MessageFaiure = "khong tim thay dai ly phu hop";
                return false;
            }

            this.PhieuXuatHangData.DataSource = null;
            this.PhieuXuatHangData.DataSource = phieuthutiens;
            this.XoaButton.Enabled = true;
            this.SuaButton.Enabled = true;
            return true;

        }

        private bool XoaPhieuThuTien()
        {
            //
            //reset messagefailure
            //
            this.MessageFaiure = "";
            //
            //lay thong tin phieu thu tien
            //
            var phieuthutien = (from ptt in db.tb_PhieuThuTien
                               where ptt.Ma_PhieuThu == int.Parse(this.MaPhieuThuTextBox.Text)
                               select ptt).Single();
            db.tb_PhieuThuTien.Remove(phieuthutien);
            if (db.SaveChanges()>0)
            {
                //
                //reset form neu thay doi thanh cong
                //
                string key_tendaily = this.TenDaiLyTextBox_TimKiem.Text;
                int thang = int.Parse(this.ThangComboBox_TimKiem.SelectedValue.ToString());
                int nam = int.Parse(this.NamComboBox_TimKiem.SelectedValue.ToString());

                var phieuthutiens = from ptt in db.tb_PhieuThuTien.ToList()
                             where ptt.tb_DaiLy.Ten_DaiLy.Contains(key_tendaily) && ptt.Ngay_Lap.Month == thang && ptt.Ngay_Lap.Year == nam
                             select ptt;
                if (phieuthutiens.Count() == 0)
                {
                    this.MessageFaiure = "da xoa phieu xuat hang cua dai ly";
                    this.XoaButton.Enabled = false;
                    this.SuaButton.Enabled = false;
                    return false;
                }

                this.PhieuXuatHangData.DataSource = null;
                this.PhieuXuatHangData.DataSource = phieuthutiens;
                this.XoaButton.Enabled = true;
                this.SuaButton.Enabled = true;
                return true;
            }
            else
            {
                this.MessageFaiure = "xoa khong thanh cong";
                return false;

            }

        }

        private bool SuaPhieuThuTien()
        {
            //
            // reset messagefailure
            //
            this.MessageFaiure = "";
            //
            // lay ma phieu thu tien
            //
            int maphieuthutien = int.Parse(this.MaPhieuThuTextBox.Text);
            //
            //tim kiem phieu thu tien trong csdl
            //
            tb_PhieuThuTien phieuthutien = (from ptt in db.tb_PhieuThuTien
                                            where ptt.Ma_PhieuThu == maphieuthutien
                                            select ptt).Single();
            //
            //lay thong tin phieu thu tien da duoc cap nhat
            //
            int madaily = int.Parse(this.DaiLyComboBox.SelectedValue.ToString());
            double sotienthumoi = this.TienThuTextBox.Text.All(char.IsDigit) || !string.IsNullOrEmpty(this.TienThuTextBox.Text)? double.Parse(this.TienThuTextBox.Text) : -1;
            if (sotienthumoi == -1)
            {
                this.MessageFaiure = "Tien thu khong hop le";
                return false;
            }
            string ghichu = this.GhiChuTextBox.Text;
            //
            //kiem tra tien thu toi da
            //

            var tongno = db.tb_PhieuXuatHang.Where(pxh => pxh.Ma_DaiLy == madaily).Sum(pxh => pxh.TongTien);
            var tienthu_phieuthutien_hientai = db.tb_PhieuThuTien.Where(ptt => ptt.Ma_PhieuThu == maphieuthutien).Select(ptt => ptt.So_Tien_Thu).Single();
            var tongtiendathu = db.tb_PhieuThuTien.Where(ptt => ptt.Ma_DaiLy == madaily).Sum(ptt => ptt.So_Tien_Thu);
            bool kiemtra = tongtiendathu - tienthu_phieuthutien_hientai + sotienthumoi > tongno;
            if (kiemtra)
            {
                this.MessageFaiure = "Tien thu vuot qua tien no";
                return false;
            }
            else
            {
                TimKiemPhieuThuTien();
                return true;
            }
            


        }




        #endregion

        #region events
        private void PhieuXuatHangData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.MaPhieuThuTextBox.Text = this.PhieuXuatHangData.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DaiLyComboBox.SelectedValue = this.PhieuXuatHangData.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.NgayLapPhieuTextBox.Text = this.PhieuXuatHangData.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.TienThuTextBox.Text = this.PhieuXuatHangData.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.GhiChuTextBox.Text = this.PhieuXuatHangData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            this.TimKiemPhieuThuTien();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            this.XoaPhieuThuTien();
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            this.SuaPhieuThuTien();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            this.ThemPhieuThuTien();
        }


        #endregion
    }
}
