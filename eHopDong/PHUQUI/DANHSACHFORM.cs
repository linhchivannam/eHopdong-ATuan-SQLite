using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.PHUQUI
{
    partial class DANHSACHFORM : Form
    {
        LINQ.DbDataContext db;
        bool sua = false;
        Int64 IDTMP =0;
        public DANHSACHFORM()
        {
            InitializeComponent();            
        }
        private void Setup()
        {
            dgv.DataSource = db.dsforms.OrderBy(w=>w.nhom).ThenBy(w=>w.tenform).ToList();
        }
        private void DANHSACHFORM_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            Setup();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa.Text = dgv.Rows[e.RowIndex].Cells["tenform"].Value.ToString();
                txtTen.Text = dgv.Rows[e.RowIndex].Cells["tiengviet"].Value.ToString();
                txtNhom.Text = dgv.Rows[e.RowIndex].Cells["nhom"].Value.ToString();
                IDTMP = Convert.ToInt64(dgv.Rows[e.RowIndex].Cells["id"].Value.ToString());


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

            string txt = txtNhom.Text;
            Functions.EnableAll(pRight); // mo len cho sai 
            Functions.NullControl(pRight); // xoa trang
            txtNhom.Text = txt;
            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (PQ.Permission == "0")
            {
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                Functions.EnableAll(pRight);


                dgv.Enabled = false;
                sua = true;
            }
            else
            {
                MessageBox.Show("Chưa cấp quyền!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (PQ.Permission == "0")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtMa.Text + "] " + txtTen.Text, "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var query = db.dsforms.Where(w => w.tenform == txtMa.Text).FirstOrDefault();
                    db.dsforms.DeleteOnSubmit(query);




                    db.SubmitChanges();
                    Setup();
                    btnHuy.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Chưa cấp quyền", "Thông báo");
            }
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
                var q = db.dsforms.Where(w => w.tenform == txtMa.Text.Trim()).FirstOrDefault();
                if (q != null)
                    return false;
            }

            return true;
        }
        private void Insert()
        {
            LINQ.dsform a = new LINQ.dsform();
            a.tenform = txtMa.Text;
            a.tiengviet = txtTen.Text;
            a.nhom = txtNhom.Text;
            
            db.dsforms.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        private void UpdateData()
        {
            var a = db.dsforms.Where(w => w.tenform == txtMa.Text.Trim() ).FirstOrDefault();
            if (a != null)
            {
                a.tenform = txtMa.Text;
                a.tiengviet = txtTen.Text;
                a.nhom = txtNhom.Text;

             
                db.SubmitChanges();
            }
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Functions.DisableAll(pRight);
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            dgv.Enabled = true;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTen.Focus();
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNhom.Focus();
        }

        private void txtNhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu.Focus();
        }
    }
}
