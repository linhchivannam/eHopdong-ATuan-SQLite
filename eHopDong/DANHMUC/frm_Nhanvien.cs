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
    partial class frm_Nhanvien : Form
    {
        public frm_Nhanvien()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        bool sua = false;

        private void frm_NhomSP_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            phongbanBindingSource.DataSource = db.phongbans.OrderBy(w=>w.ten);
            nhomquyenBindingSource.DataSource = db.nhomquyens.OrderBy(w=>w.ten).Select(w=>new { ma=w.ma.ToString(),ten=w.ten});
            Setup();
            btnHuy.PerformClick();
        }
        private void Setup()
        {
            dgv.DataSource = db.DS_NHANVIEN_ADMIN().OrderBy(w => w.ten).ToList();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Functions.NullControl(pValue);
                txtMa.Text = dgv.Rows[e.RowIndex].Cells["ma"].Value.ToString();
                txtTen.Text = dgv.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                Functions.ChooseIndexLinQ(cbxBophan, dgv.Rows[e.RowIndex].Cells["bophan"].Value);
                Functions.ChooseIndexLinQ(cbxNhomquyen, dgv.Rows[e.RowIndex].Cells["nhomquyen"].Value);
                chkOK.Checked = Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["ok"].Value);
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
            else
            {
                MessageBox.Show("Chưa cấp quyền!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db, this.Name, DateTime.Now.Date, "xoa"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtMa.Text + "] " + txtTen.Text, "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var query = db.nhanviens.Where(w => w.ma == txtMa.Text.Trim().ToLower()).FirstOrDefault();
                    db.nhanviens.DeleteOnSubmit(query);

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
                var q = db.nhanviens.Where(w => w.ma == txtMa.Text.Trim().ToLower()).FirstOrDefault();
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
            LINQ.nhanvien a = new LINQ.nhanvien();
            a.ma = txtMa.Text.Trim().ToLower();
            a.ten = txtTen.Text;
           a.pass = Functions.getMd5Hash(a.ma);
            a.ok = chkOK.Checked;
            a.bophan = cbxBophan.SelectedValue.ToString();
            a.nhomquyen =Functions.ChuyenInt16(cbxNhomquyen.SelectedValue.ToString());



            db.nhanviens.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        private void UpdateData()
        {
            var a = db.nhanviens.Where(w => w.ma == txtMa.Text.Trim().ToLower()).FirstOrDefault();
            if (a != null)
            {
                if (chkDoiPass.Checked)
                    a.pass = Functions.getMd5Hash(a.ma);

                a.ten = txtTen.Text;                
                a.ok = chkOK.Checked;
                a.bophan = cbxBophan.SelectedValue.ToString();
                a.nhomquyen = Functions.ChuyenInt16(cbxNhomquyen.SelectedValue.ToString());


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
            //if (e.KeyCode == Keys.Enter)
               
        }

        private void txtCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu.Focus();
        }
    }
}
