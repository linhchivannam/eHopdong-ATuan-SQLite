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
    public partial class uQuantri : UserControl
    {
        private static uQuantri _instance;
        public static uQuantri Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uQuantri();

                return _instance;
            }
        }
        public uQuantri()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        public HomePQ myhome;

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            frm_Tinh f = new frm_Tinh();
            f.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (PQ.Permission == "0")
            {
                frm_Phongban f = new frm_Phongban();
                f.ShowDialog();
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            frm_Donvi f = new frm_Donvi();
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PQ.Permission == "0")
            {
                frm_Nhanvien f = new frm_Nhanvien();
                f.ShowDialog();
            }
        }

        private void uQuantri_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPhuQui_Click(object sender, EventArgs e)
        {
            if (PQ.UserName == "phuqui")
            {
                PHUQUI.DlgDieukhien f = new PHUQUI.DlgDieukhien();
                f.ShowDialog();
            }
        }

        private void btnPhanquyen_Click(object sender, EventArgs e)
        {
            if (PQ.Permission == "0")
            {
                QUANLY.frm_DLG_Phanquyen f = new QUANLY.frm_DLG_Phanquyen();
                f.ShowDialog();
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (PQ.Permission == "0")
            {
                myhome.Luanchuyen();
            }
        }
    }
}
