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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            customizeDesing();

        }
        

        private void LabelEffect_Click(object sender,EventArgs e)
        {
              
        }
        private void customizeDesing()
        {
            panelSubmenu.Visible = false;
            panelManage.Visible = false;
            panelReport.Visible = false;
            panelQuydinh.Visible = false;
            
        }
        private void hideSubmenu()
        {
            if (panelSubmenu.Visible == true)
                panelSubmenu.Visible = false;
            if (panelManage.Visible == true)
                panelManage.Visible = false;
            if (panelReport.Visible == true)
                panelReport.Visible = false;
            if (panelQuydinh.Visible == true)
                panelQuydinh.Visible = false;
        }
       
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }       

        
        private void Homepage_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenu);
        }

       

        private void PanelHomepage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelManage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }
      
       

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      

        private void Report_Click(object sender, EventArgs e)
        {
            showSubmenu(panelReport);
        }

        private void File_Click_3(object sender, EventArgs e)
        {
            openChildForm(new FormHoso());
            hideSubmenu();
            
        }

        private void Loggin_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChangepass_Homepage());
            hideSubmenu();
        }

        private void Loggout_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
            Application.Exit();
        }

        private void Manage_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelManage);
        }

        private void panelReport_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Baocaodoanhthu_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormBaocaodoanhso());
            hideSubmenu();
        }

        private void Baocaocongno_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormBaocaocongno());
            hideSubmenu();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuSlidebar_Click(object sender, EventArgs e)
        {
            
        }

       
        

        private void Regulate_Click(object sender, EventArgs e)
        {
            showSubmenu(panelQuydinh);
        }

        private void DetailExport_Click(object sender, EventArgs e)
        {

        }

        private void panelPhieuthu_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Phieuthutien_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPhieuthutien());
            hideSubmenu();
        }

        private void Phieuxuathang_Click_3(object sender, EventArgs e)
        {
            openChildForm(new FormPhieuxuathang());
            hideSubmenu();  
        }

        private void panelDetail_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Loaidaily_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThaydoiquydinh_1_());
            hideSubmenu();
        }

        private void Sodailytrongquan_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThaydoiquydinh_2_());
            hideSubmenu();
        }

        private void Hanghoa_Click(object sender, EventArgs e)
        {
            openChildForm(new FormThaydoiquydinh_3_());
            hideSubmenu();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSearch());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
