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
    public partial class FormBaocaodoanhso : Form
    {
        BaoCaoDoanhSoController BaoCaoDoanhSoController;
        public FormBaocaodoanhso()
        {
            InitializeComponent();
            this.BaoCaoDoanhSoController = new BaoCaoDoanhSoController()
            {
                ThangComboBox = this.thang_combobox,
                NamConboBox = this.nam_combobox,
                TimButton = this.timkiem_button,
                BaoCaoDoanhSoData = this.baocaodoanhsos_datagridview,
                InButton = this.in_button
            };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormBaocaodoanhso_Load(object sender, EventArgs e)
        {
            this.BaoCaoDoanhSoController.LoadLanDau();
        }
    }
}
