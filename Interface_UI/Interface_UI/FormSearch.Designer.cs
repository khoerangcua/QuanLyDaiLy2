
namespace Interface_UI
{
    partial class FormSearch
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tendaily_textbox = new System.Windows.Forms.TextBox();
            this.timkiem_button = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.quan_combobox = new System.Windows.Forms.ComboBox();
            this.loai_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IbMadaily = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dalys_datagridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dalys_datagridview)).BeginInit();
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
            this.panel1.TabIndex = 8;
            // 
            // TieudePhieuxuat
            // 
            this.TieudePhieuxuat.AutoSize = true;
            this.TieudePhieuxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieudePhieuxuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TieudePhieuxuat.Location = new System.Drawing.Point(56, 17);
            this.TieudePhieuxuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieudePhieuxuat.Name = "TieudePhieuxuat";
            this.TieudePhieuxuat.Size = new System.Drawing.Size(75, 22);
            this.TieudePhieuxuat.TabIndex = 2;
            this.TieudePhieuxuat.Text = "Tra cứu";
            // 
            // dashboardPhieuxuat
            // 
            this.dashboardPhieuxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.dashboardPhieuxuat.ForeColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconChar = FontAwesome.Sharp.IconChar.Search;
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
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.tendaily_textbox);
            this.groupBox2.Controls.Add(this.timkiem_button);
            this.groupBox2.Controls.Add(this.iconButton3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.quan_combobox);
            this.groupBox2.Controls.Add(this.loai_combobox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IbMadaily);
            this.groupBox2.Location = new System.Drawing.Point(123, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(617, 203);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(151, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 2);
            this.panel3.TabIndex = 30;
            // 
            // tendaily_textbox
            // 
            this.tendaily_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.tendaily_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tendaily_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendaily_textbox.Location = new System.Drawing.Point(149, 31);
            this.tendaily_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tendaily_textbox.Multiline = true;
            this.tendaily_textbox.Name = "tendaily_textbox";
            this.tendaily_textbox.Size = new System.Drawing.Size(187, 23);
            this.tendaily_textbox.TabIndex = 29;
            // 
            // timkiem_button
            // 
            this.timkiem_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.timkiem_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem_button.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.timkiem_button.IconColor = System.Drawing.Color.Black;
            this.timkiem_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.timkiem_button.IconSize = 32;
            this.timkiem_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timkiem_button.Location = new System.Drawing.Point(433, 81);
            this.timkiem_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timkiem_button.Name = "timkiem_button";
            this.timkiem_button.Padding = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.timkiem_button.Size = new System.Drawing.Size(149, 44);
            this.timkiem_button.TabIndex = 28;
            this.timkiem_button.Text = "Tìm kiếm";
            this.timkiem_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem_button.UseVisualStyleBackColor = false;
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
            this.iconButton3.Location = new System.Drawing.Point(433, 143);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(149, 44);
            this.iconButton3.TabIndex = 27;
            this.iconButton3.Text = "Quay lại";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quận";
            // 
            // quan_combobox
            // 
            this.quan_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quan_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.quan_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.quan_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quan_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quan_combobox.FormattingEnabled = true;
            this.quan_combobox.Items.AddRange(new object[] {
            "Mã đại lý",
            "Tên đại lý",
            "Email",
            "Điện thoại"});
            this.quan_combobox.Location = new System.Drawing.Point(149, 81);
            this.quan_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quan_combobox.Name = "quan_combobox";
            this.quan_combobox.Size = new System.Drawing.Size(185, 33);
            this.quan_combobox.TabIndex = 9;
            // 
            // loai_combobox
            // 
            this.loai_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.loai_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.loai_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.loai_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loai_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loai_combobox.FormattingEnabled = true;
            this.loai_combobox.Items.AddRange(new object[] {
            "Mã đại lý",
            "Tên đại lý",
            "Email",
            "Điện thoại"});
            this.loai_combobox.Location = new System.Drawing.Point(149, 153);
            this.loai_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loai_combobox.Name = "loai_combobox";
            this.loai_combobox.Size = new System.Drawing.Size(185, 33);
            this.loai_combobox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại";
            // 
            // IbMadaily
            // 
            this.IbMadaily.AutoSize = true;
            this.IbMadaily.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbMadaily.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IbMadaily.Location = new System.Drawing.Point(32, 34);
            this.IbMadaily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbMadaily.Name = "IbMadaily";
            this.IbMadaily.Size = new System.Drawing.Size(91, 22);
            this.IbMadaily.TabIndex = 5;
            this.IbMadaily.Text = "Tên đại lý";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox3.Controls.Add(this.dalys_datagridview);
            this.groupBox3.Location = new System.Drawing.Point(13, 313);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(844, 255);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // dalys_datagridview
            // 
            this.dalys_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dalys_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dalys_datagridview.Location = new System.Drawing.Point(7, 23);
            this.dalys_datagridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dalys_datagridview.Name = "dalys_datagridview";
            this.dalys_datagridview.RowHeadersWidth = 51;
            this.dalys_datagridview.Size = new System.Drawing.Size(829, 224);
            this.dalys_datagridview.TabIndex = 0;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(873, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dalys_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TieudePhieuxuat;
        private FontAwesome.Sharp.IconPictureBox dashboardPhieuxuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label IbMadaily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox quan_combobox;
        private System.Windows.Forms.ComboBox loai_combobox;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton timkiem_button;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dalys_datagridview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tendaily_textbox;
    }
}