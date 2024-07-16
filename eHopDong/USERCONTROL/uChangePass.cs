using Krypton.Toolkit;
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
    public partial class uChangePass : UserControl
    {
        private static uChangePass _instance;
        public static uChangePass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uChangePass();

                return _instance;
            }
        }
        public uChangePass()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            LINQ.DbDataContext mn = new LINQ.DbDataContext();
            var query = mn.nhanviens.Where(w => w.ma == PQ.UserName).FirstOrDefault();
            if (query != null)
            {
                if (query.pass == Functions.getMd5Hash(txtpassCu.Text))
                {
                    if (txtPass.Text == txtpasmoi.Text & txtPass.Text.Length > 0)
                    {
                        query.pass = Functions.getMd5Hash(txtPass.Text);
                    }
                }
                mn.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }
    }
}
