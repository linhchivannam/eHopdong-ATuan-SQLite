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
    partial class frm_DlgVersion : Form
    {
        LINQ.DbDataContext db;
        bool sua = false;
        DateTime ngaytam;
        public frm_DlgVersion()
        {
            InitializeComponent();
        }
        private void Setup()
        {
            dgv.DataSource = db.versions.OrderByDescending(w => w.ngay).ToList();
        }
        private void frm_DlgVersion_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            Setup();
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


            Functions.EnableAll(pRight); // mo len cho sai 
            Functions.NullControl(pRight); // xoa trang
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
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + dtTu.Value.ToString("dd/MM/yyyy") + "] " + txtTen.Text, "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var query = db.versions.Where(w => w.ngay.Date == dtTu.Value.Date).FirstOrDefault();
                    db.versions.DeleteOnSubmit(query);

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
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            dgv.Enabled = true;
            Functions.DisableAll(pRight);
        }
        private bool Check_NoExist()
        {
            int i = 0;           
            i += Functions.CheckTexboxnotNull(txtTen);

            if (i > 0)
                return false;

            if (!sua)
            {
                var q = db.versions.Where(w => w.ngay.Date == dtTu.Value.Date).FirstOrDefault();
                if (q != null)
                    return false;
            }

            return true;
        }
        private void Insert()
        {
            LINQ.version a = new LINQ.version();
            a.ngay = dtTu.Value.Date;
            a.noidung = txtTen.Text;
            a.username = PQ.UserName;
            a.batbuot = chkOk.Checked;

            db.versions.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        private void UpdateData()
        {
            var a = db.versions.Where(w => w.ngay.Date == dtTu.Value.Date).FirstOrDefault();
            if (a != null)
            {
                a.noidung = txtTen.Text;
                a.username = PQ.UserName;
                a.batbuot = chkOk.Checked;

                db.SubmitChanges();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                txtTen.Text = dgv.Rows[e.RowIndex].Cells["noidung"].Value.ToString();
                dtTu.Text= dgv.Rows[e.RowIndex].Cells["ngay"].Value.ToString();
                chkOk.Checked = Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["batbuot"].Value);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Lỗi");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DLG.frm_BaocaoCapnhat f = new DLG.frm_BaocaoCapnhat();
            f.ShowDialog();
        }
    }
}
