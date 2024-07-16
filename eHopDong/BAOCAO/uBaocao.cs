using eHopdong.DANHMUC;
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
    public partial class uBaocao : UserControl
    {
        public Home fhome;
        private static uBaocao _instance;
        public static uBaocao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uBaocao();

                return _instance;
            }
        }
        public uBaocao()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;

        private void btnNgaykyniem_Click(object sender, EventArgs e)
        {
            fhome.BaocaoNgaykyniem();
        }
    }
}
