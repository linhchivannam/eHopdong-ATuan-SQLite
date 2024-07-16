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
    partial class frm_DlgChamsocBang : Form
    {
        public frm_DlgChamsocBang()
        {
            InitializeComponent();
        }
        public List<MODEL.BCChamsoc> ds;
        private void frm_DlgChamsocBang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            int i = 1;
            foreach(var ok in  ds.OrderByDescending(w=>w.sokh))
            {
                ok.sott = i;
                i++;
            }
            bCChamsocBindingSource.DataSource = ds.OrderBy(w=>w.sott);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 1)
                Functions.FormatNumber(e);
        }
    }
}
