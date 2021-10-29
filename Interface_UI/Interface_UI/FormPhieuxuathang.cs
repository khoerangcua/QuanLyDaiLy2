using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_UI
{
    public partial class FormPhieuxuathang : Form
    {
        public FormPhieuxuathang()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPhieuxuathang_Them_());
        }

        private void FormPhieuxuathang_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildExport.Controls.Add(childForm);
            panelChildExport.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPhieuxuathang_sua_());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPhieuxuathang_Xoa_());
        }

        private void panelPhieuxuathang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildExport_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
