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
    public partial class uBaoCTV : UserControl
    {
        private static uBaoCTV _instance;
        public static uBaoCTV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uBaoCTV();

                return _instance;
            }
        }
        public uBaoCTV()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;

        private void btnThem_Click(object sender, EventArgs e)
        {
            PQ.ClickOK = false;
            DLG.frm_DlgKhachhang f = new DLG.frm_DlgKhachhang();
            f.themoi = true;
            f.ShowDialog();
            if (PQ.ClickOK)
            {
                LoadKhachhang();
            }
        }

        private void uKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            LoadTinh();
            LoadKhachhang();
        }
        public void LoadTinh()
        {
            tinhBindingSource.DataSource = db.tinhs.OrderBy(w=>w.ten).ToList();
        }
        public void LoadKhachhang()
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
               var t = db.khachhangs.Where(w => w.ten.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.ten).ToList().OrderBy(w=>w.tendonvi).ThenBy(w=>w.ten);
                khachhangBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.tinh == cbxTinh.SelectedValue.ToString());
                mnHoptacdv.Visible = true;
            }
            else if (PQ.Permission == "1")
            {
                var t = db.DS_KHACHHANG_QUANLY(PQ.Bophan).AsEnumerable().Where(w => w.ten.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.ten).ToList().OrderBy(w => w.tendonvi).ThenBy(w => w.ten);
                khachhangBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.tinh == cbxTinh.SelectedValue.ToString());
                mnHoptacdv.Visible = true;
            }
            else 
            {
                var t = db.khachhangs.Where(w => w.username==PQ.UserName & w.ten.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.ten).ToList().OrderBy(w => w.tendonvi).ThenBy(w => w.ten);
                khachhangBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.tinh == cbxTinh.SelectedValue.ToString());
                mnHoptacdv.Visible = false;
            }
            txtSum.Text = dgv.RowCount.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgKhachhang f = new DLG.frm_DlgKhachhang();
                f.txtMa.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadKhachhang();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadKhachhang();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "sinhnhat")
            {
                if (Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["sinhnhatco"].Value))
                {
                    Functions.FormatDateKyniem(e);
                }
                else
                    Functions.FormatDateNull(e);
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "ngaycuoi" || dgv.Columns[e.ColumnIndex].Name == "tuongtacuoi")
            {
                Functions.FormatDate(e);
            }
        }

        private void cbxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTinh.SelectedValue!=null)
                LoadKhachhang();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadKhachhang();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgHopdong f = new DLG.frm_DlgHopdong();
                f.txtMaKH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.txtTenKH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["ten"].Value.ToString();
                f.txtDiachi.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["diachi"].Value.ToString();
                f.txtDT.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["dienthoai"].Value.ToString();
                f.ShowDialog();                
            }
        }

        private void btnLienhe_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgHotro f = new DLG.frm_DlgHotro();
                f.txtMaKH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.txtTenKH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["ten"].Value.ToString();
                f.txtDiachi.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["diachi"].Value.ToString();
                f.txtDT.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["dienthoai"].Value.ToString();
                f.ShowDialog();
               
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgKhachhang f = new DLG.frm_DlgKhachhang();
                f.txtMa.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadKhachhang();
                }
            }
        }

        private void mnThongtin_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgKhachhang f = new DLG.frm_DlgKhachhang();
                f.txtMa.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadKhachhang();
                }
            }
        }

        private void mnHoptac_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            { 
            BAOCAO.frm_DlgHopdongcanhan f = new BAOCAO.frm_DlgHopdongcanhan();
            f.idkh = Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString());
                f.ShowDialog();
        }
        }

        private void mnChamsoc_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                BAOCAO.frm_DlgChamsoc f = new BAOCAO.frm_DlgChamsoc();
                f.idkh = Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString());
                f.ShowDialog();
            }
        }

        private void mnHoptacdv_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                if (dgv.Rows[dgv.CurrentCell.RowIndex].Cells["donvi"].Value != null)
                {
                    BAOCAO.frm_DlgHopdongDonvi f = new BAOCAO.frm_DlgHopdongDonvi();
                    f.idkh = Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["donvi"].Value.ToString());
                    f.title = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["tendonvi"].Value.ToString();
                    f.ShowDialog();
                }
            }
        }
    }
}
