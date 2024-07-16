using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHopdong
{
    public class PQ
    {
        public static CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

  
        public static bool ClickOK = false;

        public static string UserName = "phuqui";
        public static string Fullname = "Ks. Quí - 0974.36.76.76 ";
        public static string Permission = "2";
        public static string Bophan = "";
        public static string Bophanten = "";
       // public static string Version = "19.05.2024";
        public static DateTime Version = Functions.String2Date("07/16/2024");//MM.dd.yyyy
        public static DateTime ngayhethong = DateTime.Now;
        public static int sothangxem = 12;
        public static int iChon = 0;

        public static Color cl_Banhang = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        public static Color cl_Nhap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));


        public static string ctyten = "CÔNG TY TNHH MTV HƯNG PHÚ";
        public static string ctydiachi = "ĐC: 534D, Nguyễn Thị Định, Phú Hưng";
        public static string ctydienthoai = "ĐT: 0275 3812 983. Fax: 0275 3834478";
        public static string ctymst = "";
        public static string ctytknganhang = "";
        public static string ctylogo = "";

        public static string connecttion = MyAccess.Config.DecryptPass(ConfigurationManager.AppSettings["PQKEY"].ToString()) + ";Connection Timeout=3600";


        public static string MayinA4 = "";
        public static int iReportMarginTop =30;
        public static int iReportMarginLeft =25;
        public static int iReportMarginRight=30;
        public static int iReportMarginBottom = 30;

        public static int iBillMarginTop = 25;
        public static int iBillMarginLeft = 25;
        public static int iBillMarginRight = 50;
        public static int iBillMarginBottom = 650;   
        public static Color myBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
    }
}
