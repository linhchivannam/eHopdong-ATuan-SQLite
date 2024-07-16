using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.BAOCAO
{
    partial class frm_DlgHopdongcanhan : Form
    {
        public frm_DlgHopdongcanhan()
        {
            InitializeComponent();
        }
        public long idkh;
        LINQ.DbDataContext db;
private void frm_DlgHopdongcanhan_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            LoadCbx();
            LoadData();
        }
        private void LoadData()
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
                var t = db.cungcapdichvus.Where(w => w.makh==idkh & (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()))).OrderByDescending(w => w.ngay).ThenByDescending(w => w.id).ToList();

                cungcapdichvuBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.nhomdichvu == cbxDV.SelectedValue.ToString());
               
            }
            

            txtSum.Text = dgv.RowCount.ToString();
            var total = dgv.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt64(t.Cells["sotien"].Value));
            txtSotien.Text = total.ToString("N0");
            txtSumloinhuan.Text = dgv.Rows.Cast<DataGridViewRow>()
                .Where(w => Functions.Obj2Bool(w.Cells["ketthuc"].Value) == true).Sum(t => Convert.ToInt64(t.Cells["loinhuan"].Value)).ToString("N0");
        }
        public void LoadCbx()
        {
            tinhBindingSource.DataSource = db.nhomdichvus.OrderBy(w => w.ten).ToList();
        }

        private void cbxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDV.SelectedValue != null)
                LoadData();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
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
           else if (dgv.Columns[e.ColumnIndex].Name == "kethucngay")
            {
                if (Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["ketthuc"].Value))
                {
                    Functions.FormatDate(e);
                }
                else
                    Functions.FormatDateNull(e);
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "ngay")
                Functions.FormatDate(e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
