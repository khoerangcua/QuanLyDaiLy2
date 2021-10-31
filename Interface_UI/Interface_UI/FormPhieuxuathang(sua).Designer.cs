
namespace Interface_UI
{
    partial class FormPhieuxuathang_sua_
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.phieuxuathangs_datagridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hanghoa_combobox = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.soluong_textbox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nohientai_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IbLoaidaily = new System.Windows.Forms.Label();
            this.IbDiachi = new System.Windows.Forms.Label();
            this.luu_button = new FontAwesome.Sharp.IconButton();
            this.xoa_button = new FontAwesome.Sharp.IconButton();
            this.them_button = new FontAwesome.Sharp.IconButton();
            this.huy_button = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nam_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thang_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timkiem_button = new FontAwesome.Sharp.IconButton();
            this.tendaily_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chitietphieuxuathang_datagridview = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangs_datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitietphieuxuathang_datagridview)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // TieudePhieuxuat
            // 
            this.TieudePhieuxuat.AutoSize = true;
            this.TieudePhieuxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieudePhieuxuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TieudePhieuxuat.Location = new System.Drawing.Point(42, 14);
            this.TieudePhieuxuat.Name = "TieudePhieuxuat";
            this.TieudePhieuxuat.Size = new System.Drawing.Size(148, 17);
            this.TieudePhieuxuat.TabIndex = 2;
            this.TieudePhieuxuat.Text = "Phiếu xuất hàng / Sửa";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox3.Controls.Add(this.phieuxuathangs_datagridview);
            this.groupBox3.Location = new System.Drawing.Point(17, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 127);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu xuât hàng";
            // 
            // phieuxuathangs_datagridview
            // 
            this.phieuxuathangs_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuxuathangs_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.phieuxuathangs_datagridview.Location = new System.Drawing.Point(6, 16);
            this.phieuxuathangs_datagridview.Name = "phieuxuathangs_datagridview";
            this.phieuxuathangs_datagridview.RowHeadersWidth = 51;
            this.phieuxuathangs_datagridview.Size = new System.Drawing.Size(622, 108);
            this.phieuxuathangs_datagridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.hanghoa_combobox);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.soluong_textbox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.nohientai_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IbLoaidaily);
            this.groupBox1.Controls.Add(this.IbDiachi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(19, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 91);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // hanghoa_combobox
            // 
            this.hanghoa_combobox.Cursor = System.Windows.Forms.Cursors.Default;
            this.hanghoa_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hanghoa_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanghoa_combobox.FormattingEnabled = true;
            this.hanghoa_combobox.Items.AddRange(new object[] {
            "Loại 1",
            "Loại 2"});
            this.hanghoa_combobox.Location = new System.Drawing.Point(55, 42);
            this.hanghoa_combobox.Name = "hanghoa_combobox";
            this.hanghoa_combobox.Size = new System.Drawing.Size(128, 28);
            this.hanghoa_combobox.TabIndex = 24;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(252, 68);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(128, 2);
            this.panel9.TabIndex = 23;
            // 
            // soluong_textbox
            // 
            this.soluong_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.soluong_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soluong_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong_textbox.Location = new System.Drawing.Point(252, 46);
            this.soluong_textbox.Multiline = true;
            this.soluong_textbox.Name = "soluong_textbox";
            this.soluong_textbox.Size = new System.Drawing.Size(128, 20);
            this.soluong_textbox.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(447, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 2);
            this.panel4.TabIndex = 23;
            // 
            // nohientai_textbox
            // 
            this.nohientai_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.nohientai_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nohientai_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nohientai_textbox.Location = new System.Drawing.Point(447, 48);
            this.nohientai_textbox.Multiline = true;
            this.nohientai_textbox.Name = "nohientai_textbox";
            this.nohientai_textbox.Size = new System.Drawing.Size(128, 20);
            this.nohientai_textbox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(87, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hàng hoá";
            // 
            // IbLoaidaily
            // 
            this.IbLoaidaily.AutoSize = true;
            this.IbLoaidaily.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbLoaidaily.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IbLoaidaily.Location = new System.Drawing.Point(277, 18);
            this.IbLoaidaily.Name = "IbLoaidaily";
            this.IbLoaidaily.Size = new System.Drawing.Size(70, 19);
            this.IbLoaidaily.TabIndex = 11;
            this.IbLoaidaily.Text = "Số Lượng";
            // 
            // IbDiachi
            // 
            this.IbDiachi.AutoSize = true;
            this.IbDiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbDiachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IbDiachi.Location = new System.Drawing.Point(470, 18);
            this.IbDiachi.Name = "IbDiachi";
            this.IbDiachi.Size = new System.Drawing.Size(75, 19);
            this.IbDiachi.TabIndex = 8;
            this.IbDiachi.Text = "Nợ hiện tại";
            // 
            // luu_button
            // 
            this.luu_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.luu_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu_button.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.luu_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            this.luu_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.luu_button.IconSize = 32;
            this.luu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.luu_button.Location = new System.Drawing.Point(347, 233);
            this.luu_button.Name = "luu_button";
            this.luu_button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.luu_button.Size = new System.Drawing.Size(112, 36);
            this.luu_button.TabIndex = 38;
            this.luu_button.Text = "Lưu";
            this.luu_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.luu_button.UseVisualStyleBackColor = false;
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
            this.xoa_button.Location = new System.Drawing.Point(210, 233);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.xoa_button.Size = new System.Drawing.Size(112, 36);
            this.xoa_button.TabIndex = 37;
            this.xoa_button.Text = "Xoá";
            this.xoa_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa_button.UseVisualStyleBackColor = false;
            // 
            // them_button
            // 
            this.them_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.them_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_button.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.them_button.IconColor = System.Drawing.Color.Green;
            this.them_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.them_button.IconSize = 32;
            this.them_button.Location = new System.Drawing.Point(77, 233);
            this.them_button.Name = "them_button";
            this.them_button.Padding = new System.Windows.Forms.Padding(0, 1, 25, 0);
            this.them_button.Size = new System.Drawing.Size(112, 36);
            this.them_button.TabIndex = 35;
            this.them_button.Text = "Thêm";
            this.them_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.them_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them_button.UseVisualStyleBackColor = false;
            // 
            // huy_button
            // 
            this.huy_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.huy_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy_button.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.huy_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(64)))));
            this.huy_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.huy_button.IconSize = 32;
            this.huy_button.Location = new System.Drawing.Point(482, 233);
            this.huy_button.Name = "huy_button";
            this.huy_button.Padding = new System.Windows.Forms.Padding(0, 1, 35, 0);
            this.huy_button.Size = new System.Drawing.Size(112, 36);
            this.huy_button.TabIndex = 36;
            this.huy_button.Text = "Huỷ";
            this.huy_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.huy_button.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox2.Controls.Add(this.nam_combobox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.thang_combobox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.timkiem_button);
            this.groupBox2.Controls.Add(this.tendaily_combobox);
            this.groupBox2.Location = new System.Drawing.Point(19, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 89);
            this.groupBox2.TabIndex = 39;
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
            this.nam_combobox.Location = new System.Drawing.Point(348, 42);
            this.nam_combobox.Name = "nam_combobox";
            this.nam_combobox.Size = new System.Drawing.Size(101, 28);
            this.nam_combobox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(219, 19);
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
            this.thang_combobox.Location = new System.Drawing.Point(183, 42);
            this.thang_combobox.Name = "thang_combobox";
            this.thang_combobox.Size = new System.Drawing.Size(121, 28);
            this.thang_combobox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên đại lý";
            // 
            // timkiem_button
            // 
            this.timkiem_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.timkiem_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem_button.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.timkiem_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timkiem_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.timkiem_button.IconSize = 32;
            this.timkiem_button.Location = new System.Drawing.Point(486, 38);
            this.timkiem_button.Name = "timkiem_button";
            this.timkiem_button.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.timkiem_button.Size = new System.Drawing.Size(112, 33);
            this.timkiem_button.TabIndex = 24;
            this.timkiem_button.Text = "Tìm";
            this.timkiem_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timkiem_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem_button.UseVisualStyleBackColor = false;
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
            this.tendaily_combobox.Location = new System.Drawing.Point(30, 42);
            this.tendaily_combobox.Name = "tendaily_combobox";
            this.tendaily_combobox.Size = new System.Drawing.Size(124, 28);
            this.tendaily_combobox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.groupBox4.Controls.Add(this.chitietphieuxuathang_datagridview);
            this.groupBox4.Location = new System.Drawing.Point(17, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 138);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết phiếu xuất hàng";
            // 
            // chitietphieuxuathang_datagridview
            // 
            this.chitietphieuxuathang_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chitietphieuxuathang_datagridview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.chitietphieuxuathang_datagridview.Location = new System.Drawing.Point(6, 19);
            this.chitietphieuxuathang_datagridview.Name = "chitietphieuxuathang_datagridview";
            this.chitietphieuxuathang_datagridview.RowHeadersWidth = 51;
            this.chitietphieuxuathang_datagridview.Size = new System.Drawing.Size(622, 108);
            this.chitietphieuxuathang_datagridview.TabIndex = 1;
            this.chitietphieuxuathang_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chitietphieuxuathang_datagridview_CellContentClick);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Yellow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Yellow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 554);
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
            // FormPhieuxuathang_sua_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(671, 575);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.luu_button);
            this.Controls.Add(this.huy_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.xoa_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.them_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuxuathang_sua_";
            this.Text = "FormPhieuxuathang_sua_";
            this.Load += new System.EventHandler(this.FormPhieuxuathang_sua__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPhieuxuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuathangs_datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chitietphieuxuathang_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TieudePhieuxuat;
        private FontAwesome.Sharp.IconPictureBox dashboardPhieuxuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView phieuxuathangs_datagridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox hanghoa_combobox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox soluong_textbox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox nohientai_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IbLoaidaily;
        private System.Windows.Forms.Label IbDiachi;
        private FontAwesome.Sharp.IconButton luu_button;
        private FontAwesome.Sharp.IconButton xoa_button;
        private FontAwesome.Sharp.IconButton them_button;
        private FontAwesome.Sharp.IconButton huy_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox nam_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox thang_combobox;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton timkiem_button;
        private System.Windows.Forms.ComboBox tendaily_combobox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView chitietphieuxuathang_datagridview;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}