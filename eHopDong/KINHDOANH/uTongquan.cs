using eHopdong.DANHMUC;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.KINHDOANH
{
    public partial class uTongquan : UserControl
    {
        private static uTongquan _instance;
        public static uTongquan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uTongquan();

                return _instance;
            }
        }
        public uTongquan()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        private void uTongquan_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();
            lbHDoanhthu.Text = "DOANH THU " + PQ.ngayhethong.Year.ToString();
            lbHdLoinhuan.Text = "LỢI NHUẬN " + PQ.ngayhethong.Year.ToString();
            // Setup();
        }
        public void Setup()
        {
            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
                var dichvu = db.cungcapdichvus.Where(w => w.ngay.Value.Year == PQ.ngayhethong.Year).AsEnumerable();

                lbDoanhthunam.Text = dichvu.Sum(w => w.sotien).Value.ToString("N0");
                lbDoanhthuthang.Text = dichvu.Where(w =>   w.ngay.Value.Month == PQ.ngayhethong.Month).AsEnumerable().Sum(w => w.sotien).Value.ToString("N0");

                lbLoinhuanNam.Text = dichvu.Where(w=>w.ketthuc==true).Sum(w => w.loinhuan).Value.ToString("N0");
                lbLoinhuanthang.Text = dichvu.Where(w => w.ketthuc == true & w.ngay.Value.Month == PQ.ngayhethong.Month).AsEnumerable().Sum(w => w.loinhuan).Value.ToString("N0");

                lbHopdong.Text = dichvu.Count().ToString("N0");
                lbHDthang.Text = dichvu.Where(w =>  w.ngay.Value.Month == PQ.ngayhethong.Month).AsEnumerable().Count().ToString("N0");

                lbKhachhang.Text = db.khachhangs.AsEnumerable().Count().ToString("N0");
            }
            else
            {
                var dichvu = db.cungcapdichvus.Where(w => w.ngay.Value.Year == PQ.ngayhethong.Year).AsEnumerable();

                lbDoanhthunam.Text = dichvu.Where(w => w.phutrach == PQ.UserName).AsEnumerable().Sum(w => w.sotien).Value.ToString("N0");
                lbDoanhthuthang.Text = dichvu.Where(w => w.phutrach == PQ.UserName & w.ngay.Value.Month == PQ.ngayhethong.Month).AsEnumerable().Sum(w => w.sotien).Value.ToString("N0");

                lbLoinhuanNam.Text = dichvu.Where(w => w.ketthuc == true & w.phutrach == PQ.UserName).AsEnumerable().Sum(w => w.loinhuan).Value.ToString("N0");
                lbLoinhuanthang.Text = dichvu.Where(w => w.ketthuc == true & w.phutrach == PQ.UserName & w.ngay.Value.Month == PQ.ngayhethong.Month).AsEnumerable().Sum(w => w.loinhuan).Value.ToString("N0");

                lbHopdong.Text = dichvu.Where(w => w.phutrach == PQ.UserName ).AsEnumerable().Count().ToString("N0");
                lbHDthang.Text = dichvu.Where(w => w.phutrach == PQ.UserName &  w.ngay.Value.Month == PQ.ngayhethong.Month).AsEnumerable().Count().ToString("N0");

                lbKhachhang.Text = db.khachhangs.Where(w => w.username == PQ.UserName).AsEnumerable().Count().ToString("N0");
            }
            LoadChart3();
           // LoadChart2();
        }
        
        private void LoadChart3()
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.Series.Clear();
            

            List<string> songay = new List<string>();
            DateTime ngay = PQ.ngayhethong;


            for (int i = 1; i <= PQ.sothangxem; i++)
            {
                songay.Add(ngay.AddMonths( i-PQ.sothangxem).ToString("MM/yyyy"));
            }


            SeriesCollection dstam = new SeriesCollection();

            var nh = db.cungcapdichvus.Where(w => w.ngay.Value.Year >= PQ.ngayhethong.Year-1);
            if (nh.Count() > 0)
            {
                cartesianChart1.Visible = true;

                // bieu do tron
                p2.Visible = true;
                p2.Series.Clear();
                Func<ChartPoint, string> labelPoint = chartPoint =>
                      string.Format("{0} ({1:P})", Functions.CustomNumberFormat(chartPoint.Y.ToString()), Functions.CustomNumberFormat(Math.Round(chartPoint.Participation,2).ToString()));
                var kho = db.nhomdichvus.OrderBy(w => w.ten);
                if (kho.Count() > 0)
                {

                    foreach (var ok in kho)
                    {
                        PieSeries a = new PieSeries();
                        a.Title = ok.ten;
                        a.PushOut = 15;
                        a.DataLabels = true;
                        a.LabelPoint = labelPoint;

                        // double sotien = 0;
                        if (PQ.Permission == "0")
                        {
                            var t = nh.Where(w => w.nhomdichvu == ok.ma & w.ngay.Value.Year == PQ.ngayhethong.Year).AsEnumerable().Sum(w => w.sotien);

                            a.Values = new ChartValues<double> { t.Value };

                            p2.Series.Add(a);
                        }
                        else
                        {
                            var t = nh.Where(w => w.phutrach==PQ.UserName & w.nhomdichvu == ok.ma & w.ngay.Value.Year == PQ.ngayhethong.Year).AsEnumerable().Sum(w => w.sotien);

                            a.Values = new ChartValues<double> { t.Value };

                            p2.Series.Add(a);
                        }
                    }
                }

                p2.LegendLocation = LegendLocation.Bottom;


                // het bieu do tron

                ngay = PQ.ngayhethong;

                var dv = db.nhomdichvus.OrderBy(w => w.ten);
                if (dv.Count() > 0)
                {
                    foreach (var ok in dv)
                    {
                        LineSeries a1 = new LineSeries();
                        a1.Title = ok.ten;
                        ChartValues<double> so = new ChartValues<double>();
                        for (int i = 1; i <= PQ.sothangxem; i++)
                        {
                            DateTime ngay1 = ngay.AddMonths(i - PQ.sothangxem);

                            if (PQ.Permission == "0")
                            {
                                double giatri = nh.Where(w => w.nhomdichvu == ok.ma & w.ngay.Value.Year == ngay1.Year & w.ngay.Value.Month == ngay1.Month).AsEnumerable().Sum(w => w.sotien).Value;
                                so.Add(giatri);
                                a1.Values = so;
                            }
                            else
                            {
                                double giatri = nh.Where(w =>w.phutrach==PQ.UserName & w.nhomdichvu == ok.ma & w.ngay.Value.Year == ngay1.Year & w.ngay.Value.Month == ngay1.Month).AsEnumerable().Sum(w => w.sotien).Value;
                                so.Add(giatri);
                                a1.Values = so;
                            }
                        }
                        dstam.Add(a1);
                    }
                }
            }

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "",
                Labels = songay
            });
            cartesianChart1.Series = dstam;


            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Doanh thu",
                LabelFormatter = value => value.ToString("N0")
            });

        }
    }
}
