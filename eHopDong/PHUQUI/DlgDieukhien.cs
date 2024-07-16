using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.PHUQUI
{
    partial class DlgDieukhien : Form
    {
        public DlgDieukhien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHUQUI.frm_DlgVersion f = new frm_DlgVersion();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PHUQUI.DANHSACHFORM f = new DANHSACHFORM();
            f.ShowDialog();
        }
    }
}
