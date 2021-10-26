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
    public partial class FormBaocaocongno : Form
    {
        BaoCaoCongNoController BaoCaoCongNoController;
        public FormBaocaocongno()
        {
            InitializeComponent();
            this.BaoCaoCongNoController = new BaoCaoCongNoController()
            {
                ThangComboBox = this.thang_combobox,
                NamConboBox = this.nam_combobox,
                TimButton = this.timkiem_button,
                InButton = this.in_button,
                BaoCaoDoanhSoData = this.baocaocongnos_datagridview
            };
        }

        private void FormBaocaocongno_Load(object sender, EventArgs e)
        {
            this.BaoCaoCongNoController.LoadLanDau();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
