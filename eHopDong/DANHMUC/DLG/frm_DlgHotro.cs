using eHopdong.PHUQUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace eHopdong.DANHMUC.DLG
{
    partial class frm_DlgHotro : Form
    {
        public frm_DlgHotro()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        bool sua = false;
        PHUQUI.CustomDataGridViewCombo dgvCboUser;

        private void frm_DlgKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();           

            if (PQ.Permission == "0")
            {
                nhanvienBindingSource.DataSource = db.nhanviens.Where(w => w.ma != "phuqui").OrderBy(w => w.ten).ToList();
            }
            else if (PQ.Permission == "1")
            {
                nhanvienBindingSource.DataSource = db.DS_NHANVIEN_QUANLY(PQ.Bophan).OrderBy(w => w.ten).ToList();
            }
            else 
            {
                nhanvienBindingSource.DataSource = db.nhanviens.Where(w => w.ma ==PQ.UserName).OrderBy(w => w.ten).ToList();
            }            


            btnHuy.PerformClick();
            Setup();
        }

        private void Setup()
        {
            add_dgv_cbo_user();
            if (lbSCT.Text.Trim().Length>0)
            {
                var a = db.chamsockhachhangs.Where(w=>w.id==Functions.ChuyenInt(lbSCT.Text)).FirstOrDefault();
                if(a!=null)
                {
                   txtMaKH.Text = a.makh.ToString() ;                 

                    var k = db.khachhangs.Where(w=>w.id==a.makh).FirstOrDefault();
                    if (k!=null)
                    {
                        txtTenKH.Text = k.ten;
                        txtDiachi.Text = k.diachi;
                        txtDT.Text = k.dienthoai;
                    }
                    dtNgay.Value = a.ngay.Value;
                    txtDichvu.Text= a.noidung ;                    
                    Functions.ChooseIndexLinQ(cbxNV, a.username);                    
                }
            }
            
        }
        private void add_dgv_cbo_user()
        {
            dgvCboUser = new PHUQUI.CustomDataGridViewCombo();
            dgvCboUser.Width = 520;
            dgvCboUser.Height = 160;
            dgvCboUser.ReadOnly = true;
            dgvCboUser.AllowUserToAddRows = false;
            dgvCboUser.AllowUserToDeleteRows = false;
            dgvCboUser.ColumnHeadersVisible = false;
            dgvCboUser.RowHeadersVisible = false;
            dgvCboUser.DefaultCellStyle.Font = new Font("Arial", 10f);
            dgvCboUser.BackgroundColor = Color.White;
            base.Controls.Add(dgvCboUser);
            dgvCboUser.Visible = false;
            dgvCboUser.CellClick += dgvCboUser_CellClick;
            dgvCboUser.KeyDown += dgvCboUser_KeyDown;
        }
        private void show_user_combo()
        {
            if (!txtMaKH.ReadOnly)
            {
                dgvCboUser.Location = new Point(txtMaKH.Location.X, txtMaKH.Location.Y + txtMaKH.Height);
                dgvCboUser.Visible = true;
                dgvCboUser.BringToFront();
                dgvCboUser.DataSource = LoadKhachhang(txtMaKH.Text.ToLower());
                dgvCboUser.Columns["ma"].Width = 40;
                dgvCboUser.Columns["ten"].Width = 210;
                dgvCboUser.Columns["ten"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgvCboUser.Columns["dienthoai"].Width = 100;
                dgvCboUser.Columns["diachi"].Width = 150;
            }
        }
        private List<MODEL.KhachhangRutgon> LoadKhachhang(string txt)
        {
            if (PQ.Permission == "0")
            {
                return db.khachhangs.Where(w => w.ten.ToLower().Contains(txt)).Select(w => new MODEL.KhachhangRutgon
                { ma = w.id.ToString(), ten = w.ten, diachi = w.diachi, dienthoai = w.dienthoai }).ToList();
            }
            else
            {
                return db.khachhangs.Where(w => w.username == PQ.UserName & w.ten.ToLower().Contains(txt)).Select(w => new MODEL.KhachhangRutgon
                { ma = w.id.ToString(), ten = w.ten, diachi = w.diachi, dienthoai = w.dienthoai }).ToList();
            }
        }
        private void dgvCboUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            set_user_and_hide_combo();
        }
       
        private void set_user_and_hide_combo()
        {
            try
            {
                int curent = dgvCboUser.CurrentCell.RowIndex;
                txtMaKH.Text = dgvCboUser.Rows[dgvCboUser.CurrentCell.RowIndex].Cells["ma"].Value.ToString();

                var k = db.khachhangs.Where(w => w.id == Functions.ChuyenInt(txtMaKH.Text)).FirstOrDefault();
                if (k != null)
                {
                    txtTenKH.Text = k.ten;
                    txtDiachi.Text = k.diachi;
                    txtDT.Text = k.dienthoai;
                }
                //MessageBox.Show(dgvCboUser.CurrentRow.Index.ToString());
                //txtTenKH.Text = dgvCboUser.Rows[curent].Cells["ten"].Value.ToString();
                //txtDT.Text = dgvCboUser.Rows[curent].Cells["dienthoai"].Value.ToString();
            }
            catch
            {
            }
            dgvCboUser.Visible = false;
            
        }
        private void dgvCboUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                int num = dgvCboUser.CurrentCell.RowIndex + 1;
                if (num < dgvCboUser.RowCount)
                {
                    dgvCboUser.CurrentCell = dgvCboUser.Rows[num].Cells[1];
                }
                e.Handled = true;
            }
            if (e.KeyData == (Keys.Tab | Keys.Shift))
            {
                int num2 = dgvCboUser.CurrentCell.RowIndex - 1;
                if (num2 >= 0)
                {
                    dgvCboUser.CurrentCell = dgvCboUser.Rows[num2].Cells[1];
                }
                e.Handled = true;
            }
            if (dgvCboUser.CurrentRow != null)
            {
                dgvCboUser.CurrentRow.Selected = true;
            }
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Space)
            {
                set_user_and_hide_combo();
                txtDichvu.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                dgvCboUser.Visible = false;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            sua = false;
            //dgv.Enabled = false;
            string tamma, tamten, tamchucvu, tamdt = "";
            tamma = txtMaKH.Text;
            tamten = txtTenKH.Text;
            tamchucvu = txtDiachi.Text;
            tamdt = txtDT.Text;

            Functions.EnableAll(pValue); // mo len cho sai 
            Functions.NullControl(pValue); // xoa trang

             txtMaKH.Text=tamma;
             txtTenKH.Text= tamten ;
             txtDiachi.Text= tamchucvu ;
             txtDT.Text= tamdt ;

            if (dgvCboUser != null)
                dgvCboUser.Visible = false;
            txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db, this.Name, dtNgay.Value, "sua"))
            {
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                Functions.EnableAll(pValue);
               // dgv.Enabled = false;
                sua = true;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db, this.Name, dtNgay.Value, "xoa"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtMaKH.Text + "] " + txtTenKH.Text, "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var query = db.chamsockhachhangs.Where(w => w.id == Functions.ChuyenInt(lbSCT.Text.Trim())).FirstOrDefault();
                    if (query != null)
                    {
                        db.chamsockhachhangs.DeleteOnSubmit(query);

                        db.SubmitChanges();
                        PQ.ClickOK = true;
                        //  Setup();
                        btnHuy.PerformClick();
                    }
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
            
           // dgv.Enabled = true;
            Functions.DisableAll(pValue);
        }
        private bool Check_NoExist()
        {
            int i = 0;           
            i += Functions.CheckTexboxnotNull(txtTenKH);

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
                    if (Functions.KiemtraQuyen(db, this.Name, dtNgay.Value, "sua"))
                    {
                        UpdateData();
                    }
                    else
                        fl = false;
                }
                else
                {
                    if (Functions.KiemtraQuyen(db, this.Name, dtNgay.Value, "them"))
                    {
                        Insert();
                    }
                    else
                        fl = false;
                }

                if (fl)
                {
                    UpdateGiadichcuoi();
                    PQ.ClickOK = true;
                    MessageBox.Show("Lưu hoàn thành!", "Thông báo");
                   // Setup();
                    btnHuy.PerformClick();
                }
            }
        }
        private void UpdateGiadichcuoi()
        {
            var q = db.khachhangs.Where(w => w.id == Functions.ChuyenInt(txtMaKH.Text)).FirstOrDefault();
            if (q != null)
            {
                if (q.tuongtacuoi == null)
                {
                    q.tuongtacuoi = dtNgay.Value;
                }
                else
                {
                    if (q.tuongtacuoi < dtNgay.Value)
                    {
                        q.tuongtacuoi = dtNgay.Value;
                    }
                }
                db.SubmitChanges();
            }
        }
        private void Insert()
        {
            LINQ.chamsockhachhang a = new LINQ.chamsockhachhang();

            a.ngay = dtNgay.Value.Date;
            a.makh = Functions.ChuyenInt(txtMaKH.Text);          

            a.noidung = txtDichvu.Text;
            a.username = cbxNV.SelectedValue.ToString();           

            db.chamsockhachhangs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        private void UpdateData()
        {
            var a = db.chamsockhachhangs.Where(w => w.id ==Functions.ChuyenInt(lbSCT.Text)).FirstOrDefault();
            if (a != null)
            {
                a.makh = Functions.ChuyenInt(txtMaKH.Text);
               
                a.noidung = txtDichvu.Text;
                a.username = cbxNV.SelectedValue.ToString();

                db.SubmitChanges();
            }
        }

        

        private void txtMaKH_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (dgvCboUser.Visible && e.KeyCode.Equals(Keys.Tab))
            {
                dgvCboUser.Focus();
                e.IsInputKey = true;
            }
        }
        bool flag = false;
        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (flag)//kiem tra quyen khach nay khong
                {
                    txtDichvu.Focus();
                    dgvCboUser.Visible = true;
                    e.Handled = false;
                    return;
                }
                show_user_combo();
            }
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter || e.KeyData == Keys.Down)
            {
                dgvCboUser.Focus();
                if (dgvCboUser.RowCount > 0)
                {
                    dgvCboUser.CurrentCell = dgvCboUser.Rows[0].Cells[1];
                    dgvCboUser.Rows[0].Selected = true;
                }
                e.Handled = false;
            }
            if (e.KeyData == Keys.Escape)
            {
                dgvCboUser.Visible = false;
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            show_user_combo();
        }
    }
}
