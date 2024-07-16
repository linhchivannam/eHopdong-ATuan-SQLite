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
    partial class frm_DlgDoanhthuBang : Form
    {
        public frm_DlgDoanhthuBang()
        {
            InitializeComponent();
        }
        public List<MODEL.BCDoanhthuloinhuan> ds;
        private void frm_DlgChamsocBang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            int i = 1;
            foreach(var ok in  ds.OrderByDescending(w=>w.loinhuan))
            {
                ok.sott = i;
                i++;
            }
            bCDoanhthuloinhuanBindingSource.DataSource = ds.OrderBy(w=>w.sott);
            txtSumloinhuan.Text = ds.Sum(w=>w.loinhuan).ToString("N0");
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 1)
                Functions.FormatNumber(e);
        }
    }
}
