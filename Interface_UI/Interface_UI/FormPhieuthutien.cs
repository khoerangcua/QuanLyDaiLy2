using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.BUS.Controllers;

namespace Interface_UI
{
    public partial class FormPhieuthutien : Form
    {
        PhieuThuTienController PhieuThuTienController;
        public FormPhieuthutien()
        {
            InitializeComponent();
            this.PhieuThuTienController = new PhieuThuTienController()
            {
                MaPhieuThuTextBox = this.maphieuthutien_textbox,
                DaiLyComboBox = this.tendaily_combobox,
                TienThuTextBox = this.sotienthu_textbox,
                NgayLapPhieuTextBox = this.ngaylapphieu_textbox,
                GhiChuTextBox = this.ghichu_textbox,
                ThemButton = this.them_button,
                XoaButton = this.xoa_button,
                SuaButton = this.capnhat_button,
                ResetButton = this.lammoi_button,
                ThangComboBox_TimKiem = this.thang_combobox,
                NamComboBox_TimKiem = this.nam_combobox,
                TenDaiLyTextBox_TimKiem = this.tendailytimkiem_textbox,
                TimKiemButton = this.timkiem_button,
                PhieuThuTienData = this.phieuthutiens_datagridview
            };
        }

        private void FormPhieuthutien_Load(object sender, EventArgs e)
        {
            this.PhieuThuTienController.LoadLanDau();
        }
    }
}
