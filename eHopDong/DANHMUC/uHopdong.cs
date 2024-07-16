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
    public partial class uHopdong : UserControl
    {
        private static uHopdong _instance;
        public static uHopdong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uHopdong();

                return _instance;
            }
        }
        public uHopdong()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;

        private void btnThem_Click(object sender, EventArgs e)
        {
            PQ.ClickOK = false;
            DLG.frm_DlgHopdong f = new DLG.frm_DlgHopdong();
            f.ShowDialog();
            if (PQ.ClickOK)
            {
                LoadData();
            }
        }

        private void uKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            LoadTinh();
            LoadData();
        }
        public void LoadTinh()
        {
            tinhBindingSource.DataSource = db.nhomdichvus.OrderBy(w=>w.ten).ToList();
        }
        public void LoadData()
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
               var t = db.DS_DICHVU_ADMIN(dtTu.Value.Date, dtDen.Value.Date).Where(w => w.ketthuc.Value==false || (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.tenkh.ToLower().Contains(txtSearch.Text.ToLower()))).OrderByDescending(w => w.ngay).ThenByDescending(w => w.id).ToList();

                dSDICHVUCANHANResultBindingSource.DataSource =chkAll.Checked?t:t.Where(w=>w.nhomdichvu==cbxDV.SelectedValue.ToString());
                phutrach.Visible = true;
            }
            else if (PQ.Permission == "1")
            {
                var t = db.DS_DICHVU_QUANLY(PQ.Bophan, dtTu.Value.Date, dtDen.Value.Date).AsEnumerable().Where(w => w.ketthuc.Value == false || (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.tenkh.ToLower().Contains(txtSearch.Text.ToLower()))).OrderBy(w => w.tenkh).ToList();
                dSDICHVUCANHANResultBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.nhomdichvu == cbxDV.SelectedValue.ToString());
                phutrach.Visible = true;
            }
            else 
            {
                var t= db.DS_DICHVU_CANHAN(PQ.UserName, dtTu.Value.Date, dtDen.Value.Date).Where(w =>  w.phutrach==PQ.UserName & (w.ketthuc.Value == false ||  w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.tenkh.ToLower().Contains(txtSearch.Text.ToLower()))).OrderByDescending(w => w.ngay).ThenByDescending(w => w.id).ToList();
                dSDICHVUCANHANResultBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.nhomdichvu == cbxDV.SelectedValue.ToString());
                phutrach.Visible = false;
            }

            txtSum.Text = dgv.RowCount.ToString();
            var total = dgv.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt64(t.Cells["sotien"].Value));
            txtSotien.Text = total.ToString("N0");
            txtSumloinhuan.Text = dgv.Rows.Cast<DataGridViewRow>()
                .Where(w=>Functions.Obj2Bool(w.Cells["ketthuc"].Value)==true).Sum(t => Convert.ToInt64(t.Cells["loinhuan"].Value)).ToString("N0");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgHopdong f = new DLG.frm_DlgHopdong();
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
            {
                if (Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["ketthuc"].Value))
                    Functions.FormatNumberBoldColor(e, Color.Blue, true);
                else
                    Functions.FormatDateNull(e);
            }
          else  if (dgv.Columns[e.ColumnIndex].Name == "kethucngay")
            {
                if (Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["ketthuc"].Value))
                {
                    Functions.FormatDate(e);
                }
                else
                    Functions.FormatDateNull(e);
            }
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

        private void btnHD_Click(object sender, EventArgs e)
        {

        }

        private void txtSotien_TextChanged(object sender, EventArgs e)
        {
            Functions.CustomNumberFormat(txtSotien);
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
                DLG.frm_DlgHopdong f = new DLG.frm_DlgHopdong();
                f.lbSCT.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadData();
                }
            }
        }

        private void txtSumloinhuan_TextChanged(object sender, EventArgs e)
        {
            Functions.CustomNumberFormat(txtSumloinhuan);
        }
    }
}
