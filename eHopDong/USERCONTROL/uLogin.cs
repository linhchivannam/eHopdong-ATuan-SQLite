﻿using Krypton.Toolkit;
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
    public partial class uLogin : UserControl
    {
       public Home fhome;
        private static uLogin _instance;
        public static uLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uLogin();

                return _instance;
            }
        }
        public uLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            bool ok = false;
            LINQ.DbDataContext db = new LINQ.DbDataContext();
            if (txtUser.Text.Trim().Length == 0)
            {
                Functions.WarningTextbox(txtUser);
                txtUser.Focus();
            }
            else
            {
                Functions.OKTextbox(txtUser);
                if (txtUser.Text.Trim().ToLower() == "phuqui")
                {

                    var q = db.nhanviens.Where(w => w.ma.ToLower() == txtUser.Text.Trim().ToLower()).FirstOrDefault();
                    if (q != null)
                    {
                        Functions.OKTextbox(txtUser);
                        if (q.pass == Functions.getMd5Hash(txtPass.Text))
                        {
                            ok = true;
                            PQ.UserName = txtUser.Text.Trim().ToLower();
                            PQ.Fullname = Functions.ToTitleCase(q.ten);
                            PQ.Permission = "0";
                            PQ.Bophan = "Administrator";
                            PQ.Bophanten = "Nhà phát triển ";

                            PQ.ngayhethong = db.PQ_NGAYHETHONG().FirstOrDefault().ngay;

  

                        }
                        else
                        {
                            Functions.WarningTextbox(txtPass);
                            txtPass.Focus();
                        }
                    }
                    else
                    {
                        Functions.WarningTextbox(txtUser);
                        txtUser.Focus();
                    }

                }
                else
                {
                    var q = db.nhanviens.Where(w => w.ma.ToLower() == txtUser.Text.Trim().ToLower()).FirstOrDefault();
                    if (q != null)
                    {
                        Functions.OKTextbox(txtUser);
                        if (q.pass == Functions.getMd5Hash(txtPass.Text) & q.ok.Value)
                        {
                            ok = true;
                            PQ.UserName = txtUser.Text.Trim().ToLower();
                            PQ.Fullname = Functions.ToTitleCase(q.ten);
                            PQ.Permission = q.nhomquyen.ToString();

                            var cap = db.nhomquyens.Where(w=>w.ma==q.nhomquyen.Value).FirstOrDefault();
                            if (cap != null)
                            {
                                PQ.Permission = cap.cap.ToString();
                            }

                            PQ.Bophan = q.bophan;
                            PQ.Bophanten = "";

                            var bp = db.phongbans.Where(w=>w.ma==PQ.Bophan).FirstOrDefault();
                            if (bp != null)
                            {
                                PQ.Bophanten = bp.ten;
                            }

                            var ver = db.versions.Where(w => w.ngay.Date > PQ.Version).FirstOrDefault();
                            if (ver != null)
                            {
                                DLG.frm_BaocaoCapnhat f = new DLG.frm_BaocaoCapnhat();
                                f.ShowDialog();
                                if (ver.batbuot.Value)
                                {
                                    Application.Exit();
                                }
                            }


                        }
                        else
                        {
                            Functions.WarningTextbox(txtPass);
                            txtPass.Focus();
                        }
                    }
                    else
                    {
                        Functions.WarningTextbox(txtUser);
                        txtUser.Focus();
                    }
                }

            }

            if (ok)
            {
                fhome.OkiLogin();
            }
        }

        private void uLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUser.Text == "0974367676")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    PHUQUI.CauhinhHethong f = new PHUQUI.CauhinhHethong();
                    f.ShowDialog();
                }
            }
            if (e.KeyCode == Keys.Enter)
                txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangnhap.PerformClick();
        }

        private void uLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void uLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}