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
    public partial class FormPhieuxuathang_sua_ : Form
    {
        SuaPhieuXuatHangController SuaPhieuXuatHangController;
        public FormPhieuxuathang_sua_()
        {
            InitializeComponent();
            this.SuaPhieuXuatHangController = new SuaPhieuXuatHangController()
            {
                DaiLyComboBox = this.tendaily_combobox,
                ThangComboBox= this.thang_combobox,
                NamComboBox = this.nam_combobox,
                TimButton = this.timkiem_button,
                HangHoaComboBox = this.hanghoa_combobox,
                SoLuongTextBox = this.soluong_textbox,
                NoHienTaiTextBox = this.nohientai_textbox,
                ThemButton = this.them_button,
                XoaButton = this.xoa_button,
                LuuButton = this.luu_button,
                HuyButton = this.huy_button,
                PhieuXuatHangData = this.phieuxuathangs_datagridview,
                ChiTietPhieuXuatHangData = this.chitietphieuxuathang_datagridview
            };
        }

        private void FormPhieuxuathang_sua__Load(object sender, EventArgs e)
        {
            this.SuaPhieuXuatHangController.LoadLanDau();
        }

        

        private void chitietphieuxuathang_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
