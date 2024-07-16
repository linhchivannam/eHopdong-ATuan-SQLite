using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.DLG
{
    partial class frm_DlgChuyenKhach : Form
    {
        public frm_DlgChuyenKhach()
        {
            InitializeComponent();
        }
       public IList<long> arr;
        LINQ.DbDataContext db;
        public string idcu = "";

        private void frm_DlgChuyenKhach_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
                nhanvienBindingSource.DataSource = db.nhanviens.Where(w => w.ma != "phuqui" ).OrderBy(w => w.ten).ToList();
            }
            else if (PQ.Permission == "1")
            {
                nhanvienBindingSource.DataSource = db.DS_NHANVIEN_QUANLY(PQ.Bophan).OrderBy(w => w.ten).ToList();
            }
            else
            {
                nhanvienBindingSource.DataSource = db.nhanviens.Where(w => w.ma == PQ.UserName).OrderBy(w => w.ten).ToList();
            }
            txtSum.Text = arr.Count.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn chuyển  " + "[" + arr.Count.ToString() + "] " + " Khách hàng sang tài khoản nhân viên: " +cbxNV.Text, "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cbxNV.SelectedValue != null)
                    {
                        foreach (var ok in arr)
                        {
                            var q = db.khachhangs.Where(w => w.id == ok).FirstOrDefault();
                            if (q != null)
                            {
                                q.username = cbxNV.SelectedValue.ToString();
                            }
                            db.SubmitChanges();
                        }
                    }
                }
                MessageBox.Show("Chuyển thành công!","Thông báo");
                PQ.ClickOK = true;
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
