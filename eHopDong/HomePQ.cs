using eHopdong.PHUQUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong
{
    public partial class HomePQ : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Color MyBackcolor;
        Color[] color;

        // move panle 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public HomePQ()
        {
            InitializeComponent();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            PQDb.MODEL.PQDb a = new PQDb.MODEL.PQDb();
            
            //pTop.BackColor = PQ.myBgColor;
            //pLeft.BackColor = PQ.myBgColor;
            color = new Color[10];
            //color[1] = pqHome.BackColor;
            //color[2] = pqKhachhang.BackColor;
            //color[3] = pqLienhe.BackColor;
            //color[4] = pqHopdong.BackColor;
            //color[5] = pqBaocao.BackColor;
            //color[0] = pqQuantri.BackColor;
            // MyBackcolor = pqHome.BackColor;
        //    lbVersion.Text = "Version: "+PQ.Version.ToString("yyyy.MM.dd");

            btnClose.OverrideFocus.Border.Rounding = 20;
            btnClose.OverrideDefault.Border.Rounding = 20;
            btnMin.OverrideFocus.Border.Rounding = 20;
            btnMin.OverrideDefault.Border.Rounding = 20;

            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(USERCONTROL.uLogin.Instance))
            {
                pHome.Controls.Add(USERCONTROL.uLogin.Instance);
                USERCONTROL.uLogin.Instance.fhome = this;
                USERCONTROL.uLogin.Instance.Dock = DockStyle.Fill;
                USERCONTROL.uLogin.Instance.BringToFront();
                USERCONTROL.uLogin.Instance.txtUser.Focus();
            }
           
        }
        public void OkiLogin()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(USERCONTROL.uHopdong.Instance))
            {
                pHome.Controls.Add(USERCONTROL.uHopdong.Instance);
              //  USERCONTROL.uHopdong.Instance.Setup();
                USERCONTROL.uHopdong.Instance.Dock = DockStyle.Fill;
                USERCONTROL.uHopdong.Instance.BringToFront();
            }
        }

        private void pMy_Click(object sender, EventArgs e)
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(USERCONTROL.uChangePass.Instance))
            {
                pHome.Controls.Add(USERCONTROL.uChangePass.Instance);
                USERCONTROL.uChangePass.Instance.Dock = DockStyle.Fill;
                USERCONTROL.uChangePass.Instance.BringToFront();
            }
        }

       

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       

        private void pqHome_MouseLeave(object sender, EventArgs e)
        {
            int tam = Functions.ChuyenInt16(((PQButton)sender).Tag.ToString());
            MyBackcolor = color[tam];
            ((PQButton)sender).BackColor = MyBackcolor;
            ((PQButton)sender).ForeColor = Color.White;
        }

        private void pqHome_MouseHover(object sender, EventArgs e)
        {
            int tam = Functions.ChuyenInt16(((PQButton)sender).Tag.ToString());
            MyBackcolor = color[tam];


            ((PQButton)sender).BackColor = Color.White;
            ((PQButton)sender).BackgroundColor = Color.White;
            ((PQButton)sender).BorderSize = 1;
            ((PQButton)sender).BorderColor = MyBackcolor;
            ((PQButton)sender).ForeColor = MyBackcolor;
        }
        private object TimObjectHome(string ten)
        {
            for (int i = 0; i < pHome.Controls.Count; i++)
            {
                if (pHome.Controls[i].Text == ten)  
                    return pHome.Controls[i];
            }
            return null;
        }
        

        private void pqHome_Click(object sender, EventArgs e)
        {
            pHome.Controls.Clear();
            //if (!pHome.Controls.Contains(KINHDOANH.uTongquan.Instance))
            //{
            //    pHome.Controls.Add(KINHDOANH.uTongquan.Instance);
            //    KINHDOANH.uTongquan.Instance.Setup();
            //    KINHDOANH.uTongquan.Instance.Dock = DockStyle.Fill;
            //    KINHDOANH.uTongquan.Instance.BringToFront();
            //}
        }

        

        private void lbDangxuat_Click(object sender, EventArgs e)
        {
            PQ.UserName = "";
            PQ.Fullname = "";
            PQ.Permission = "";
            PQ.Bophan = "";
            //lbName.Text = "Mekong";
            //lbBophan.Text = "chưa đăng nhập";
            //lbDangxuat.Visible = false;
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(USERCONTROL.uLogin.Instance))
            {
                pHome.Controls.Add(USERCONTROL.uLogin.Instance);
                USERCONTROL.uLogin.Instance.fhome = this;
                USERCONTROL.uLogin.Instance.Dock = DockStyle.Fill;
                USERCONTROL.uLogin.Instance.BringToFront();
                USERCONTROL.uLogin.Instance.txtUser.Focus();
            }
            
        }

       

        
       
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            USERCONTROL.DLG.frm_DlgUser f = new USERCONTROL.DLG.frm_DlgUser();
            f.ShowDialog();
        }
    }
}
