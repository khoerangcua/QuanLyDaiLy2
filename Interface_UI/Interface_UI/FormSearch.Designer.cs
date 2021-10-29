
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.TieudePhieuxuat);
            this.panel1.Controls.Add(this.dashboardPhieuxuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 41);
            this.panel1.TabIndex = 8;
            // 
            // TieudePhieuxuat
            // 
            this.TieudePhieuxuat.AutoSize = true;
            this.TieudePhieuxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieudePhieuxuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TieudePhieuxuat.Location = new System.Drawing.Point(42, 14);
            this.TieudePhieuxuat.Name = "TieudePhieuxuat";
            this.TieudePhieuxuat.Size = new System.Drawing.Size(58, 17);
            this.TieudePhieuxuat.TabIndex = 2;
            this.TieudePhieuxuat.Text = "Tra cứu";
            // 
            // dashboardPhieuxuat
            // 
            this.dashboardPhieuxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.dashboardPhieuxuat.ForeColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconChar = FontAwesome.Sharp.IconChar.Search;
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
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.tendaily_textbox);
            this.groupBox2.Controls.Add(this.timkiem_button);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.quan_combobox);
            this.groupBox2.Controls.Add(this.loai_combobox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IbMadaily);
            this.groupBox2.Location = new System.Drawing.Point(114, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 165);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(113, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 2);
            this.panel3.TabIndex = 30;
            // 
            // tendaily_textbox
            // 
            this.tendaily_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.tendaily_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tendaily_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendaily_textbox.Location = new System.Drawing.Point(112, 25);
            this.tendaily_textbox.Multiline = true;
            this.tendaily_textbox.Name = "tendaily_textbox";
            this.tendaily_textbox.Size = new System.Drawing.Size(140, 19);
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
            this.timkiem_button.Location = new System.Drawing.Point(305, 75);
            this.timkiem_button.Name = "timkiem_button";
            this.timkiem_button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.timkiem_button.Size = new System.Drawing.Size(112, 36);
            this.timkiem_button.TabIndex = 28;
            this.timkiem_button.Text = "Tìm kiếm";
            this.timkiem_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem_button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
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
            this.quan_combobox.Location = new System.Drawing.Point(112, 66);
            this.quan_combobox.Name = "quan_combobox";
            this.quan_combobox.Size = new System.Drawing.Size(140, 28);
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
            this.loai_combobox.Location = new System.Drawing.Point(112, 124);
            this.loai_combobox.Name = "loai_combobox";
            this.loai_combobox.Size = new System.Drawing.Size(140, 28);
            this.loai_combobox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại";
            // 
            // IbMadaily
            // 
            this.IbMadaily.AutoSize = true;
            this.IbMadaily.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbMadaily.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IbMadaily.Location = new System.Drawing.Point(24, 28);
            this.IbMadaily.Name = "IbMadaily";
            this.IbMadaily.Size = new System.Drawing.Size(68, 19);
            this.IbMadaily.TabIndex = 5;
            this.IbMadaily.Text = "Tên đại lý";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox3.Controls.Add(this.dalys_datagridview);
            this.groupBox3.Location = new System.Drawing.Point(19, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 215);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // dalys_datagridview
            // 
            this.dalys_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dalys_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dalys_datagridview.Location = new System.Drawing.Point(5, 19);
            this.dalys_datagridview.Name = "dalys_datagridview";
            this.dalys_datagridview.RowHeadersWidth = 51;
            this.dalys_datagridview.Size = new System.Drawing.Size(622, 190);
            this.dalys_datagridview.TabIndex = 0;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(671, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dalys_datagridview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tendaily_textbox;
    }
}