﻿using eHopdong.USERCONTROL;
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
    public partial class uChuyenKH : UserControl
    {
        private static uChuyenKH _instance;
        public static uChuyenKH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uChuyenKH();

                return _instance;
            }
        }
        public uChuyenKH()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;

        private void uKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            LoadTinh();
            LoadKhachhang();
        }
        public void LoadTinh()
        {
            tinhBindingSource.DataSource = db.tinhs.OrderBy(w=>w.ten).ToList();
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
        public void LoadKhachhang()
        {
            db = new LINQ.DbDataContext();
            dgv.MultiSelect = false;
            if (PQ.Permission == "0")
            {
                dgv.MultiSelect = true;
                var t = db.khachhangs.Where(w => w.ten.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.ten).ToList().OrderBy(w=>w.tendonvi).ThenBy(w=>w.ten);
                var t1 = chkAll.Checked ? t : t.Where(w => w.tinh == cbxTinh.SelectedValue.ToString());
                
                    khachhangBindingSource.DataSource = chkNV.Checked ? t1 : t1.Where(w => w.username == cbxNhanvien.SelectedValue.ToString());
                
                mnHoptacdv.Visible = true;
            }
            else if (PQ.Permission == "1")
            {
                var t = db.DS_KHACHHANG_QUANLY(PQ.Bophan).AsEnumerable().Where(w => w.ten.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.ten).ToList().OrderBy(w => w.tendonvi).ThenBy(w => w.ten);
                var t1 = chkAll.Checked ? t : t.Where(w => w.tinh == cbxTinh.SelectedValue.ToString());

                khachhangBindingSource.DataSource = chkNV.Checked ? t1 : t1.Where(w => w.username == cbxNhanvien.SelectedValue.ToString());
                mnHoptacdv.Visible = true;
            }
            else 
            {
                var t = db.khachhangs.Where(w =>  w.username==PQ.UserName & w.ten.ToLower().Contains(txtSearch.Text.ToLower())).OrderBy(w => w.ten).ToList().OrderBy(w => w.tendonvi).ThenBy(w => w.ten);               
                khachhangBindingSource.DataSource = chkAll.Checked ? t : t.Where(w => w.tinh == cbxTinh.SelectedValue.ToString());
                mnHoptacdv.Visible = false;
            }

            txtSum.Text = dgv.RowCount.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadKhachhang();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "sinhnhat")
            {
                if (Functions.Obj2Bool(dgv.Rows[e.RowIndex].Cells["sinhnhatco"].Value))
                {
                    Functions.FormatDateKyniem(e);
                }
                else
                    Functions.FormatDateNull(e);
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "ngaycuoi" || dgv.Columns[e.ColumnIndex].Name == "tuongtacuoi")
            {
                Functions.FormatDate(e);
            }
        }

        private void cbxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTinh.SelectedValue!=null)
                LoadKhachhang();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadKhachhang();
        }

        

       

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DANHMUC.DLG.frm_DlgKhachhang f = new DANHMUC.DLG.frm_DlgKhachhang();
                f.txtMa.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadKhachhang();
                }
            }
        }

        private void mnThongtin_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                PQ.ClickOK = false;
                DANHMUC.DLG.frm_DlgKhachhang f = new DANHMUC.DLG.frm_DlgKhachhang();
                f.txtMa.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                f.ShowDialog();
                if (PQ.ClickOK)
                {
                    LoadKhachhang();
                }
            }
        }

        private void mnHoptac_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            { 
            BAOCAO.frm_DlgHopdongcanhan f = new BAOCAO.frm_DlgHopdongcanhan();
            f.idkh = Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString());
                f.ShowDialog();
        }
        }

        private void mnChamsoc_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                BAOCAO.frm_DlgChamsoc f = new BAOCAO.frm_DlgChamsoc();
                f.idkh = Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["id"].Value.ToString());
                f.ShowDialog();
            }
        }

        private void mnHoptacdv_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                if (dgv.Rows[dgv.CurrentCell.RowIndex].Cells["donvi"].Value != null)
                {
                    BAOCAO.frm_DlgHopdongDonvi f = new BAOCAO.frm_DlgHopdongDonvi();
                    f.idkh = Functions.ChuyenInt(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["donvi"].Value.ToString());
                    f.title = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["tendonvi"].Value.ToString();
                    f.ShowDialog();
                }
            }
        }

        private void cbxNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNhanvien.SelectedValue != null)
                LoadKhachhang();
        }

        private void chkNV_CheckedChanged(object sender, EventArgs e)
        {
            LoadKhachhang();
        }
        private IList<long> Tinhtoanchuyen()
        {
            if (dgv.RowCount > 0)
            {
                IList<long> arr = new List<long>();
                arr.Clear();
                string chuoi = "";
               

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv.Rows[i].Cells["chon"].Value))
                    {
                       arr.Add(Convert.ToInt64(dgv.Rows[i].Cells["id"].Value));
                    }
                }
                
                if (arr.Count > 0)
                {
                    foreach (var ok in arr)
                    {
                        chuoi += ok + ",";
                    }
                    chuoi = chuoi.Substring(0, chuoi.Length - 1);
                }
                return arr;
            }
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var arr = Tinhtoanchuyen();
            if (arr.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn chuyển  " + "[" + arr.Count.ToString() + "] " + " Khách hàng sang tài khoản nhân viên khác", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DLG.frm_DlgChuyenKhach f = new DLG.frm_DlgChuyenKhach();
                    f.arr = arr;
                    PQ.ClickOK = false;
                    f.ShowDialog();
                    if (PQ.ClickOK)
                    {
                        db = new LINQ.DbDataContext();
                        LoadKhachhang();
                    }
                }
            }
        }
    }
}
