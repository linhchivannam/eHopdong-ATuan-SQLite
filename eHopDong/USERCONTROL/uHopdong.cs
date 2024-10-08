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

namespace eHopdong.USERCONTROL
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
        PQDb.MODEL.PQDb db;
        List<PQDb.MODEL.Hopdong> ds;

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
            dtTu.Value = DateTime.Now.AddDays(-10);
            dtDen.Value = DateTime.Now.AddDays(10);
            db = new PQDb.MODEL.PQDb();
            ds = new List<PQDb.MODEL.Hopdong>();
            LoadData();
        }
       
        public void LoadData()
        {
            ds.Clear();
            var t1 = db.GetHopdong("").OrderBy(w=>w.Batdau);
            ds.AddRange(t1);
            var t = ds.Where(w =>w.Batdau.Date>=dtTu.Value.Date & w.Batdau.Date<=dtDen.Value.Date & (w.Noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.Ten.ToLower().Contains(txtSearch.Text.ToLower()))).OrderBy(w => w.Batdau).ThenByDescending(w => w.Id).ToList();

            hopdongBindingSource.DataSource = t;

            txtSum.Text = dgv.RowCount.ToString();
           // var total = dgv.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt64(t.Cells["sotien"].Value));
            txtSotien.Text = t.Sum(w=>w.Sotien).ToString("N0");
           
        }
        private void Search()
        {
            var t = ds.Where(w => w.Batdau.Date >= dtTu.Value.Date & w.Batdau.Date <= dtDen.Value.Date & (w.Noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.Ten.ToLower().Contains(txtSearch.Text.ToLower()))).OrderBy(w => w.Batdau).ThenByDescending(w => w.Id).ToList();

            hopdongBindingSource.DataSource = t;

            txtSum.Text = dgv.RowCount.ToString();
            // var total = dgv.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt64(t.Cells["sotien"].Value));
            txtSotien.Text = t.Sum(w => w.Sotien).ToString("N0");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DLG.frm_DlgHopdong f = new DLG.frm_DlgHopdong();
                f.myid=Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "Sotien")
                Functions.FormatNumberBold(e);
           
            else  if (dgv.Columns[e.ColumnIndex].Name == "Ngay" || dgv.Columns[e.ColumnIndex].Name == "Ketthuc" || dgv.Columns[e.ColumnIndex].Name == "Batdau")
            {
               
                Functions.FormatDate(e);
               
            }
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
                //DLG.frm_DlgHopdong f = new DLG.frm_DlgHopdong();
                //f.lbSCT.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                //f.ShowDialog();
                //if (PQ.ClickOK)
                //{
                //    LoadData();
                //}
            }
        }

       
    }
}
