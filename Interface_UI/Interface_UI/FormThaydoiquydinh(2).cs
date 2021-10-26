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
    public partial class FormThaydoiquydinh_2_ : Form
    {
        QuanController QuanController;
        public FormThaydoiquydinh_2_()
        {
            InitializeComponent();
            this.QuanController = new QuanController()
            {
                MaQuanTextBox = this.maquan_textbox,
                TenQuanTextBox = this.tenquan_textbox,
                LuongDaiLyToiDaTextBox = this.luongdailytoida_textbox,
                CapNhatButotn = this.capnhat_button,
                QuanData = this.quans_datagridview

            };
        }

        private void FormThaydoiquydinh_2__Load(object sender, EventArgs e)
        {
            this.QuanController.LoadLanDau();
        }
    }
}
