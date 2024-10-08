using Krypton.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong
{
    
     class Functions
    {
        static public void Removedgview(DataGridView dgview)
        {
            //dgview.AllowUserToAddRows = true;
            // dgview.AllowUserToDeleteRows = true;
            int rowCount = dgview.RowCount - 1;
            for (int i = rowCount; i >= 0; i--)
            {
                dgview.Rows.RemoveAt(i);

            }
        }
        static public void RemovedgviewAtPos(DataGridView dgview, int pos)
        {
            for (int i = (dgview.RowCount - 1); i >= 0; i--)
            {
                if (i == pos)
                    dgview.Rows.RemoveAt(i);
            }
        }
        public static DateTime String2Date(string txt)
        {

            string[] ngay;
            ngay = txt.Split('/');
            return Convert.ToDateTime((ngay[1] + "/" + ngay[0] + "/" + ngay[2]));
        }
        public static string ToTitleCase(string mText)
        {
            string rText = "";
            mText = mText.ToLower();
            try
            {
                System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Globalization.TextInfo TextInfo = cultureInfo.TextInfo;
                rText = TextInfo.ToTitleCase(mText);
            }
            catch
            {
                rText = mText;
            }
            return rText;
        }
        public static bool Obj2Bool(object obj)
        { 
            if(obj != null)
                return Convert.ToBoolean(obj);
            return false;
        }
        public static string GetDefaultPrinter()
        {
            PrinterSettings printerSettings = new PrinterSettings();
            IEnumerator enumerator = PrinterSettings.InstalledPrinters.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    string result = (printerSettings.PrinterName = (string)enumerator.Current);
                    if (printerSettings.IsDefaultPrinter)
                    {
                        return result;
                    }
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
            return string.Empty;
        }
        public static decimal ChuyenDecimal(string so)
        {
            if (so == null)
                return 0;

            if (IsNumber(so.ToString()))
            {
                return Convert.ToDecimal(so.ToString());

            }
            else
                return 0;

        }
        public static double ChuyenDouble(string so)
        {
            if (so == null)
                return 0;

            if (IsNumber(so.ToString()))
            {
                return Convert.ToDouble(so.ToString());

            }
            else
                return 0;

        }
        public static long ChuyenInt(string so)
        {
            if (IsNumber(so))
            {
                return Convert.ToInt64(Num2Str(so));

            }
            else
                return 0;

        }
        public static int ChuyenInt16(string so)
        {
            if (IsNumber(so))
            {
                return Convert.ToInt16(Num2Str(so));

            }
            else
                return 0;

        }
        static public int CheckTexboxnotNull(TextBox t)
        {
            if (t.Text.Trim().Length > 0)
            {
                OKTextbox(t);
                return 0;
            }
            else
            {
                WarningTextbox(t);
                return 1;
            }
        }
        static public void WarningTextbox(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.Yellow;
            txt.Focus();
        }

        static public void OKTextbox(TextBox txt)
        {
            txt.BackColor = System.Drawing.SystemColors.Window;
        }
        //public static bool KiemtraQuyen( LINQ.DbDataContext db,string myform, DateTime ngay, string action)
        //{
        //    bool rs = false;

        //    TimeSpan Time = PQ.ngayhethong - ngay;
        //    int TongSoNgay = Time.Days;
        //    if (PQ.Permission == "0")
        //        return true;
        //   // return true;
        //    var q = db.nhanviens.Where(w => w.ma.ToLower() == PQ.UserName.ToLower()).FirstOrDefault();
        //    if (q != null)
        //    {
        //        var tim = db.phanquyens.Where(w => w.form == myform & w.quyen == q.nhomquyen.ToString()).FirstOrDefault();
        //        if (tim != null)
        //        {
        //            if (action == "sua")
        //            {
        //                if (tim.sua.Value)
        //                {
        //                    if (TongSoNgay <= tim.suangay)
        //                    {
        //                        rs = true;
        //                    }
        //                }
        //            }
        //            else if (action == "xoa")
        //            {
        //                if (tim.xoa.Value)
        //                {
        //                    if (TongSoNgay <= tim.xoangay)
        //                    {
        //                        rs = true;
        //                    }
        //                }
        //            }
        //            else if (action == "them")
        //            {
        //                if (tim.them.Value)
        //                {
        //                    if (TongSoNgay <= tim.themngay)
        //                    {
        //                        rs = true;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (!rs)
        //    {
        //        MessageBox.Show("Bạn chưa được cấp quyền", "Thông báo");
        //    }
        //    return rs;
        //}
        public static void DisableAll(Panel gp)
        {
            foreach (Control ctrl in gp.Controls)
            {
                if (ctrl is TextBox)
                {
                    Color clr = ctrl.BackColor;
                    ((TextBox)ctrl).ReadOnly = true;
                    ((TextBox)ctrl).BackColor = clr;
                }
                if (ctrl is MaskedTextBox)
                {
                    Color clr = ctrl.BackColor;
                    ((MaskedTextBox)ctrl).ReadOnly = true;
                    ((MaskedTextBox)ctrl).BackColor = clr;
                }
                if (ctrl is ComboBox)
                {
                    Color clr = ctrl.BackColor;
                    ((ComboBox)ctrl).Enabled = false;
                    ((ComboBox)ctrl).BackColor = clr;
                }
                if (ctrl is PictureBox)
                {
                    ((PictureBox)ctrl).Enabled = false;
                }
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = false;
                }
                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = false;
                }
            }
        }
        public static void EnableAll(Panel gp)
        {
            foreach (Control ctrl in gp.Controls)
            {
                if (ctrl is TextBox)
                {
                    Color clr = ctrl.BackColor;
                    ((TextBox)ctrl).ReadOnly = false;
                    ((TextBox)ctrl).BackColor = clr;
                }
                if (ctrl is MaskedTextBox)
                {
                    Color clr = ctrl.BackColor;
                    ((MaskedTextBox)ctrl).ReadOnly = false;
                    ((MaskedTextBox)ctrl).BackColor = clr;
                }
                if (ctrl is ComboBox)
                {
                    Color clr = ctrl.BackColor;
                    ((ComboBox)ctrl).Enabled = true;
                    ((ComboBox)ctrl).BackColor = clr;
                }
                if (ctrl is PictureBox)
                {
                    ((PictureBox)ctrl).Enabled = true;
                }
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = true;
                }
                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = true;
                }
            }
        }

        public static void NullControl(Panel gp)
        {
            foreach (Control ctrl in gp.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Text = string.Empty;
                }
                if (ctrl is ComboBox)
                {
                   if( ((ComboBox)ctrl).Items.Count>0)
                        ((ComboBox)ctrl).SelectedIndex = 0;
                }
                if (ctrl is PictureBox)
                {

                    ((PictureBox)ctrl).InitialImage = null;
                }
            }
        }
        public static string getMd5Hash(string input)
        {
            MD5 mD = MD5.Create();
            byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        public static bool verifyMd5Hash(string input, string hash)
        {
            string md5Hash = getMd5Hash(input);
            StringComparer ordinalIgnoreCase = StringComparer.OrdinalIgnoreCase;
            if (ordinalIgnoreCase.Compare(md5Hash, hash) == 0)
            {
                return true;
            }
            return false;
        }
        public static void FormatDateNull(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    if (formatting.Value != null)
                    {
                        formatting.Value = "";
                        formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        formatting.FormattingApplied = true;

                        //DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                        //if (theDate.Year > 1)
                        //{
                        //    String dateString = theDate.ToString("dd/MM/yyyy");
                        //    formatting.Value = "";
                        //    formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //    formatting.FormattingApplied = true;
                        //}
                    }
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatDate(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    if (formatting.Value != null)
                    {
                        DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                        if (theDate.Year > 1)
                        {
                            String dateString = theDate.ToString("dd/MM/yyyy");
                            formatting.Value = dateString;
                            formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            formatting.FormattingApplied = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatDateKyniem(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    if (formatting.Value != null)
                    {
                        DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                        if (theDate.Year > 1)
                        {
                            String dateString = theDate.ToString("dd/MM");
                            formatting.Value = dateString;
                            formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            formatting.FormattingApplied = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatDateHHMMSS(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                    String dateString = theDate.ToString("dd/MM/yyyy HH:mm");
                    formatting.Value = dateString;
                    formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatHoaDon(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    formatting.Value = formatting.Value.ToString();
                    formatting.CellStyle.ForeColor = Color.Blue;
                    formatting.CellStyle.Font = new Font(formatting.CellStyle.Font, FontStyle.Bold);
                    formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        formatting.FormattingApplied = true;
                    
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatNumber(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    formatting.Value = CustomNumberFormat(formatting.Value.ToString());
                    if (formatting.Value.ToString() == "0")
                    {
                        formatting.Value = "";

                        formatting.FormattingApplied = true;
                    }
                    else if (formatting.Value.ToString() != "")
                    {
                        if (formatting.Value.ToString().Substring(0, 1) == "-")
                            formatting.Value = CustomNumberFormat(formatting.Value.ToString());


                        formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        formatting.FormattingApplied = true;
                    }
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatNumberBold(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    //formatting.Value = GroupDigit(CustomNumberFormat(formatting.Value.ToString()));
                    formatting.Value = CustomNumberFormat(formatting.Value.ToString());
                    formatting.CellStyle.ForeColor = Color.Red;
                    formatting.CellStyle.Font = new Font(formatting.CellStyle.Font, FontStyle.Bold);
                    formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static void FormatNumberBoldColor(DataGridViewCellFormattingEventArgs formatting, Color cl, bool bold)
        {
            if (formatting.Value != null)
            {
                try
                {

                    formatting.Value = CustomNumberFormat(formatting.Value.ToString());
                    formatting.CellStyle.ForeColor = cl;
                    if (bold)
                        formatting.CellStyle.Font = new Font(formatting.CellStyle.Font, FontStyle.Bold);
                    formatting.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }
        public static string CustomNumberFormat(string myNumber)
        {

            myNumber = Num2Str(myNumber);
            if (myNumber.Length > 0)
            {
                int dot = 0;
                if (PQ.culture.NumberFormat.CurrencyGroupSeparator == ",")
                    dot = myNumber.IndexOf(".");
                else
                    dot = myNumber.IndexOf(",");
                int sole = dot;
                if (dot > 0)
                {
                    //if (myNumber.Length >= sole + dot)
                    //{
                    //    sole = 3 + 1;
                    //}
                    //else
                    //{
                    //    sole = myNumber.Length - dot;
                    //}
                    sole = myNumber.Length - sole;
                }


                string strNumberWithoutDecimals = myNumber.Substring(0, (dot == -1 ? myNumber.Length : dot));
                string strNumberDecimals = (dot == -1 ? "" : myNumber.Substring(dot, sole));

                strNumberWithoutDecimals = System.Convert.ToInt64(strNumberWithoutDecimals).ToString("#,##0");
                return (strNumberWithoutDecimals + strNumberDecimals);
            }
            else
                return "";

        }
        public static string CustomNumberFormat_Le(string myNumber)
        {

            myNumber = Num2Str(myNumber);
            if (myNumber.Length > 0)
            {
                int dot = myNumber.IndexOf(".");

                string strNumberWithoutDecimals = myNumber.Substring(0, (dot == -1 ? myNumber.Length : dot));
                string strNumberDecimals = (dot == -1 ? "" : myNumber.Substring(dot));

                strNumberWithoutDecimals = System.Convert.ToInt64(strNumberWithoutDecimals).ToString("#,##0");
                return (strNumberWithoutDecimals + strNumberDecimals);
            }
            else
                return "";

        }
        public static string CustomNumberFormat(int so)
        {
            string myNumber = so.ToString();
            if (myNumber == null)
                return "0";
            myNumber = Functions.Num2Str(myNumber);
            if (IsNumber(myNumber))
            {
                if (myNumber.Length > 0)
                {
                    int dot = myNumber.IndexOf(".");

                    string strNumberWithoutDecimals = myNumber.Substring(0, (dot == -1 ? myNumber.Length : dot));
                    string strNumberDecimals = (dot == -1 ? "" : myNumber.Substring(dot));

                    strNumberWithoutDecimals = System.Convert.ToInt64(strNumberWithoutDecimals).ToString("#,##0");
                    return (strNumberWithoutDecimals + strNumberDecimals);
                }
                else
                    return "";
            }
            else
            {
                return "";
            }

        }
        public static void CustomNumberFormat(TextBox txt)
        {
            txt.Text = CustomNumberFormat(txt.Text);
            txt.SelectionStart = txt.Text.Length;
        }

        public static string Num2Str(string myNumber)
        {

            return myNumber.Replace(PQ.culture.NumberFormat.CurrencyGroupSeparator, "");

        }
        public static bool IsNumber(string pValue)
        {
            if (pValue.Trim().Length == 0)
                return false;
            pValue = Num2Str(pValue);
            if (pValue.Length == 0)
                return false;


            int i = 0;
            foreach (Char c in pValue)
            {
                if (i == 0)
                {
                    if (c.ToString() == "-")
                    {
                        i++;
                    }

                }

                if (!Char.IsDigit(c))
                {
                    if (c.ToString() != PQ.culture.NumberFormat.CurrencyDecimalSeparator)
                        return false;
                }

            }
            return true;
        }
        public static void ChooseIndexLinQ(System.Windows.Forms.ComboBox cbx, object value)
        {
            if(value != null)
                cbx.SelectedValue = value.ToString();
        }
        public static void ChooseIndexLinQ(System.Windows.Forms.ComboBox cbx, string value)
        {
            cbx.SelectedValue = value;
        }
        public static void ChooseIndexcbx(System.Windows.Forms.ComboBox cbx, string value)
        {
            int tmp = -1;
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                //MessageBox.Show(((DataRowView)cbx.Items[i]).Row[0].ToString());
                if (((DataRowView)cbx.Items[i]).Row[0].ToString() == value)
                    tmp = i;
            }
            if (tmp != -1)
                cbx.SelectedIndex = tmp;
            //return tmp;
        }
    }
}
