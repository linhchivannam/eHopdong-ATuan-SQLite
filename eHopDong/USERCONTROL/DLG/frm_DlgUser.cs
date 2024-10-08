using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.USERCONTROL.DLG
{
    partial class frm_DlgUser : Form
    {
        public frm_DlgUser()
        {
            InitializeComponent();
        }

        PQDb.MODEL.PQDb db;
        List<PQDb.MODEL.Nguoidung> ds;
        bool sua = false;
        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa.Text = dgv.Rows[e.RowIndex].Cells["Ma"].Value.ToString();
                txtTen.Text = dgv.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
               
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Lỗi");
            }
        }

        private void frm_DlgUser_Load(object sender, EventArgs e)
        {
            db = new PQDb.MODEL.PQDb();
            ds = new List<PQDb.MODEL.Nguoidung>();
            Setup();
            btnHuy.PerformClick();
        }
        private void Setup()
        {
            ds.Clear();
            var q = db.GetDSNguoidung();
            ds.AddRange(q);
            Search();
        }
        private void Search()
        {
            var q = ds.Where(w=>w.Ma.ToLower().Contains(txtSearch.Text.Trim().ToLower()) || w.Ten.ToLower().Contains(txtSearch.Text.Trim().ToLower()));
            nguoidungBindingSource.DataSource = q.ToList();
            txtSum.Text = dgv.RowCount.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var q = db.GetNguoidung(txtMa.Text);
            if (q != null)
            {
                if (chkMatkhau.Checked)
                {
                    db.UpdateNguoidung(txtMa.Text, txtTen.Text, Functions.getMd5Hash(txtMa.Text.Trim().ToLower()));
                }
                else
                    db.UpdateNguoidung(txtMa.Text, txtTen.Text, q.Pass);
            }
            else
            {
                db.InsertNguoidung(txtMa.Text, txtTen.Text, Functions.getMd5Hash(txtMa.Text.Trim().ToLower()));
            }
            Setup();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtMa.Text + "] " + txtTen.Text , "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                db.DeleteNguoidung(txtMa.Text.Trim().ToLower());
                PQ.ClickOK = true;
                Setup();
                btnHuy.PerformClick();
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

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
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
    }
}
