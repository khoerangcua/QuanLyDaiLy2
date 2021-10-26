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
    public partial class FormThaydoiquydinh_3_ : Form
    {
        HangHoaController HangHoaController;
        public FormThaydoiquydinh_3_()
        {
            InitializeComponent();
            this.HangHoaController = new HangHoaController()
            {
                MaHangHoaTextBox = this.mahanghoa_textbox,
                TenHangHoaTextBox = this.tenhanghoa_textbox,
                DonGiaTextBox = this.dongia_textbox,
                DonViTinhTextBox = this.donvitinh_textbox,
                ThemButton = this.them_button,
                CapNhatButton = this.capnhat_button,
                XoaButton = this.xoa_button,
                HangHoaData = this.hanghoas_datagridview
            };
        }

        private void FormThaydoiquydinh_3__Load(object sender, EventArgs e)
        {
            this.HangHoaController.LoadLanDau();
        }
    }
}
