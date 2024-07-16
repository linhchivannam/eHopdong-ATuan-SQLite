using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.BAOCAO
{
    public partial class uBaongaykyniem : UserControl
    {
        private static uBaongaykyniem _instance;
        public static uBaongaykyniem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uBaongaykyniem();

                return _instance;
            }
        }
        public uBaongaykyniem()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        public void LoadData()
        {
            dgv.MultiSelect = false;
            if (PQ.Permission == "0")
            {
                dgv.MultiSelect = true;
                var t = db.DS_NGAYKYNIEM_ADMIN(dtTu.Value.Date, dtDen.Value.Date).Where(w => (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.ten.ToLower().Contains(txtSearch.Text.ToLower()))).ToList();

                dSNGAYKYNIEMADMINResultBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.username == cbxDV.SelectedValue.ToString());
                username.Visible = true;
            }
            else if (PQ.Permission == "1")
            {
                var t = db.DS_NGAYKYNIEM_QUANLY(PQ.Bophan, dtTu.Value.Date, dtDen.Value.Date).AsEnumerable().Where(w =>  (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.ten.ToLower().Contains(txtSearch.Text.ToLower()))).ToList();
                dSNGAYKYNIEMADMINResultBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.username == cbxDV.SelectedValue.ToString());
                username.Visible = true;
            }
            else
            {
                var t = db.DS_NGAYKYNIEM_CANHAN(PQ.UserName, dtTu.Value.Date, dtDen.Value.Date).Where(w =>  (w.noidung.ToLower().Contains(txtSearch.Text.ToLower()) || w.ten.ToLower().Contains(txtSearch.Text.ToLower()))).ToList();
                dSNGAYKYNIEMADMINResultBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.username == cbxDV.SelectedValue.ToString());
                username.Visible = false;
            }

            txtSum.Text = dgv.RowCount.ToString();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "ngay")
            {                
                    Functions.FormatDate(e);
            }
        }

        private void uBaongaykyniem_Load(object sender, EventArgs e)
        {
            dtDen.Value = dtDen.Value.AddDays(7);
            db = new LINQ.DbDataContext();
            LoadTinh();
            LoadData();
        }
        public void LoadTinh()
        {            
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
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
