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
    partial class frm_DlgChonBaocao : Form
    {
        public frm_DlgChonBaocao()
        {
            InitializeComponent();
        }

        private void btnNgaykyniem_Click(object sender, EventArgs e)
        {
            PQ.iChon = 1;// ngay ky niem            
            this.Close();
        }

        private void pqButton1_Click(object sender, EventArgs e)
        {
            PQ.iChon = 2;// cong tac vien           
            this.Close();
        }

        private void pqButtonRight2_Click(object sender, EventArgs e)
        {
            PQ.iChon = 3;// cham soc khach hang          
            this.Close();
        }

        private void pqButtonRight1_Click(object sender, EventArgs e)
        {
            PQ.iChon = 4;// doanh thu - loi nhuan          
            this.Close();
        }

        private void pqButton2_Click(object sender, EventArgs e)
        {
            PQ.iChon = 5;// khách hàng tiềm năng          
            this.Close();
        }

        private void pqButtonRight3_Click(object sender, EventArgs e)
        {
            PQ.iChon = 6;// khách hàng nhà cung cấp          
            this.Close();
        }
    }
}
