using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.USERCONTROL.DLG
{
    partial class frm_DlgHopdong : Form
    {
        public frm_DlgHopdong()
        {
            InitializeComponent();
        }
        PQDb.MODEL.PQDb db;
       public long myid=0;
        bool sua = false;
        private void frm_DlgHopdong_Load(object sender, EventArgs e)
        {
            db = new PQDb.MODEL.PQDb();
            Setup();
            btnHuy.PerformClick();
        }
        private void Setup()
        {
            if (myid > 0)
            {
                var q = db.Get1Hopdong(myid.ToString());
                if (q != null)
                {
                    txtHDso.Text = q.Sohopdong;
                    txtGhichu.Text = q.Ghichu;
                    txtNoidung.Text = q.Noidung;
                    dtNgay.Value = q.Ngay;
                    dtbatdau.Value = q.Batdau;
                    dtKetthuc.Value = q.Ketthuc;

                    txtKHDiachi.Text = q.Diachi;
                    txtKhDienthoai.Text =q.Dienthoai;
                    txtKHma.Text = q.Ma;
                    txtKHten.Text = q.Ten;
                    txtKHSoTK.Text = q.Sotaikhoan;
                    txtKHMST.Text = q.Masothue;
                    txtKHNH.Text = q.Taikhoannganhang;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            sua = false;
            //dgv.Enabled = false;
           

            Functions.EnableAll(pValue); // mo len cho sai 
            Functions.NullControl(pValue); // xoa trang

            txtHDso.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            Functions.EnableAll(pValue);
            // dgv.Enabled = false;
            sua = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xoá  " + "[" + txtHDso.Text + "] " + txtNoidung.Text + ": \n" + txtKHten.Text, "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    db.DeleteHopdong(myid);
                    PQ.ClickOK = true;
                    //  Setup();
                    btnHuy.PerformClick();
                }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;


            // dgv.Enabled = true;
            Functions.DisableAll(pValue);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check_NoExist())
            {
                bool fl = true;
                if (sua)
                {

                    db.UpdateHopdong(myid,txtHDso.Text,dtNgay.Value.Date, txtNoidung.Text,dtbatdau.Value.Date, dtKetthuc.Value.Date, Functions.ChuyenDouble(txtSotien.Text),txtGhichu.Text,txtKHma.Text,txtKHten.Text,txtKHDiachi.Text, txtKhDienthoai.Text,txtKHMST.Text,txtKHNH.Text,txtKHSoTK.Text);
                   
                }
                else
                {

                    db.InsertHopdong( txtHDso.Text, dtNgay.Value.Date, txtNoidung.Text, dtbatdau.Value.Date, dtKetthuc.Value.Date, Functions.ChuyenDouble(txtSotien.Text), txtGhichu.Text, txtKHma.Text, txtKHten.Text, txtKHDiachi.Text, txtKhDienthoai.Text, txtKHMST.Text, txtKHNH.Text, txtKHSoTK.Text);

                }

                if (fl)
                {
                   
                    PQ.ClickOK = true;
                    MessageBox.Show("Lưu hoàn thành!", "Thông báo");
                    // Setup();
                    btnHuy.PerformClick();
                }
            }
        }
        private bool Check_NoExist()
        {
            int i = 0;
            i += Functions.CheckTexboxnotNull(txtKHten);

            if (i > 0)
                return false;

            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSotien_TextChanged(object sender, EventArgs e)
        {
            Functions.CustomNumberFormat(txtSotien);
        }
        private void XuatHopDong()
        {
            object fileName = @Application.StartupPath+"\\filehd.docx";
            object fileName2 = @Application.StartupPath + "\\hdok.docx";
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;

            // create instance of Word
            Microsoft.Office.Interop.Word.Application oWordApp = new Microsoft.Office.Interop.Word.Application();


            // Create instance of Word document
            Microsoft.Office.Interop.Word.Document oWordDoc = new Microsoft.Office.Interop.Word.Document();


            // Open word document.
            oWordDoc = oWordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
            ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing);

            oWordDoc.Activate();

            //// Debug to see that I can write to the document.
            //oWordApp.Selection.TypeText("This is the text that was written from the C# program! ");
            //oWordApp.Selection.TypeParagraph();


            // Example of writing to bookmarks each bookmark will have exists around it to avoid null.
            if (oWordDoc.Bookmarks.Exists("tencty"))
            {
                // set value for bookmarks           
                object oBookMark = "tencty";
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = txtKHten.Text;

                //oBookMark = "sotienchu";
                //oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = VND.Convert(PQFunctions.ChuyenDouble(txtSotien.Text));
            }
            if (oWordDoc.Bookmarks.Exists("diachi"))
            {
                // set value for bookmarks           
                object oBookMark = "diachi";
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = txtKHDiachi.Text;

                //oBookMark = "sotienchu";
                //oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = VND.Convert(PQFunctions.ChuyenDouble(txtSotien.Text));
            }
            oWordDoc.SaveAs2(fileName2);
            // Save the document.
            // oWordApp.Documents.Save(ref missing, ref missing);


            // Close the application.
            oWordApp.Application.Quit(ref missing, ref missing, ref missing);
            MessageBox.Show("Chỉnh xong rồi nhe");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            XuatHopDong();
        }
    }
}
