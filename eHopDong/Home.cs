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
    public partial class Home : Form
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

        public Home()
        {
            InitializeComponent();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //pTop.BackColor = PQ.myBgColor;
            //pLeft.BackColor = PQ.myBgColor;
            color = new Color[10];
            color[1] = pqHome.BackColor;
            color[2] = pqKhachhang.BackColor;
            color[3] = pqLienhe.BackColor;
            color[4] = pqHopdong.BackColor;
            color[5] = pqBaocao.BackColor;
            color[0] = pqQuantri.BackColor;
            // MyBackcolor = pqHome.BackColor;
            lbVersion.Text = "Version: "+PQ.Version.ToString("yyyy.MM.dd");

            btnClose.OverrideFocus.Border.Rounding = 20;
            btnClose.OverrideDefault.Border.Rounding = 20;
            btnMin.OverrideFocus.Border.Rounding = 20;
            btnMin.OverrideDefault.Border.Rounding = 20;

            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(USERCONTROL.uLogin.Instance))
            {
                pHome.Controls.Add(USERCONTROL.uLogin.Instance);
               // USERCONTROL.uLogin.Instance.fhome = this;
                USERCONTROL.uLogin.Instance.Dock = DockStyle.Fill;
                USERCONTROL.uLogin.Instance.BringToFront();
                USERCONTROL.uLogin.Instance.txtUser.Focus();
            }
            pqHome.Enabled = false;
            pqBaocao.Enabled = false;
            pqHopdong.Enabled = false;
            pqKhachhang.Enabled = false;
            pqLienhe.Enabled = false;
            pqQuantri.Enabled = false;
        }
        public void OkiLogin()
        {
            lbName.Text = PQ.Fullname;
            lbBophan.Text = PQ.Bophanten;

            pqHome.Enabled = true;
            pqBaocao.Enabled = true;
            pqHopdong.Enabled = true;
            pqKhachhang.Enabled = true;
            pqLienhe.Enabled = true;
            pqQuantri.Enabled = true;
            
            lbDangxuat.Visible = true;

            pqHome.PerformClick();
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
        private void pqButton2_Click(object sender, EventArgs e)
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(DANHMUC.uBaoCTV.Instance))
            {
                pHome.Controls.Add(DANHMUC.uBaoCTV.Instance);
                DANHMUC.uBaoCTV.Instance.LoadTinh();
                DANHMUC.uBaoCTV.Instance.LoadKhachhang();
                DANHMUC.uBaoCTV.Instance.Dock = DockStyle.Fill;
                DANHMUC.uBaoCTV.Instance.BringToFront();
            }
            else
            {
                var tim = TimObjectHome("uKhachhang");
                if (tim != null)
                {
                    ((DANHMUC.uBaoCTV)tim).LoadTinh();
                }
            }
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

        private void pqQuantri_Click(object sender, EventArgs e)
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(DANHMUC.uQuantri.Instance))
            {
                pHome.Controls.Add(DANHMUC.uQuantri.Instance);
                //DANHMUC.uQuantri.Instance.myhome = this;
                DANHMUC.uQuantri.Instance.Dock = DockStyle.Fill;
                DANHMUC.uQuantri.Instance.BringToFront();
            }
        }

        private void lbDangxuat_Click(object sender, EventArgs e)
        {
            PQ.UserName = "";
            PQ.Fullname = "";
            PQ.Permission = "";
            PQ.Bophan = "";
            lbName.Text = "Mekong";
            lbBophan.Text = "chưa đăng nhập";
            lbDangxuat.Visible = false;
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(USERCONTROL.uLogin.Instance))
            {
                pHome.Controls.Add(USERCONTROL.uLogin.Instance);
             //   USERCONTROL.uLogin.Instance.fhome = this;
                USERCONTROL.uLogin.Instance.Dock = DockStyle.Fill;
                USERCONTROL.uLogin.Instance.BringToFront();
                USERCONTROL.uLogin.Instance.txtUser.Focus();
            }
            pqHome.Enabled = false;
            pqBaocao.Enabled = false;
            pqHopdong.Enabled = false;
            pqKhachhang.Enabled = false;
            pqLienhe.Enabled = false;
            pqQuantri.Enabled = false;
        }

        private void pqHopdong_Click(object sender, EventArgs e)
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(DANHMUC.uHopdong.Instance))
            {
                pHome.Controls.Add(DANHMUC.uHopdong.Instance);
                DANHMUC.uHopdong.Instance.LoadData();
                DANHMUC.uHopdong.Instance.Dock = DockStyle.Fill;
                DANHMUC.uHopdong.Instance.BringToFront();
            }
            
        }

        private void pqLienhe_Click(object sender, EventArgs e)
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(DANHMUC.uChamsoc.Instance))
            {
                pHome.Controls.Add(DANHMUC.uChamsoc.Instance);
                DANHMUC.uChamsoc.Instance.LoadData();
                DANHMUC.uChamsoc.Instance.Dock = DockStyle.Fill;
                DANHMUC.uChamsoc.Instance.BringToFront();
            }
        }
        public void BaocaoNgaykyniem()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uBaongaykyniem.Instance))
            {
                pHome.Controls.Add(BAOCAO.uBaongaykyniem.Instance);
                BAOCAO.uBaongaykyniem.Instance.LoadData();
                BAOCAO.uBaongaykyniem.Instance.Dock = DockStyle.Fill;
                BAOCAO.uBaongaykyniem.Instance.BringToFront();
            }
        }
        public void BaocaoKHTiemnang()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uBaoKHTiemnang.Instance))
            {
                pHome.Controls.Add(BAOCAO.uBaoKHTiemnang.Instance);
                BAOCAO.uBaoKHTiemnang.Instance.LoadTinh();
                BAOCAO.uBaoKHTiemnang.Instance.Dock = DockStyle.Fill;
                BAOCAO.uBaoKHTiemnang.Instance.BringToFront();
            }
        }
        public void BaocaoKHNCC()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uBaoKHNCC.Instance))
            {
                pHome.Controls.Add(BAOCAO.uBaoKHNCC.Instance);
                BAOCAO.uBaoKHNCC.Instance.LoadTinh();
                BAOCAO.uBaoKHNCC.Instance.Dock = DockStyle.Fill;
                BAOCAO.uBaoKHNCC.Instance.BringToFront();
            }
        }
        public void BaocaoCongtacvien()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uBaoCTV.Instance))
            {
                pHome.Controls.Add(BAOCAO.uBaoCTV.Instance);
                BAOCAO.uBaoCTV.Instance.LoadTinh();
                BAOCAO.uBaoCTV.Instance.Dock = DockStyle.Fill;
                BAOCAO.uBaoCTV.Instance.BringToFront();
            }
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void pqBaocao_Click(object sender, EventArgs e)
        {
            BAOCAO.frm_DlgChonBaocao f = new BAOCAO.frm_DlgChonBaocao();
            PQ.iChon = 0;
            f.ShowDialog();
            if (PQ.iChon > 0)
            {
                if (PQ.iChon == 1)
                    BaocaoNgaykyniem();
                else if (PQ.iChon == 2)
                {
                    BaocaoCongtacvien();
                }
                else if (PQ.iChon == 3)
                {
                    BaocaoChamsoc();
                }
                else if (PQ.iChon == 4)
                {
                    BaocaoDoanhthu();
                }
                else if (PQ.iChon == 5)
                {
                    BaocaoKHTiemnang();
                }
                else if (PQ.iChon == 6)
                {
                    BaocaoKHNCC();
                }
            }
            
            
        }
        public void BaocaoDoanhthu()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uBaoDoanhthu.Instance))
            {
                pHome.Controls.Add(BAOCAO.uBaoDoanhthu.Instance);
                BAOCAO.uBaoDoanhthu.Instance.LoadData();
                BAOCAO.uBaoDoanhthu.Instance.Dock = DockStyle.Fill;
                BAOCAO.uBaoDoanhthu.Instance.BringToFront();
            }
        }
        public void BaocaoChamsoc()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uBaoChamsoc.Instance))
            {
                pHome.Controls.Add(BAOCAO.uBaoChamsoc.Instance);
                BAOCAO.uBaoChamsoc.Instance.LoadData();
                BAOCAO.uBaoChamsoc.Instance.Dock = DockStyle.Fill;
                BAOCAO.uBaoChamsoc.Instance.BringToFront();
            }
        }
        public void Luanchuyen()
        {
            pHome.Controls.Clear();
            if (!pHome.Controls.Contains(BAOCAO.uChuyenKH.Instance))
            {
                pHome.Controls.Add(BAOCAO.uChuyenKH.Instance);
          
                BAOCAO.uChuyenKH.Instance.Dock = DockStyle.Fill;
                BAOCAO.uChuyenKH.Instance.BringToFront();
            }
        }
    }
}
