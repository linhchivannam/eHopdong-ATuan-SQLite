using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.DLG
{
    partial class frm_BaocaoCapnhat : Form
    {
        LINQ.DbDataContext db;
        public frm_BaocaoCapnhat()
        {
            InitializeComponent();
        }

        private void frm_BaocaoCapnhat_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            var ver = db.versions.OrderByDescending(w=>w.ngay).FirstOrDefault();
            if (ver != null)
            {
                txtNoidung.Text = ver.noidung;               
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn1_Click(object sender, EventArgs e)
        {
            //string thumuc = @"\\Server0\2020\VANPHONG\";
            //System.Diagnostics.Process.Start("explorer.exe", thumuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
        }
    }
}
