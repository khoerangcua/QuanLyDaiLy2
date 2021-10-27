using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;

namespace Interface_UI.BUS.Controllers
{
    public class QuanController
    {
        #region fields
        public string MessageFailure { get; set; }
        private QuanLyDaiLyEntities db;
        #endregion

        #region controls
        public TextBox MaQuanTextBox { get; set; }
        public TextBox TenQuanTextBox { get; set; }
        public TextBox LuongDaiLyToiDaTextBox { get; set; }
        public Button CapNhatButotn { get; set; }
        public DataGridView QuanData { get; set; }
        #endregion

        #region constructor
        public QuanController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();
            
        }

       


        #endregion

        #region methods

        public void LoadLanDau()
        {
            var quans = from q in db.tb_Quan
                        select new { MaQuan = q.Ma_Quan, TenQuan = q.Ten_Quan, SoLuongDaiLyToiDa = q.DaiLy_ToiDa };
            this.QuanData.DataSource = null;
            this.QuanData.DataSource = quans.ToList();
            //
            //subcribe events
            //
            this.QuanData.RowEnter += QuanData_RowEnter;
            this.CapNhatButotn.Click += CapNhatButotn_Click;
            //
            //set control status
            //
            this.MaQuanTextBox.Enabled = false;
            this.TenQuanTextBox.Enabled = false;

        }

        private bool SuaQuan()
        {
            //
            //reset message failure
            //
            this.MessageFailure = "";
            //
            //lay thong tin
            //
            int maquan = int.Parse(this.MaQuanTextBox.Text);
            var quan = this.db.tb_Quan.FirstOrDefault(q => q.Ma_Quan == maquan);
            if (quan == default)
            {
                this.MessageFailure = "quan khong ton tai";
                return false;
            }
            else
            {
                int luongdailytoida = int.Parse(this.LuongDaiLyToiDaTextBox.Text);
                //
                //kiem tra luong dai ly hien tai
                //
                bool luongdailyhientai = this.db.tb_Quan.FirstOrDefault(q => q.Ma_Quan == maquan).tb_DaiLy.Count() > luongdailytoida;
                if (luongdailyhientai==true)
                {
                    this.MessageFailure = "luong dai ly toi da nho hon luong dai ly hien tai";
                    return false;
                }
                quan.DaiLy_ToiDa = luongdailytoida;
                if (db.SaveChanges()==0)
                {
                    this.MessageFailure = "sua luong dai ly toi da khong thanh cong";
                    return false;
                }
                else
                {
                    //
                    //reset form
                    //
                    var quans = from q in db.tb_Quan
                                select new { MaQuan = q.Ma_Quan, TenQuan = q.Ten_Quan, SoLuongDaiLyToiDa = q.DaiLy_ToiDa };
                    this.QuanData.DataSource = null;
                    this.QuanData.DataSource = quans.ToList();
                    return true;

                }
            }
            
        }
        #endregion

        #region event
        private void QuanData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.MaQuanTextBox.Text = this.QuanData.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.TenQuanTextBox.Text = this.QuanData.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.LuongDaiLyToiDaTextBox.Text = this.QuanData.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void CapNhatButotn_Click(object sender, EventArgs e)
        {
            this.SuaQuan();
        }
        #endregion
    }
}
