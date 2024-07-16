using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eHopdong.DANHMUC
{
    partial class frm_Tinh : Form
    {
        public frm_Tinh()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        bool sua = false;

        private void frm_NhomSP_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            Setup();
            btnHuy.PerformClick();
        }
        private void Setup()
        {
            dgv.DataSource = db.tinhs.OrderBy(w => w.ten).ToList();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Functions.NullControl(pValue);
                txtMa.Text = dgv.Rows[e.RowIndex].Cells["ma"].Value.ToString();
                txtTen.Text = dgv.Rows[e.RowIndex].Cells["ten"].Value.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Lỗi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            sua = false;
            dgv.Enabled = false;


            Functions.EnableAll(pValue); // mo len cho sai 
            Functions.NullControl(pValue); // xoa trang

            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db,this.Name, DateTime.Now.Date, "sua"))
            {
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                Functions.EnableAll(pValue);
                dgv.Enabled = false;
                sua = true;
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db, this.Name, DateTime.Now.Date, "xoa"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtMa.Text + "] " + txtTen.Text, "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var query = db.tinhs.Where(w => w.ma == txtMa.Text).FirstOrDefault();
                    db.tinhs.DeleteOnSubmit(query);

                    db.SubmitChanges();
                    Setup();
                    btnHuy.PerformClick();
                }
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            dgv.Enabled = true;
            Functions.DisableAll(pValue);
        }
        private bool Check_NoExist()
        {
            int i = 0;
            i += Functions.CheckTexboxnotNull(txtMa);
            i += Functions.CheckTexboxnotNull(txtTen);

            if (i > 0)
                return false;

            if (!sua)
            {
                var q = db.tinhs.Where(w => w.ma == txtMa.Text.Trim().ToLower()).FirstOrDefault();
                if (q != null)
                    return false;
            }

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check_NoExist())
            {
                bool fl = true;
                if (sua)
                {
                    UpdateData();
                }
                else
                {
                    Insert();
                }

                if (fl)
                {
                    MessageBox.Show("Lưu hoàn thành!", "Thông báo");
                    Setup();
                    btnHuy.PerformClick();
                }
            }
        }
        private void Insert()
        {
            LINQ.tinh a = new LINQ.tinh();
            a.ma = txtMa.Text.Trim().ToLower();
            a.ten = txtTen.Text;                   


            db.tinhs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        private void UpdateData()
        {
            var a = db.tinhs.Where(w => w.ma == txtMa.Text.Trim()).FirstOrDefault();
            if (a != null)
            {
                a.ten = txtTen.Text;           

                db.SubmitChanges();
            }
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTen.Focus();
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu.Focus();
        }
    }
}
