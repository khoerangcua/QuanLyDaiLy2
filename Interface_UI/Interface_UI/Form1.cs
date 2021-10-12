﻿using System;
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
        private void customizeDesing()
        {
            panelSubmenu.Visible = false;
            panelManage.Visible = false;
            panelReport.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelSubmenu.Visible == true)
                panelSubmenu.Visible = false;
            if (panelManage.Visible == true)
                panelManage.Visible = false;
            if (panelReport.Visible == true)
                panelReport.Visible = false;
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenu);
        }

        private void File_Click(object sender, EventArgs e)
        {
            hideSubmenu();
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
      
        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Phieuxuathang_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }       

        private void Phieuthutien_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Phieuxuathang_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            showSubmenu(panelReport);
        }

        private void File_Click_3(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Loggin_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Loggout_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
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
            hideSubmenu();
        }

        private void Baocaocongno_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuSlidebar_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if(this.Menubar.Width>200)
            {
                Menubar.Width = 100;
                .Visible = false;
            }    
        }
    }
}
