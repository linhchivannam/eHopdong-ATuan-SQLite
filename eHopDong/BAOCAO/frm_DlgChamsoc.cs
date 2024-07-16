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
    partial class frm_DlgChamsoc : Form
    {
        public frm_DlgChamsoc()
        {
            InitializeComponent();
        }
        public long idkh;
        LINQ.DbDataContext db;
private void frm_DlgHopdongcanhan_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
           
            LoadData();
        }
        private void LoadData()
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
                var t = db.chamsockhachhangs.Where(w => w.makh==idkh & (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()))).OrderByDescending(w => w.ngay).ThenByDescending(w => w.id).ToList();

                chamsocBindingSource.DataSource = t;
               
            }

            txtSum.Text = dgv.RowCount.ToString();
                    
        }
       

       

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "ngay")
                Functions.FormatDate(e);
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
