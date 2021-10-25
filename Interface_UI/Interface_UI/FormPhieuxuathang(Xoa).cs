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
    public partial class FormPhieuxuathang_Xoa_ : Form
    {
        XoaPhieuXuatHangController XoaPhieuXuatHangController;
        public FormPhieuxuathang_Xoa_()
        {
            InitializeComponent();
            XoaPhieuXuatHangController = new XoaPhieuXuatHangController() 
            {
                DaiLyComboBox = this.tendaily_combobox,
                ThangComboBox = this.thang_combobox,
                NamComboBox = this.nam_combobox,
                Data = this.phieuxuathangs_datagridview,
                TimKiemButton = this.tim_button,
                XoaButton = this.xoa_button
            };
        }

        private void FormPhieuxuathang_Xoa__Load(object sender, EventArgs e)
        {
            this.XoaPhieuXuatHangController.ChayLanDau();
        }
    }
}
