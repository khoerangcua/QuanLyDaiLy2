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

        #region temp
        private int currentPhieuXuatHang { get; set; }
        #endregion

        #region controls
        public ComboBox DaiLyComboBox { get; set; }
        public ComboBox ThangComboBox { get; set; }
        public ComboBox NamComboBox { get; set; }
        public TextBox TienThuTextBox { get; set; }
        public TextBox NgayLapPhieuTextBox { get; set; }
        public TextBox TenDaiLyTextBox { get; set; }
        public Button ThemButton { get; set; }
        public Button XoaButton { get; set; }
        public Button InButton { get; set; }
        public DataGridView PhieuXuatHangData { get; set; }
        #endregion
        #region constructor
        public PhieuThuTienController()
        {

            this.MessageFaiure = "";
            this.db = new QuanLyDaiLyEntities();
            //
            //set state
            //
            XoaButton.Enabled = false;
            InButton.Enabled = false;
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
            if (db.tb_DaiLy.Any())
            {
                var result = from dl in db.tb_DaiLy.ToList()
                             select new { ID = dl.Ma_DaiLy, Name = dl.Ten_DaiLy };
                this.DaiLyComboBox.DataSource = result;
                this.DaiLyComboBox.ValueMember = "ID";
                this.DaiLyComboBox.DisplayMember = "Name"; 
            }
            //
            // load thang combobox
            //
            if (db.tb_PhieuThuTien.Any())
            {
                var result = from ptt in db.tb_PhieuThuTien.ToList()
                             select new { ID = ptt.Ngay_Lap.Month, Name = ptt.Ngay_Lap.Month };
                this.ThangComboBox.DataSource = result;
                this.ThangComboBox.ValueMember = "ID";
                this.ThangComboBox.DisplayMember= "Name"; 
            }
            // 
            //load nam combobox
            //
            if (db.tb_PhieuThuTien.Any())
            {
                var result = from ptt in db.tb_PhieuThuTien.ToList()
                             select new { ID = ptt.Ngay_Lap.Year, Name = ptt.Ngay_Lap.Year };
                this.ThangComboBox.DataSource = result;
                this.ThangComboBox.ValueMember = "ID";
                this.ThangComboBox.DisplayMember = "Name";
            }
        }

        public bool ThemPhieuThuTien()
        {
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
            double tienthutoida = 0;
            DateTime ngaylap = DateTime.Now;
            if (db.tb_PhieuXuatHang.Any())
            {
                double tongtienno = db.tb_PhieuXuatHang.ToList().Where(p => p.Ma_DaiLy == iddaily).Sum(p => p.TongTien);
                double tongtiendathu = db.tb_PhieuThuTien.ToList().Where(p => p.Ma_DaiLy == iddaily).Sum(p => p.So_Tien_Thu);
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
            });
            if (db.SaveChanges()==0)
            {
                this.MessageFaiure = "luu khong thanh cong";
                return false;
            }

            //
            // reset form
            //
            this.TienThuTextBox.Text = "";
            return true;
        }

        public bool TimKiemPhieuThuTien()
        {
            this.MessageFaiure = "";

            string key_tendaily = this.TenDaiLyTextBox.Text;
            int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
            int nam = int.Parse(this.NamComboBox.SelectedValue.ToString());

            if (!db.tb_PhieuThuTien.Any())
            {
                this.MessageFaiure = "chua co phieu thu tien nao trong csdl";
                return false;
            }

            var result = from ptt in db.tb_PhieuThuTien.ToList()
                         where ptt.tb_DaiLy.Ten_DaiLy.Contains(key_tendaily) && ptt.Ngay_Lap.Month == thang && ptt.Ngay_Lap.Year == nam
                         select ptt;
            if (result.Count()==0)
            {
                this.MessageFaiure = "khong tim thay dai ly phu hop";
                return false;
            }

            this.PhieuXuatHangData.DataSource = null;
            this.PhieuXuatHangData.DataSource = result;
            this.XoaButton.Enabled = true;
            this.InButton.Enabled = true;
            return true;

        }

        public bool XoaPhieuThuTien()
        {
            var phieuthutien = (from ptt in db.tb_PhieuThuTien.ToList()
                               where ptt.Ma_PhieuThu == this.currentPhieuXuatHang
                               select ptt).Single();
            db.tb_PhieuThuTien.Remove(phieuthutien);
            if (db.SaveChanges()>0)
            {
                //
                //reset form neu thay doi thanh cong
                //
                string key_tendaily = this.TenDaiLyTextBox.Text;
                int thang = int.Parse(this.ThangComboBox.SelectedValue.ToString());
                int nam = int.Parse(this.NamComboBox.SelectedValue.ToString());

                var result = from ptt in db.tb_PhieuThuTien.ToList()
                             where ptt.tb_DaiLy.Ten_DaiLy.Contains(key_tendaily) && ptt.Ngay_Lap.Month == thang && ptt.Ngay_Lap.Year == nam
                             select ptt;
                if (result.Count() == 0)
                {
                    this.MessageFaiure = "da xoa phieu xuat hang cua dai ly";
                    this.XoaButton.Enabled = false;
                    return false;
                }

                this.PhieuXuatHangData.DataSource = null;
                this.PhieuXuatHangData.DataSource = result;
                this.XoaButton.Enabled = true;
                this.InButton.Enabled = true;
                return true;
            }
            else
            {
                this.MessageFaiure = "xoa khong thanh cong";
                return false;

            }

        }
        #endregion

        #region private methods
        private void PhieuXuatHangData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.currentPhieuXuatHang = int.Parse(this.PhieuXuatHangData.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        #endregion


    }
}
