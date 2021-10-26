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
    public partial class FormThaydoiquydinh_1_ : Form
    {
        LoaiDaiLyController LoaiDaiLyController;
        public FormThaydoiquydinh_1_()
        {
            InitializeComponent();
            this.LoaiDaiLyController = new LoaiDaiLyController()
            {
                MaLoaiDaiLyTextBox = this.maloaidaily_textbox,
                TenLoaiDaiLyTextBox = this.tenloaidaily_textbox,
                TienNoToiDaTextBox = this.tienotoida_textbox,
                ThemButton = this.them_button,
                CapNhatButton = this.capnhat_button,
                XoaButton = this.xoa_button,
                LoaiDaiLyData = this.loaidailys_datagridview,
            };
        }

        private void IbMadaily_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormThaydoiquydinh_1__Load(object sender, EventArgs e)
        {
            this.LoaiDaiLyController.LoadLanDau();
        }
    }
}
