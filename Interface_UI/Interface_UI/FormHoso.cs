using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.BUS.Controllers;

namespace Interface_UI
{
    public partial class FormHoso : Form
    {
        // Controller
        HoSoDaiLyController HoSoDaiLyController;

        public FormHoso()
        {
            InitializeComponent();
            this.HoSoDaiLyController = new HoSoDaiLyController
            {
                MaDaiLyText = this.madaily_textbox,
                TenDaiLyText_HienThi = this.tendailyhienthi_textbox,
                LoaiDaiLyComboBox = this.loaidaily_combobox,
                DiaChiText = this.diachi_textbox,
                DienThoaiText = this.sdt_textbox,
                EmailText = this.email_textbox,
                QuanComboBox_HienThi = this.quanhienthi_combobox,
                NgayTiepNhanText = this.ngaytiepnhan_textbox,
                QuanComboBox_TimKiem = this.quantimkiem_combobox,
                TenDaiLyText_TimKiem = this.tendailytimkiem_combobox,
                HoSoDaiLyDataGridView = this.dailys_datagridview,
                ThemButton = this.them_button,
                XoaButton = this.xoa_button,
                SuaButton = this.capnhat_button,
                ResetButton = this.lammoi_button,
                TimKiemButton = this.timkiem_button                
            };
        }

        private void FormHoso_Load(object sender, EventArgs e)
        {
            this.HoSoDaiLyController.ChayLanDau();
        }

        
    }
}
