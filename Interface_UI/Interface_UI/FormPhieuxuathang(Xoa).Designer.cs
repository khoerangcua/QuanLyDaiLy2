
namespace Interface_UI
{
    partial class FormPhieuxuathang_Xoa_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TieudePhieuxuat = new System.Windows.Forms.Label();
            this.dashboardPhieuxuat = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nam_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thang_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tim_button = new FontAwesome.Sharp.IconButton();
            this.tendaily_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.phieuxuathangs_datagridview = new System.Windows.Forms.DataGridView();
            this.xoa_button = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangs_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.TieudePhieuxuat);
            this.panel1.Controls.Add(this.dashboardPhieuxuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 41);
            this.panel1.TabIndex = 3;
            // 
            // TieudePhieuxuat
            // 
            this.TieudePhieuxuat.AutoSize = true;
            this.TieudePhieuxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieudePhieuxuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TieudePhieuxuat.Location = new System.Drawing.Point(42, 14);
            this.TieudePhieuxuat.Name = "TieudePhieuxuat";
            this.TieudePhieuxuat.Size = new System.Drawing.Size(149, 17);
            this.TieudePhieuxuat.TabIndex = 2;
            this.TieudePhieuxuat.Text = "Phiếu xuất hàng / Xoá";
            // 
            // dashboardPhieuxuat
            // 
            this.dashboardPhieuxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.dashboardPhieuxuat.ForeColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.dashboardPhieuxuat.IconColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardPhieuxuat.IconSize = 29;
            this.dashboardPhieuxuat.Location = new System.Drawing.Point(10, 9);
            this.dashboardPhieuxuat.Name = "dashboardPhieuxuat";
            this.dashboardPhieuxuat.Size = new System.Drawing.Size(29, 29);
            this.dashboardPhieuxuat.TabIndex = 1;
            this.dashboardPhieuxuat.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox2.Controls.Add(this.nam_combobox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.thang_combobox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tim_button);
            this.groupBox2.Controls.Add(this.tendaily_combobox);
            this.groupBox2.Location = new System.Drawing.Point(20, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // nam_combobox
            // 
            this.nam_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nam_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nam_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.nam_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nam_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nam_combobox.FormattingEnabled = true;
            this.nam_combobox.Items.AddRange(new object[] {
            "Mã đại lý",
            "Tên đại lý",
            "Email",
            "Điện thoại"});
            this.nam_combobox.Location = new System.Drawing.Point(348, 46);
            this.nam_combobox.Name = "nam_combobox";
            this.nam_combobox.Size = new System.Drawing.Size(101, 28);
            this.nam_combobox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(380, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(219, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tháng";
            // 
            // thang_combobox
            // 
            this.thang_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.thang_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.thang_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.thang_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thang_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thang_combobox.FormattingEnabled = true;
            this.thang_combobox.Items.AddRange(new object[] {
            "Mã đại lý",
            "Tên đại lý",
            "Email",
            "Điện thoại"});
            this.thang_combobox.Location = new System.Drawing.Point(189, 46);
            this.thang_combobox.Name = "thang_combobox";
            this.thang_combobox.Size = new System.Drawing.Size(121, 28);
            this.thang_combobox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên đại lý";
            // 
            // tim_button
            // 
            this.tim_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tim_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim_button.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.tim_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tim_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tim_button.IconSize = 32;
            this.tim_button.Location = new System.Drawing.Point(486, 14);
            this.tim_button.Name = "tim_button";
            this.tim_button.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.tim_button.Size = new System.Drawing.Size(112, 33);
            this.tim_button.TabIndex = 24;
            this.tim_button.Text = "Tìm";
            this.tim_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tim_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tim_button.UseVisualStyleBackColor = false;
            // 
            // tendaily_combobox
            // 
            this.tendaily_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tendaily_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tendaily_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.tendaily_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tendaily_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendaily_combobox.FormattingEnabled = true;
            this.tendaily_combobox.Items.AddRange(new object[] {
            "Mã đại lý",
            "Tên đại lý",
            "Email",
            "Điện thoại"});
            this.tendaily_combobox.Location = new System.Drawing.Point(30, 46);
            this.tendaily_combobox.Name = "tendaily_combobox";
            this.tendaily_combobox.Size = new System.Drawing.Size(124, 28);
            this.tendaily_combobox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox3.Controls.Add(this.phieuxuathangs_datagridview);
            this.groupBox3.Location = new System.Drawing.Point(10, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 252);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // phieuxuathangs_datagridview
            // 
            this.phieuxuathangs_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuxuathangs_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.phieuxuathangs_datagridview.Location = new System.Drawing.Point(5, 19);
            this.phieuxuathangs_datagridview.Name = "phieuxuathangs_datagridview";
            this.phieuxuathangs_datagridview.RowHeadersWidth = 51;
            this.phieuxuathangs_datagridview.Size = new System.Drawing.Size(635, 227);
            this.phieuxuathangs_datagridview.TabIndex = 0;
            // 
            // xoa_button
            // 
            this.xoa_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.xoa_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_button.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.xoa_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.xoa_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoa_button.IconSize = 31;
            this.xoa_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_button.Location = new System.Drawing.Point(506, 170);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.xoa_button.Size = new System.Drawing.Size(112, 33);
            this.xoa_button.TabIndex = 30;
            this.xoa_button.Text = "Xoá";
            this.xoa_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa_button.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Yellow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Yellow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 554);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 20);
            this.iconPictureBox1.TabIndex = 45;
            this.iconPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 553);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(671, 22);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "                   Thong bao";
            // 
            // FormPhieuxuathang_Xoa_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(671, 575);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xoa_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuxuathang_Xoa_";
            this.Text = "FormPhieuxuathang_Xoa_";
            this.Load += new System.EventHandler(this.FormPhieuxuathang_Xoa__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangs_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TieudePhieuxuat;
        private FontAwesome.Sharp.IconPictureBox dashboardPhieuxuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox tendaily_combobox;
        private FontAwesome.Sharp.IconButton tim_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView phieuxuathangs_datagridview;
        private FontAwesome.Sharp.IconButton xoa_button;
        private System.Windows.Forms.ComboBox nam_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox thang_combobox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}