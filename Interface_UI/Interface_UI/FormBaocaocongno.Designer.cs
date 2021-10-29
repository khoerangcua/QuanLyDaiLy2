
namespace Interface_UI
{
    partial class FormBaocaocongno
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.baocaocongnos_datagridview = new System.Windows.Forms.DataGridView();
            this.thang_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nam_combobox = new System.Windows.Forms.ComboBox();
            this.timkiem_button = new FontAwesome.Sharp.IconButton();
            this.in_button = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baocaocongnos_datagridview)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.panel1.TabIndex = 5;
            // 
            // TieudePhieuxuat
            // 
            this.TieudePhieuxuat.AutoSize = true;
            this.TieudePhieuxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieudePhieuxuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TieudePhieuxuat.Location = new System.Drawing.Point(42, 14);
            this.TieudePhieuxuat.Name = "TieudePhieuxuat";
            this.TieudePhieuxuat.Size = new System.Drawing.Size(115, 17);
            this.TieudePhieuxuat.TabIndex = 2;
            this.TieudePhieuxuat.Text = "Báo cáo công nợ";
            // 
            // dashboardPhieuxuat
            // 
            this.dashboardPhieuxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.dashboardPhieuxuat.ForeColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.dashboardPhieuxuat.IconColor = System.Drawing.Color.Turquoise;
            this.dashboardPhieuxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardPhieuxuat.IconSize = 29;
            this.dashboardPhieuxuat.Location = new System.Drawing.Point(10, 9);
            this.dashboardPhieuxuat.Name = "dashboardPhieuxuat";
            this.dashboardPhieuxuat.Size = new System.Drawing.Size(29, 29);
            this.dashboardPhieuxuat.TabIndex = 1;
            this.dashboardPhieuxuat.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 60);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo công nợ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox3.Controls.Add(this.baocaocongnos_datagridview);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 227);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // baocaocongnos_datagridview
            // 
            this.baocaocongnos_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baocaocongnos_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.baocaocongnos_datagridview.Location = new System.Drawing.Point(5, 19);
            this.baocaocongnos_datagridview.Name = "baocaocongnos_datagridview";
            this.baocaocongnos_datagridview.RowHeadersWidth = 51;
            this.baocaocongnos_datagridview.Size = new System.Drawing.Size(635, 202);
            this.baocaocongnos_datagridview.TabIndex = 0;
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
            this.thang_combobox.Location = new System.Drawing.Point(86, 44);
            this.thang_combobox.Name = "thang_combobox";
            this.thang_combobox.Size = new System.Drawing.Size(121, 28);
            this.thang_combobox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(267, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Năm";
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
            this.nam_combobox.Location = new System.Drawing.Point(312, 44);
            this.nam_combobox.Name = "nam_combobox";
            this.nam_combobox.Size = new System.Drawing.Size(101, 28);
            this.nam_combobox.TabIndex = 12;
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
            this.timkiem_button.Location = new System.Drawing.Point(467, 14);
            this.timkiem_button.Name = "timkiem_button";
            this.timkiem_button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.timkiem_button.Size = new System.Drawing.Size(112, 36);
            this.timkiem_button.TabIndex = 28;
            this.timkiem_button.Text = "Tìm kiếm";
            this.timkiem_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem_button.UseVisualStyleBackColor = false;
            this.timkiem_button.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // in_button
            // 
            this.in_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.in_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_button.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.in_button.IconColor = System.Drawing.Color.Lavender;
            this.in_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.in_button.IconSize = 32;
            this.in_button.Location = new System.Drawing.Point(467, 60);
            this.in_button.Name = "in_button";
            this.in_button.Padding = new System.Windows.Forms.Padding(0, 1, 35, 0);
            this.in_button.Size = new System.Drawing.Size(112, 36);
            this.in_button.TabIndex = 42;
            this.in_button.Text = "In";
            this.in_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.in_button.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox2.Controls.Add(this.in_button);
            this.groupBox2.Controls.Add(this.timkiem_button);
            this.groupBox2.Controls.Add(this.nam_combobox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.thang_combobox);
            this.groupBox2.Location = new System.Drawing.Point(28, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 106);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // FormBaocaocongno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(671, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaocaocongno";
            this.Text = "FormBaocaocongno";
            this.Load += new System.EventHandler(this.FormBaocaocongno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baocaocongnos_datagridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TieudePhieuxuat;
        private FontAwesome.Sharp.IconPictureBox dashboardPhieuxuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView baocaocongnos_datagridview;
        private System.Windows.Forms.ComboBox thang_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nam_combobox;
        private FontAwesome.Sharp.IconButton timkiem_button;
        private FontAwesome.Sharp.IconButton in_button;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}