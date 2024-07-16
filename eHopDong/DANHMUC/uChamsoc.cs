using eHopdong.USERCONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.DANHMUC
{
    public partial class uChamsoc : UserControl
    {
        private static uChamsoc _instance;
        public static uChamsoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uChamsoc();

                return _instance;
            }
        }
        public uChamsoc()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;

        private void btnThem_Click(object sender, EventArgs e)
        {
            PQ.ClickOK = false;
            DLG.frm_DlgHotro f = new DLG.frm_DlgHotro();
            f.ShowDialog();
            if (PQ.ClickOK)
            {
                LoadData();
            }
        }

        private void uKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            LoadCanhan();
            LoadData();
        }
        public void LoadCanhan()
        {           
            if (PQ.Permission == "0")
            {
                tinhBindingSource.DataSource = db.nhanviens.Where(w => w.ma != "phuqui").OrderBy(w => w.ten).ToList();
            }
            else if (PQ.Permission == "1")
            {
                tinhBindingSource.DataSource = db.DS_NHANVIEN_QUANLY(PQ.Bophan).OrderBy(w => w.ten).ToList();
            }
            else
            {
                tinhBindingSource.DataSource = db.nhanviens.Where(w => w.ma == PQ.UserName).OrderBy(w => w.ten).ToList();
            }
        }
        public void LoadData()
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
               var t = db.DS_CHAMSOC_ADMIN(PQ.Permission, dtTu.Value.Date, dtDen.Value.Date).Where(w => w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.tenkh.ToLower().Contains(txtSearch.Text.ToLower())).OrderByDescending(w => w.ngay).ThenByDescending(w => w.id).Select(w=>new MODEL.Chamsoc {id=w.id, username=w.username, diachi=w.diachi, makh=w.makh.ToString(), ngay=w.ngay.Value, noidung=w.noidung, tenkh=w.tenkh }).ToList();

                chamsocBindingSource.DataSource =chkAll.Checked?t:t.Where(w=>w.username==cbxDV.SelectedValue.ToString());
                username.Visible = true;
            }
            else if (PQ.Permission == "1")
            {
                var t = db.DS_CHAMSOC_QUANLY(PQ.Bophan, dtTu.Value.Date, dtDen.Value.Date).AsEnumerable().Where(w => w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.tenkh.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.tenkh).Select(w => new MODEL.Chamsoc { id = w.id, username = w.username, diachi = w.diachi, makh = w.makh.ToString(), ngay = w.ngay.Value, noidung = w.noidung, tenkh = w.tenkh }).ToList();
                chamsocBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.username == cbxDV.SelectedValue.ToString());
                 username.Visible = true;
            }
            else 
            {
                var t= db.DS_CHAMSOC_CANHAN(PQ.UserName, dtTu.Value.Date, dtDen.Value.Date).Where(w => w.username==PQ.UserName & (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.tenkh.ToLower().Contains(txtSearch.Text.ToLower()))).OrderByDescending(w => w.ngay).ThenByDescending(w => w.id).Select(w => new MODEL.Chamsoc { id = w.id, username = w.username, diachi = w.diachi, makh = w.makh.ToString(), ngay = w.ngay.Value, noidung = w.noidung, tenkh = w.tenkh }).ToList();
                chamsocBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.username == cbxDV.SelectedValue.ToString());
                  username.Visible = false;
            }

            txtSum.Text = dgv.RowCount.ToString();                
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgHotro f = new DLG.frm_DlgHotro();
                f.lbSCT.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "sotien")
                Functions.FormatNumberBold(e);
            else if (dgv.Columns[e.ColumnIndex].Name == "sotienvon")
                Functions.FormatNumber(e);
            else if (dgv.Columns[e.ColumnIndex].Name == "loinhuan")
                Functions.FormatNumberBoldColor(e, Color.Blue,true);
        }

        private void cbxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDV.SelectedValue!=null)
                LoadData();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgHotro f = new DLG.frm_DlgHotro();
                f.lbSCT.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadData();
                }
            }
        }
    }
}
