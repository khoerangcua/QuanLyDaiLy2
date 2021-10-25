
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
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangs_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.TieudePhieuxuat);
            this.panel1.Controls.Add(this.dashboardPhieuxuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 50);
            this.panel1.TabIndex = 3;
            // 
            // TieudePhieuxuat
            // 
            this.TieudePhieuxuat.AutoSize = true;
            this.TieudePhieuxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieudePhieuxuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TieudePhieuxuat.Location = new System.Drawing.Point(56, 17);
            this.TieudePhieuxuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieudePhieuxuat.Name = "TieudePhieuxuat";
            this.TieudePhieuxuat.Size = new System.Drawing.Size(189, 22);
            this.TieudePhieuxuat.TabIndex = 2;
            this.TieudePhieuxuat.Text = "Phiếu xuất hàng / Xoá";
            // 
            // dashboardPhieuxuat
            // 
            this.dashboardPhieuxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.dashboardPhieuxuat.ForeColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.dashboardPhieuxuat.IconColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardPhieuxuat.IconSize = 36;
            this.dashboardPhieuxuat.Location = new System.Drawing.Point(13, 11);
            this.dashboardPhieuxuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardPhieuxuat.Name = "dashboardPhieuxuat";
            this.dashboardPhieuxuat.Size = new System.Drawing.Size(39, 36);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(841, 110);
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
            this.nam_combobox.Location = new System.Drawing.Point(464, 52);
            this.nam_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nam_combobox.Name = "nam_combobox";
            this.nam_combobox.Size = new System.Drawing.Size(133, 33);
            this.nam_combobox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(507, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(292, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
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
            this.thang_combobox.Location = new System.Drawing.Point(252, 52);
            this.thang_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thang_combobox.Name = "thang_combobox";
            this.thang_combobox.Size = new System.Drawing.Size(160, 33);
            this.thang_combobox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
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
            this.tim_button.Location = new System.Drawing.Point(648, 47);
            this.tim_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tim_button.Name = "tim_button";
            this.tim_button.Padding = new System.Windows.Forms.Padding(0, 0, 33, 0);
            this.tim_button.Size = new System.Drawing.Size(149, 41);
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
            this.tendaily_combobox.Location = new System.Drawing.Point(40, 52);
            this.tendaily_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tendaily_combobox.Name = "tendaily_combobox";
            this.tendaily_combobox.Size = new System.Drawing.Size(164, 33);
            this.tendaily_combobox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox3.Controls.Add(this.phieuxuathangs_datagridview);
            this.groupBox3.Location = new System.Drawing.Point(13, 258);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(860, 298);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // phieuxuathangs_datagridview
            // 
            this.phieuxuathangs_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuxuathangs_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.phieuxuathangs_datagridview.Location = new System.Drawing.Point(7, 23);
            this.phieuxuathangs_datagridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phieuxuathangs_datagridview.Name = "phieuxuathangs_datagridview";
            this.phieuxuathangs_datagridview.RowHeadersWidth = 51;
            this.phieuxuathangs_datagridview.Size = new System.Drawing.Size(847, 246);
            this.phieuxuathangs_datagridview.TabIndex = 0;
            // 
            // xoa_button
            // 
            this.xoa_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.xoa_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_button.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.xoa_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.xoa_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoa_button.IconSize = 32;
            this.xoa_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_button.Location = new System.Drawing.Point(541, 571);
            this.xoa_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Padding = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.xoa_button.Size = new System.Drawing.Size(149, 44);
            this.xoa_button.TabIndex = 30;
            this.xoa_button.Text = "Xoá";
            this.xoa_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa_button.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.iconButton3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(184, 571);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(149, 44);
            this.iconButton3.TabIndex = 26;
            this.iconButton3.Text = "Quay lại";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // FormPhieuxuathang_Xoa_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(873, 660);
            this.Controls.Add(this.xoa_button);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ResumeLayout(false);

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
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton xoa_button;
        private System.Windows.Forms.ComboBox nam_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox thang_combobox;
    }
}