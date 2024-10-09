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
    partial class frm_DlgKhachhang : Form
    {
        public frm_DlgKhachhang()
        {
            InitializeComponent();
        }

        PQDb.MODEL.PQDb db;
        List<PQDb.MODEL.Khachhang> ds;
        bool sua = false;
        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKHma.Text = dgv.Rows[e.RowIndex].Cells["Ma"].Value.ToString();
                txtKHten.Text = dgv.Rows[e.RowIndex].Cells["Ten"].Value.ToString();

                txtKHDaidien.Text = dgv.Rows[e.RowIndex].Cells["Daidien"].Value.ToString();
                txtKHChucvu.Text = dgv.Rows[e.RowIndex].Cells["Chucvu"].Value.ToString();
                txtKHDiachi.Text = dgv.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
                txtKhDienthoai.Text = dgv.Rows[e.RowIndex].Cells["Dienthoai"].Value.ToString();
                txtKHMST.Text = dgv.Rows[e.RowIndex].Cells["Masothue"].Value.ToString();
                txtKHSoTK.Text = dgv.Rows[e.RowIndex].Cells["Sotaikhoan"].Value.ToString();
                txtKHNH.Text = dgv.Rows[e.RowIndex].Cells["Taikhoannganhang"].Value.ToString();               

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Lỗi");
            }
        }

        private void frm_DlgUser_Load(object sender, EventArgs e)
        {
            db = new PQDb.MODEL.PQDb();
            ds = new List<PQDb.MODEL.Khachhang>();
            Setup();
            btnHuy.PerformClick();
        }
        private void Setup()
        {
            ds.Clear();
            var q = db.GetKhachhang();
            ds.AddRange(q);
            Search();
        }
        private void Search()
        {
            var q = ds.Where(w=>w.Ma.ToLower().Contains(txtSearch.Text.Trim().ToLower()) || w.Ten.ToLower().Contains(txtSearch.Text.Trim().ToLower()));
            khachhangBindingSource.DataSource = q.ToList();
            txtSum.Text = dgv.RowCount.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private bool Check_NoExist()
        {
            int i = 0;
            i += Functions.CheckTexboxnotNull(txtKHten);

            if (i > 0)
                return false;            

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check_NoExist())
            {
                bool fl = true;
                if (sua)
                {
                    db.UpdateKhachhang(txtKHma.Text, txtKHten.Text, txtKHDaidien.Text, txtKHChucvu.Text, txtKHDiachi.Text, txtKhDienthoai.Text, txtKHMST.Text, txtKHNH.Text, txtKHSoTK.Text);
                }
                else
                {

                    db.InsertKhachhang( txtKHma.Text, txtKHten.Text, txtKHDaidien.Text, txtKHChucvu.Text, txtKHDiachi.Text, txtKhDienthoai.Text, txtKHMST.Text, txtKHNH.Text, txtKHSoTK.Text);
                }

                if (fl)
                {

                    PQ.ClickOK = true;
                    MessageBox.Show("Lưu hoàn thành!", "Thông báo");
                    Setup();
                    btnHuy.PerformClick();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtKHma.Text + "] " + txtKHten.Text , "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                db.DeleteKhachhang(txtKHma.Text.Trim().ToLower());
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

            txtKHma.Focus();
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtKHten.Focus();
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

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (txtKHma.Text.Trim().Length > 0)
            {
                PQ.tamma = txtKHma.Text.Trim();
                PQ.ClickOK = true;
                this.Close();
            }
        }
    }
}
