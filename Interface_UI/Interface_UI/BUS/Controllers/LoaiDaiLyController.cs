using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_UI.DAO;

namespace Interface_UI.BUS.Controllers
{
    public class LoaiDaiLyController
    {
        #region fields
        public string MessageFailure { get; set; }
        private QuanLyDaiLyEntities db;
        #endregion

        #region controls
        public TextBox MaLoaiDaiLyTextBox { get; set; }
        public TextBox TenLoaiDaiLyTextBox { get; set; }
        public TextBox TienNoToiDaTextBox { get; set; }
        public Button ThemButton { get; set; }
        public Button CapNhatButton { get; set; }
        public Button XoaButton { get; set; }
        public DataGridView LoaiDaiLyData { get; set; }
        #endregion

        #region constructor
        public LoaiDaiLyController()
        {
            this.MessageFailure = "";
            this.db = new QuanLyDaiLyEntities();
            
        }

        

        #endregion

        #region methods
        public void LoadLanDau()
        {
            var loaidailys = from ldl in db.tb_LoaiDaiLy
                             select new { MaLoai = ldl.Ma_Loai_DaiLy, TenLoai = ldl.Ten_Loai, TienNoToiDa = ldl.TienNo_ToiDa };
            this.LoaiDaiLyData.DataSource = null;
            this.LoaiDaiLyData.DataSource = loaidailys.ToList();
            //
            //subcribe events
            //
            this.LoaiDaiLyData.RowEnter += LoaiDaiLyData_RowEnter;
            this.ThemButton.Click += ThemButton_Click;
            this.CapNhatButton.Click += CapNhatButton_Click;
            this.XoaButton.Click += XoaButton_Click;
            //
            //set state of controls
            //
            this.MaLoaiDaiLyTextBox.Enabled = false;
        }

        private bool ThemLoaiDaiLy()
        {
            this.MessageFailure = "";
            //
            //lay thong tin loai dai ly
            //
            int maloai = 1;
            if (db.tb_LoaiDaiLy.Any())
            {
                maloai = db.tb_LoaiDaiLy.Max(p => p.Ma_Loai_DaiLy) + 1;
            }
            string tenloaidaily = this.TenLoaiDaiLyTextBox.Text;
            double tiennotoida = double.Parse(this.TienNoToiDaTextBox.Text);
            //
            //thuc thi them loai dai ly vao csdl
            //
            db.tb_LoaiDaiLy.Add(new tb_LoaiDaiLy { Ma_Loai_DaiLy = maloai, Ten_Loai = tenloaidaily, TienNo_ToiDa = tiennotoida });
            //
            //kiem tra them co thanh cong ?
            //
            if (db.SaveChanges() == 0)
            {
                this.MessageFailure = "them loai dai ly khong thanh cong";
                return false;
            }
            //
            // reset form
            //
            var loaidailys = from ldl in db.tb_LoaiDaiLy
                             select new { MaLoai = ldl.Ma_Loai_DaiLy, TenLoai = ldl.Ten_Loai, TienNoToiDa = ldl.TienNo_ToiDa };
            this.LoaiDaiLyData.DataSource = null;
            this.LoaiDaiLyData.DataSource = loaidailys.ToList();
            return true;

        }

        private bool XoaLoaiDaiLy()
        {
            this.MessageFailure = "";
            //
            // lay thong tin
            //
            int maloaidaily = int.Parse(this.MaLoaiDaiLyTextBox.Text);
            //
            //tim kiem loai dai ly tuong ung
            //
            var loaidaily = db.tb_LoaiDaiLy.FirstOrDefault(p => p.Ma_Loai_DaiLy == maloaidaily);
            if (loaidaily == default)
            {
                this.MessageFailure = "loai dai ly khong ton tai";
                return false;
            }
            else
            {
                db.tb_LoaiDaiLy.Remove(loaidaily);
                //
                // kiem tra xoa co thanh cong ?
                //
                if (db.SaveChanges() == 0)
                {
                    this.MessageFailure = "xoa khong thanh cong";
                    return false;
                }
                else
                {
                    //
                    //resert form
                    //
                    var loaidailys = from ldl in db.tb_LoaiDaiLy
                                     select new { MaLoai = ldl.Ma_Loai_DaiLy, TenLoai = ldl.Ten_Loai, TienNoToiDa = ldl.TienNo_ToiDa };
                    this.LoaiDaiLyData.DataSource = null;
                    this.LoaiDaiLyData.DataSource = loaidailys.ToList();
                    return true;
                }
            }
        }

        private bool CapNhatLoaiDaiLy()
        {
            this.MessageFailure = "";
            //
            // lay thong tin loai dai ly
            //
            int maloaidaily = int.Parse(this.MaLoaiDaiLyTextBox.Text);
            string tenloaidaily = this.TenLoaiDaiLyTextBox.Text;
            double tiennotoida = double.Parse(TienNoToiDaTextBox.Text);

            var loaidaily = db.tb_LoaiDaiLy.FirstOrDefault(p => p.Ma_Loai_DaiLy == maloaidaily);
            if (loaidaily == default)
            {
                this.MessageFailure = "loai dai ly khong ton tai";
                return false;
            }
            else
            {
                loaidaily.Ten_Loai = tenloaidaily;
                loaidaily.TienNo_ToiDa = tiennotoida;
                if (db.SaveChanges() == 0)
                {
                    this.MessageFailure = "cap nhat khong thanh cong";
                    return false;
                }
                else
                {
                    //
                    //reset form
                    //
                    var loaidailys = from ldl in db.tb_LoaiDaiLy
                                     select new { MaLoai = ldl.Ma_Loai_DaiLy, TenLoai = ldl.Ten_Loai, TienNoToiDa = ldl.TienNo_ToiDa };
                    this.LoaiDaiLyData.DataSource = null;
                    this.LoaiDaiLyData.DataSource = loaidailys.ToList();
                    return true;
                }
            }
        }
        #endregion

        #region event
        private void LoaiDaiLyData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.MaLoaiDaiLyTextBox.Text = this.LoaiDaiLyData.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.TenLoaiDaiLyTextBox.Text = this.LoaiDaiLyData.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.TienNoToiDaTextBox.Text = this.LoaiDaiLyData.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void XoaButton_Click(object sender, EventArgs e)
        {
            this.XoaLoaiDaiLy();
        }

        private void CapNhatButton_Click(object sender, EventArgs e)
        {
            this.CapNhatLoaiDaiLy();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            this.ThemLoaiDaiLy();
        }
        #endregion



    }
}
