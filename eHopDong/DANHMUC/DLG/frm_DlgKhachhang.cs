using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace eHopdong.DANHMUC.DLG
{
    partial class frm_DlgKhachhang : Form
    {
        public frm_DlgKhachhang()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        bool sua = false;
        public bool themoi = false;
        PHUQUI.CustomDataGridViewCombo dgvCboUser;
        string ddtam = "";

        private void frm_DlgKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            ddtam = txtGhichu.Text ;
            add_dgv_cbo_user();
            tinhBindingSource.DataSource = db.tinhs.OrderBy(w => w.ten).ToList();


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
                nhanvienBindingSource.DataSource = db.nhanviens.Where(w => w.ma == PQ.UserName).OrderBy(w => w.ten).ToList();
            }

            Setup();
            btnHuy.PerformClick();
            dgvCboUser.Visible = false;
            if (themoi)
            {
                btnThem.PerformClick();
            }
        }

        private void Setup()
        { 
            if(txtMa.Text.Trim().Length>0)
            {
                var q = db.khachhangs.Where(w=>w.id==Functions.ChuyenInt(txtMa.Text)).FirstOrDefault();
                if(q!=null)
                {
                    txtMa.Text =q.id.ToString();
                    txtTen.Text = q.ten;
                    txtDC.Text = q.diachi;
                    txtDT.Text = q.dienthoai;
                    txtChucvu.Text = q.chucvu;
                    txtEmail.Text = q.email;
                    txtFb.Text = q.facebook;
                    txtDVMa.Text = q.donvi.ToString();
                    txtDVTen.Text = q.tendonvi;
                    chkSinhnhat.Checked = q.sinhnhatco.Value;
                    chkTiemnang.Checked = q.tiemnang.Value;
                    chkCongtacvien.Checked = q.congtacvien.Value;

                    chkNhaCC.Checked =Functions.Obj2Bool(q.nhacungcap);
                    txtGhichu.Text = q.ghichu!=null? q.ghichu:"";

                    Functions.ChooseIndexLinQ(cbxNV, q.username);
                    Functions.ChooseIndexLinQ(cbxTinh, q.tinh);

                    LoadKyniem(q.id);
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
            if (!txtDVMa.ReadOnly)
            {
                dgvCboUser.Location = new Point(txtDVMa.Location.X, txtDVMa.Location.Y + txtDVMa.Height);
                dgvCboUser.Visible = true;
                dgvCboUser.BringToFront();
                dgvCboUser.DataSource = LoadKhachhang(txtDVMa.Text.ToLower());
                dgvCboUser.Columns["ma"].Width = 40;
                dgvCboUser.Columns["ten"].Width = 210;
                dgvCboUser.Columns["ten"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dgvCboUser.Columns["dienthoai"].Width = 100;
                dgvCboUser.Columns["diachi"].Width = 150;
            }
        }
        private List<MODEL.KhachhangRutgon> LoadKhachhang(string txt)
        {
            return db.coquandonvis.Where(w => w.ten.ToLower().Contains(txt)).Select(w => new MODEL.KhachhangRutgon
            { ma = w.ma.ToString(), ten = w.ten, diachi = w.diachi, dienthoai = w.dienthoai }).ToList();
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
                txtDVMa.Text = dgvCboUser.Rows[dgvCboUser.CurrentCell.RowIndex].Cells["ma"].Value.ToString();

                var k = db.coquandonvis.Where(w => w.ma == Functions.ChuyenInt(txtDVMa.Text)).FirstOrDefault();
                if (k != null)
                {
                    txtDVTen.Text = k.ten;
                }
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
                txtEmail.Focus();
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


            Functions.EnableAll(pValue); // mo len cho sai 
            Functions.NullControl(pValue); // xoa trang
            txtGhichu.Text = ddtam;
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db, this.Name, DateTime.Now.Date, "sua"))
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
            if (Functions.KiemtraQuyen(db, this.Name, DateTime.Now.Date, "xoa"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtMa.Text + "] " + txtTen.Text, "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var c = db.cungcapdichvus.Where(w=>w.makh== Functions.ChuyenInt(txtMa.Text.Trim())).Count();
                    if (c == 0)
                    {

                        var query = db.khachhangs.Where(w => w.id == Functions.ChuyenInt(txtMa.Text.Trim())).FirstOrDefault();
                        if (query != null)
                        {
                            db.khachhangs.DeleteOnSubmit(query);

                            db.SubmitChanges();
                            PQ.ClickOK = true;
                            //  Setup();
                            btnHuy.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng đã có giao dịch, không thể xóa", "Thông báo");
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
            i += Functions.CheckTexboxnotNull(txtTen);

            if (i > 0)
                return false;
            if (txtDT.Text.Trim().Length > 0)
            {
                var q = db.khachhangs.Where(w => w.dienthoai == txtDT.Text.Trim());
                if (q.Count() > 0)
                {
                    if (sua)
                    {
                        var t = q.Where(w => w.id != Functions.ChuyenInt(txtMa.Text)).FirstOrDefault();
                        if (t != null)
                        {
                            Functions.WarningTextbox(txtDT);
                            return false;
                        }
                    }
                    else
                    {
                        Functions.WarningTextbox(txtDT);
                        return false;
                    }
                }
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
                    PQ.ClickOK = true;
                    MessageBox.Show("Lưu hoàn thành!", "Thông báo");
                   // Setup();
                    btnHuy.PerformClick();
                }
            }
        }
        private void Insert()
        {
            LINQ.khachhang a = new LINQ.khachhang();
           
            a.ten = txtTen.Text;
            a.chucvu = txtChucvu.Text;
            a.diachi = txtDC.Text;
            a.dienthoai = txtDT.Text;
            a.tinh = cbxTinh.SelectedValue.ToString();
            a.username = cbxNV.SelectedValue.ToString();
            a.donvi = 0;
            a.tendonvi = txtDVTen.Text;
            a.facebook = txtFb.Text;
            a.email = txtEmail.Text;

            if (txtDVMa.Text.Trim().Length > 0)
            {
                a.donvi = Functions.ChuyenInt(txtDVMa.Text);
            }

            a.congtacvien = chkCongtacvien.Checked;
            a.ma = txtMaCTV.Text;
            a.tiemnang = chkTiemnang.Checked;
            a.sinhnhatco = chkSinhnhat.Checked;
            a.sinhnhat = dtNgay.Value.Date;

            a.tuongtacuoi = PQ.ngayhethong;

            a.ghichu = txtGhichu.Text;
            a.nhacungcap = chkNhaCC.Checked;


            db.khachhangs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        private void UpdateData()
        {
            var a = db.khachhangs.Where(w => w.id ==Functions.ChuyenInt(txtMa.Text.Trim())).FirstOrDefault();
            if (a != null)
            {
                a.ten = txtTen.Text;
                a.chucvu = txtChucvu.Text;
                a.diachi = txtDC.Text;
                a.dienthoai = txtDT.Text;
                a.tinh = cbxTinh.SelectedValue.ToString();
                a.username = cbxNV.SelectedValue.ToString();
                a.donvi = 0;
                a.tendonvi = txtDVTen.Text;

                if (txtDVMa.Text.Trim().Length > 0)
                {
                    a.donvi = Functions.ChuyenInt(txtDVMa.Text);
                }

                a.congtacvien = chkCongtacvien.Checked;
                a.ma = txtMaCTV.Text;
                a.tiemnang = chkTiemnang.Checked;
                a.sinhnhatco = chkSinhnhat.Checked;
                a.sinhnhat = dtNgay.Value.Date;
                a.facebook = txtFb.Text;
                a.email = txtEmail.Text;

                a.ghichu = txtGhichu.Text;
                a.nhacungcap = chkNhaCC.Checked;

                db.SubmitChanges();
            }
        }

        private void txtDVMa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (dgvCboUser.Visible && e.KeyCode.Equals(Keys.Tab))
            {
                dgvCboUser.Focus();
                e.IsInputKey = true;
            }
        }
        bool flag = false;
        private void txtDVMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (flag)//kiem tra quyen khach nay khong
                {
                    txtChucvu.Focus();
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

        private void txtDVMa_TextChanged(object sender, EventArgs e)
        {
            show_user_combo();
        }
        private void LoadKyniem(long id)
        {
            kyniemBindingSource.DataSource = db.kyniems.Where(w=>w.maidkh==id).AsEnumerable().OrderByDescending(w=>w.ngay);
        }
        private void mnXoa_Click(object sender, EventArgs e)
        {
            if (Functions.KiemtraQuyen(db, this.Name, DateTime.Now.Date, "xoa"))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtIdKN.Text + "] " + txtKNNoidung.Text + "\n ngày: "+dtKNNgay.Value.ToString("dd/MM/yyyy"), "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var c = db.kyniems.Where(w => w.id == Functions.ChuyenInt(txtIdKN.Text.Trim())).FirstOrDefault();
                    if (c!=null)
                    {
                        db.kyniems.DeleteOnSubmit(c);

                        db.SubmitChanges();
                        LoadKyniem(Functions.ChuyenInt(txtMa.Text.Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng đã có giao dịch, không thể xóa", "Thông báo");
                    }
                }
            }
        }

        private void btnLuuKN_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length > 0)
            {
                if (txtIdKN.Text.Trim().Length > 0)
                {
                    var a = db.kyniems.Where(w=>w.id==Functions.ChuyenInt(txtIdKN.Text)).FirstOrDefault();
                    if (a != null)
                    {
                        a.noidung = txtKNNoidung.Text;
                        a.ngay = dtKNNgay.Value;                      
                        db.SubmitChanges();
                    }
                }
                else
                {

                    LINQ.kyniem a = new LINQ.kyniem();
                    a.maidkh = Functions.ChuyenInt(txtMa.Text);
                    a.noidung = txtKNNoidung.Text;
                    a.ngay = dtKNNgay.Value;
                    db.kyniems.InsertOnSubmit(a);
                    db.SubmitChanges();
                    LoadKyniem(a.maidkh.Value);
                    txtKNNoidung.Text = "";
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            txtIdKN.Text = "";
            txtKNNoidung.Text = "";
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "ngay")
                Functions.FormatDateKyniem(e);
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDC.Focus();
        }

        private void txtDC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDVMa.Focus();
        }

        private void txtChucvu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDT.Focus();
        }

        private void txtDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFb.Focus();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if(dgv.Rows[e.RowIndex].Cells["id"].Value!=null)
                    txtIdKN.Text = dgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
            }
            catch (Exception a)
            { 
            
            }
        }
    }
}
