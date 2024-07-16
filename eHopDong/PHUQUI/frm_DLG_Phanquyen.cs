using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.QUANLY
{
    partial class frm_DLG_Phanquyen : Form
    {
        LINQ.DbDataContext db = new LINQ.DbDataContext();
        string matam = "";
        public frm_DLG_Phanquyen()
        {
            InitializeComponent();           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Setup()
        {
            dgv.DataSource = db.nhomquyens.OrderBy(w => w.ma).ToList() ;
        }
        private LINQ.phanquyen TimPhanquyen(string maquyen, string form)
        {
            return db.phanquyens.Where(w=>w.form==form & w.quyen==maquyen).FirstOrDefault();
        }
        private void LoadData()
        {
            Functions.Removedgview(dgv1);
            var dsform = db.dsforms.OrderBy(w=>w.nhom).ThenBy(w=>w.tiengviet);
            foreach (var ok in dsform)
            {
                bool cp = false;
                bool s = false;
                int sngay = 0;
                bool x = false;
                int xngay = 0;
                bool t = false;
                int tngay = 0;
                var q = TimPhanquyen(matam, ok.tenform);
                if (q != null)
                {
                    cp = q.chophep.Value;
                    s = q.sua.Value;
                    sngay = q.suangay.Value;
                    x = q.xoa.Value;
                    xngay = q.xoangay.Value;
                    t = q.them.Value;
                    tngay = q.themngay.Value;
                }

                object[] row = new object[] {ok.tenform,cp,ok.nhom+" / "+ ok.tiengviet, s,sngay,x,xngay,t,tngay};
                dgv1.Rows.Add(row);
            }
        }
        private void frm_DLG_Phanquyen_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                matam = dgv.Rows[e.RowIndex].Cells["ma"].Value.ToString();
                LoadData();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgv1.RowCount > 0)
            {
                db.phanquyens.DeleteAllOnSubmit(db.phanquyens.Where(w=>w.quyen==matam));
                db.SubmitChanges();

                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    LINQ.phanquyen q = new LINQ.phanquyen();
                    q.quyen = matam;
                    q.form = dgv1.Rows[i].Cells["form"].Value.ToString();
                    q.chophep = Functions.Obj2Bool(dgv1.Rows[i].Cells["chophep"].Value);
                    q.sua = Functions.Obj2Bool(dgv1.Rows[i].Cells["sua"].Value);
                    q.suangay = Functions.ChuyenInt16(dgv1.Rows[i].Cells["suangay"].Value.ToString());
                    q.xoa = Functions.Obj2Bool(dgv1.Rows[i].Cells["xoa"].Value);
                    q.xoangay = Functions.ChuyenInt16(dgv1.Rows[i].Cells["xoangay"].Value.ToString());
                    q.them = Functions.Obj2Bool(dgv1.Rows[i].Cells["them"].Value);
                    q.themngay = Functions.ChuyenInt16(dgv1.Rows[i].Cells["themngay"].Value.ToString());
                    db.phanquyens.InsertOnSubmit(q);
                    db.SubmitChanges();
                }
            }
            MessageBox.Show("Cập nhật thành công!","Thông báo");
        }
    }
}
