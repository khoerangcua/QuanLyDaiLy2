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
    public partial class FormPhieuxuathang_Them_ : Form
    {
        // Controller
        ThemPhieuXuatHangController ThemPhieuXuatHangController;
        public FormPhieuxuathang_Them_()
        {
            InitializeComponent();
            this.ThemPhieuXuatHangController = new ThemPhieuXuatHangController()
            {
                DaiLyComboBox = this.daily_combobox,
                HangHoaComboBox = this.hanghoa_combobox,
                SoLuongTextBox = this.soluong_textbox,
                NgayLapTextBox = this.ngaylapphieu_textbox,
                TienNoHienTai = this.tiennohientai_textbox,
                ThemButton = this.them_button,
                XoaButton = this.xoa_button,
                LuuButton = this.luu_button,
                HuyButton = this.huy_button,
                ChiTietPhieuXuatDataGridView = this.phieuxuathangs_datagridview
            };
        }

        private void FormPhieuxuathang_Them__Load(object sender, EventArgs e)
        {
            this.ThemPhieuXuatHangController.ChayLanDau();
        }
    }
}
