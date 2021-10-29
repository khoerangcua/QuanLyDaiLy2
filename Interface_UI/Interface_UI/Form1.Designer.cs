
namespace Interface_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menubar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelQuydinh = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.panelManage = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.Hanghoa = new FontAwesome.Sharp.IconButton();
            this.Sodailytrongquan = new FontAwesome.Sharp.IconButton();
            this.Loaidaily = new FontAwesome.Sharp.IconButton();
            this.Regulate = new FontAwesome.Sharp.IconButton();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.Baocaocongno = new FontAwesome.Sharp.IconButton();
            this.Baocaodoanhthu = new FontAwesome.Sharp.IconButton();
            this.Report = new FontAwesome.Sharp.IconButton();
            this.Phieuxuathang = new FontAwesome.Sharp.IconButton();
            this.Phieuthutien = new FontAwesome.Sharp.IconButton();
            this.File = new FontAwesome.Sharp.IconButton();
            this.Manage = new FontAwesome.Sharp.IconButton();
            this.Loggout = new FontAwesome.Sharp.IconButton();
            this.Changepass = new FontAwesome.Sharp.IconButton();
            this.Homepage = new FontAwesome.Sharp.IconButton();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Exit = new FontAwesome.Sharp.IconPictureBox();
            this.Menubar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelQuydinh.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.panelManage.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Menubar
            // 
            this.Menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Menubar.Controls.Add(this.Minimizar);
            this.Menubar.Controls.Add(this.Exit);
            this.Menubar.Controls.Add(this.panel4);
            this.Menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menubar.Location = new System.Drawing.Point(0, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Size = new System.Drawing.Size(909, 47);
            this.Menubar.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(43, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 30);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 575);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.panelQuydinh);
            this.panel2.Controls.Add(this.Regulate);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.panelReport);
            this.panel2.Controls.Add(this.Report);
            this.panel2.Controls.Add(this.panelManage);
            this.panel2.Controls.Add(this.Manage);
            this.panel2.Controls.Add(this.panelSubmenu);
            this.panel2.Controls.Add(this.Homepage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 575);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelQuydinh
            // 
            this.panelQuydinh.Controls.Add(this.Hanghoa);
            this.panelQuydinh.Controls.Add(this.Sodailytrongquan);
            this.panelQuydinh.Controls.Add(this.Loaidaily);
            this.panelQuydinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuydinh.Location = new System.Drawing.Point(0, 503);
            this.panelQuydinh.Name = "panelQuydinh";
            this.panelQuydinh.Size = new System.Drawing.Size(221, 118);
            this.panelQuydinh.TabIndex = 25;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.Baocaocongno);
            this.panelReport.Controls.Add(this.Baocaodoanhthu);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReport.Location = new System.Drawing.Point(0, 339);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(221, 82);
            this.panelReport.TabIndex = 19;
            this.panelReport.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReport_Paint_1);
            // 
            // panelManage
            // 
            this.panelManage.Controls.Add(this.Phieuxuathang);
            this.panelManage.Controls.Add(this.Phieuthutien);
            this.panelManage.Controls.Add(this.File);
            this.panelManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManage.Location = new System.Drawing.Point(0, 163);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(221, 133);
            this.panelManage.TabIndex = 17;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.Controls.Add(this.Loggout);
            this.panelSubmenu.Controls.Add(this.Changepass);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 43);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(221, 79);
            this.panelSubmenu.TabIndex = 11;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackgroundImage = global::Interface_UI.Properties.Resources.background1;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(238, 47);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(671, 575);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // Hanghoa
            // 
            this.Hanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Hanghoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hanghoa.FlatAppearance.BorderSize = 0;
            this.Hanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hanghoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hanghoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hanghoa.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.Hanghoa.IconColor = System.Drawing.Color.Turquoise;
            this.Hanghoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Hanghoa.IconSize = 30;
            this.Hanghoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hanghoa.Location = new System.Drawing.Point(0, 76);
            this.Hanghoa.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Hanghoa.Name = "Hanghoa";
            this.Hanghoa.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Hanghoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Hanghoa.Size = new System.Drawing.Size(221, 38);
            this.Hanghoa.TabIndex = 11;
            this.Hanghoa.Text = "         Hàng hoá";
            this.Hanghoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hanghoa.UseVisualStyleBackColor = false;
            this.Hanghoa.Click += new System.EventHandler(this.Hanghoa_Click);
            // 
            // Sodailytrongquan
            // 
            this.Sodailytrongquan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Sodailytrongquan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sodailytrongquan.FlatAppearance.BorderSize = 0;
            this.Sodailytrongquan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sodailytrongquan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Sodailytrongquan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sodailytrongquan.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.Sodailytrongquan.IconColor = System.Drawing.Color.Turquoise;
            this.Sodailytrongquan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Sodailytrongquan.IconSize = 30;
            this.Sodailytrongquan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sodailytrongquan.Location = new System.Drawing.Point(0, 38);
            this.Sodailytrongquan.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Sodailytrongquan.Name = "Sodailytrongquan";
            this.Sodailytrongquan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Sodailytrongquan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sodailytrongquan.Size = new System.Drawing.Size(221, 38);
            this.Sodailytrongquan.TabIndex = 10;
            this.Sodailytrongquan.Text = "         Số đại lý trong quận";
            this.Sodailytrongquan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sodailytrongquan.UseVisualStyleBackColor = false;
            this.Sodailytrongquan.Click += new System.EventHandler(this.Sodailytrongquan_Click);
            // 
            // Loaidaily
            // 
            this.Loaidaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Loaidaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.Loaidaily.FlatAppearance.BorderSize = 0;
            this.Loaidaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loaidaily.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loaidaily.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Loaidaily.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.Loaidaily.IconColor = System.Drawing.Color.Turquoise;
            this.Loaidaily.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Loaidaily.IconSize = 30;
            this.Loaidaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loaidaily.Location = new System.Drawing.Point(0, 0);
            this.Loaidaily.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Loaidaily.Name = "Loaidaily";
            this.Loaidaily.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Loaidaily.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Loaidaily.Size = new System.Drawing.Size(221, 38);
            this.Loaidaily.TabIndex = 9;
            this.Loaidaily.Text = "         Loại đại lý";
            this.Loaidaily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loaidaily.UseVisualStyleBackColor = false;
            this.Loaidaily.Click += new System.EventHandler(this.Loaidaily_Click);
            // 
            // Regulate
            // 
            this.Regulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Regulate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Regulate.FlatAppearance.BorderSize = 0;
            this.Regulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regulate.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regulate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Regulate.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.Regulate.IconColor = System.Drawing.Color.Turquoise;
            this.Regulate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Regulate.IconSize = 30;
            this.Regulate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Regulate.Location = new System.Drawing.Point(0, 462);
            this.Regulate.Name = "Regulate";
            this.Regulate.Size = new System.Drawing.Size(221, 41);
            this.Regulate.TabIndex = 24;
            this.Regulate.Text = "  Quy định";
            this.Regulate.UseVisualStyleBackColor = false;
            this.Regulate.Click += new System.EventHandler(this.Regulate_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.Turquoise;
            this.Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Search.IconSize = 30;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(0, 421);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(221, 41);
            this.Search.TabIndex = 23;
            this.Search.Text = "  Tra cứu";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Baocaocongno
            // 
            this.Baocaocongno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Baocaocongno.Dock = System.Windows.Forms.DockStyle.Top;
            this.Baocaocongno.FlatAppearance.BorderSize = 0;
            this.Baocaocongno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baocaocongno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baocaocongno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Baocaocongno.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.Baocaocongno.IconColor = System.Drawing.Color.Turquoise;
            this.Baocaocongno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Baocaocongno.IconSize = 30;
            this.Baocaocongno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Baocaocongno.Location = new System.Drawing.Point(0, 38);
            this.Baocaocongno.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Baocaocongno.Name = "Baocaocongno";
            this.Baocaocongno.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Baocaocongno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Baocaocongno.Size = new System.Drawing.Size(221, 38);
            this.Baocaocongno.TabIndex = 25;
            this.Baocaocongno.Text = "         Báo cáo công nợ";
            this.Baocaocongno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Baocaocongno.UseVisualStyleBackColor = false;
            this.Baocaocongno.Click += new System.EventHandler(this.Baocaocongno_Click_1);
            // 
            // Baocaodoanhthu
            // 
            this.Baocaodoanhthu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Baocaodoanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Baocaodoanhthu.FlatAppearance.BorderSize = 0;
            this.Baocaodoanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baocaodoanhthu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baocaodoanhthu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Baocaodoanhthu.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Baocaodoanhthu.IconColor = System.Drawing.Color.Turquoise;
            this.Baocaodoanhthu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Baocaodoanhthu.IconSize = 30;
            this.Baocaodoanhthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Baocaodoanhthu.Location = new System.Drawing.Point(0, 0);
            this.Baocaodoanhthu.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Baocaodoanhthu.Name = "Baocaodoanhthu";
            this.Baocaodoanhthu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Baocaodoanhthu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Baocaodoanhthu.Size = new System.Drawing.Size(221, 38);
            this.Baocaodoanhthu.TabIndex = 24;
            this.Baocaodoanhthu.Text = "         Báo cáo doanh số";
            this.Baocaodoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Baocaodoanhthu.UseVisualStyleBackColor = false;
            this.Baocaodoanhthu.Click += new System.EventHandler(this.Baocaodoanhthu_Click_1);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Report.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.Report.IconColor = System.Drawing.Color.Turquoise;
            this.Report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Report.IconSize = 30;
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(0, 296);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(221, 43);
            this.Report.TabIndex = 18;
            this.Report.Text = "  Báo cáo";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Phieuxuathang
            // 
            this.Phieuxuathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Phieuxuathang.Dock = System.Windows.Forms.DockStyle.Top;
            this.Phieuxuathang.FlatAppearance.BorderSize = 0;
            this.Phieuxuathang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Phieuxuathang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phieuxuathang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Phieuxuathang.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.Phieuxuathang.IconColor = System.Drawing.Color.Turquoise;
            this.Phieuxuathang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Phieuxuathang.IconSize = 30;
            this.Phieuxuathang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Phieuxuathang.Location = new System.Drawing.Point(0, 85);
            this.Phieuxuathang.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Phieuxuathang.Name = "Phieuxuathang";
            this.Phieuxuathang.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Phieuxuathang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Phieuxuathang.Size = new System.Drawing.Size(221, 47);
            this.Phieuxuathang.TabIndex = 17;
            this.Phieuxuathang.Text = "         Phiếu xuất hàng";
            this.Phieuxuathang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Phieuxuathang.UseVisualStyleBackColor = false;
            this.Phieuxuathang.Click += new System.EventHandler(this.Phieuxuathang_Click_3);
            // 
            // Phieuthutien
            // 
            this.Phieuthutien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Phieuthutien.Dock = System.Windows.Forms.DockStyle.Top;
            this.Phieuthutien.FlatAppearance.BorderSize = 0;
            this.Phieuthutien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Phieuthutien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phieuthutien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Phieuthutien.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.Phieuthutien.IconColor = System.Drawing.Color.Turquoise;
            this.Phieuthutien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Phieuthutien.IconSize = 30;
            this.Phieuthutien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Phieuthutien.Location = new System.Drawing.Point(0, 41);
            this.Phieuthutien.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Phieuthutien.Name = "Phieuthutien";
            this.Phieuthutien.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Phieuthutien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Phieuthutien.Size = new System.Drawing.Size(221, 44);
            this.Phieuthutien.TabIndex = 16;
            this.Phieuthutien.Text = "         Phiếu thu tiền";
            this.Phieuthutien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Phieuthutien.UseVisualStyleBackColor = false;
            this.Phieuthutien.Click += new System.EventHandler(this.Phieuthutien_Click);
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.File.Dock = System.Windows.Forms.DockStyle.Top;
            this.File.FlatAppearance.BorderSize = 0;
            this.File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.File.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.File.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.File.IconColor = System.Drawing.Color.Turquoise;
            this.File.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.File.IconSize = 30;
            this.File.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Margin = new System.Windows.Forms.Padding(12, 3, 8, 3);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.File.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.File.Size = new System.Drawing.Size(221, 41);
            this.File.TabIndex = 11;
            this.File.Text = "         Hồ sơ";
            this.File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.File.UseVisualStyleBackColor = false;
            this.File.Click += new System.EventHandler(this.File_Click_3);
            // 
            // Manage
            // 
            this.Manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Manage.Dock = System.Windows.Forms.DockStyle.Top;
            this.Manage.FlatAppearance.BorderSize = 0;
            this.Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Manage.IconChar = FontAwesome.Sharp.IconChar.Magento;
            this.Manage.IconColor = System.Drawing.Color.Turquoise;
            this.Manage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Manage.IconSize = 30;
            this.Manage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Manage.Location = new System.Drawing.Point(0, 122);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(221, 41);
            this.Manage.TabIndex = 12;
            this.Manage.Text = "  Quản lý";
            this.Manage.UseVisualStyleBackColor = false;
            this.Manage.Click += new System.EventHandler(this.Manage_Click_1);
            // 
            // Loggout
            // 
            this.Loggout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Loggout.Dock = System.Windows.Forms.DockStyle.Top;
            this.Loggout.FlatAppearance.BorderSize = 0;
            this.Loggout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loggout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loggout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Loggout.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.Loggout.IconColor = System.Drawing.Color.Turquoise;
            this.Loggout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Loggout.IconSize = 30;
            this.Loggout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loggout.Location = new System.Drawing.Point(0, 38);
            this.Loggout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Loggout.Name = "Loggout";
            this.Loggout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Loggout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Loggout.Size = new System.Drawing.Size(221, 38);
            this.Loggout.TabIndex = 11;
            this.Loggout.Text = "         Đăng xuất";
            this.Loggout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loggout.UseVisualStyleBackColor = false;
            this.Loggout.Click += new System.EventHandler(this.Loggout_Click_1);
            // 
            // Changepass
            // 
            this.Changepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Changepass.Dock = System.Windows.Forms.DockStyle.Top;
            this.Changepass.FlatAppearance.BorderSize = 0;
            this.Changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Changepass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changepass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Changepass.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.Changepass.IconColor = System.Drawing.Color.Turquoise;
            this.Changepass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Changepass.IconSize = 30;
            this.Changepass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Changepass.Location = new System.Drawing.Point(0, 0);
            this.Changepass.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Changepass.Name = "Changepass";
            this.Changepass.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Changepass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Changepass.Size = new System.Drawing.Size(221, 38);
            this.Changepass.TabIndex = 10;
            this.Changepass.Text = "         Đổi mật khẩu mới";
            this.Changepass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Changepass.UseVisualStyleBackColor = false;
            this.Changepass.Click += new System.EventHandler(this.Changepass_Click);
            // 
            // Homepage
            // 
            this.Homepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Homepage.Dock = System.Windows.Forms.DockStyle.Top;
            this.Homepage.FlatAppearance.BorderSize = 0;
            this.Homepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homepage.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homepage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Homepage.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homepage.IconColor = System.Drawing.Color.Turquoise;
            this.Homepage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homepage.IconSize = 30;
            this.Homepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homepage.Location = new System.Drawing.Point(0, 0);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(221, 43);
            this.Homepage.TabIndex = 5;
            this.Homepage.Text = "  Trang chủ";
            this.Homepage.UseVisualStyleBackColor = false;
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Minimizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Minimizar.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimizar.IconSize = 30;
            this.Minimizar.Location = new System.Drawing.Point(834, 9);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 31);
            this.Minimizar.TabIndex = 11;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click_1);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.Exit.IconColor = System.Drawing.Color.Red;
            this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit.IconSize = 30;
            this.Exit.Location = new System.Drawing.Point(864, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 31);
            this.Exit.TabIndex = 5;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 622);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menubar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelQuydinh.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            this.panelManage.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Menubar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox Exit;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Homepage;
        private System.Windows.Forms.Panel panelSubmenu;
        private FontAwesome.Sharp.IconButton Changepass;
        private FontAwesome.Sharp.IconButton Manage;
        private FontAwesome.Sharp.IconButton Loggout;
        private FontAwesome.Sharp.IconButton Report;
        private System.Windows.Forms.Panel panelReport;
        private FontAwesome.Sharp.IconButton Baocaodoanhthu;
        private FontAwesome.Sharp.IconButton Baocaocongno;
        private FontAwesome.Sharp.IconButton Search;
        private FontAwesome.Sharp.IconButton Regulate;
        private System.Windows.Forms.Panel panelManage;
        private FontAwesome.Sharp.IconButton File;
        private FontAwesome.Sharp.IconButton Phieuxuathang;
        private FontAwesome.Sharp.IconButton Phieuthutien;
        private System.Windows.Forms.Panel panelQuydinh;
        private FontAwesome.Sharp.IconButton Hanghoa;
        private FontAwesome.Sharp.IconButton Sodailytrongquan;
        private FontAwesome.Sharp.IconButton Loaidaily;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

