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
    public partial class FormSearch : Form
    {
        TraCuuDaiLyController TraCuuDaiLyController;
        public FormSearch()
        {
            InitializeComponent();
            this.TraCuuDaiLyController = new TraCuuDaiLyController()
            {
                DaiLyTextBox = this.tendaily_textbox,
                QuanComboBox = this.quan_combobox,
                LoaiDaiLyComboBox = this.loai_combobox,
                TimButton = this.timkiem_button,
                DaiLyData = this.dalys_datagridview
            };
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            this.TraCuuDaiLyController.LoadLanDau();
        }
    }
}
