using eHopdong.USERCONTROL;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.BAOCAO
{
    public partial class uBaoDoanhthu : UserControl
    {
        private static uBaoDoanhthu _instance;
        public static uBaoDoanhthu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uBaoDoanhthu();

                return _instance;
            }
        }
        public uBaoDoanhthu()
        {
            InitializeComponent();
        }
        LINQ.DbDataContext db;
        bool hienbang = false;
       

        private void uKhachhang_Load(object sender, EventArgs e)
        {
            db = new LINQ.DbDataContext();            
            LoadData();
        }
        
        public void LoadData()
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.Series.Clear();

            cartesianChart1.Visible = true;

            SeriesCollection dstam = new SeriesCollection();
            SeriesCollection dstam1 = new SeriesCollection();
            List<MODEL.BCDoanhthuloinhuan> ds = new List<MODEL.BCDoanhthuloinhuan>();

            db = new LINQ.DbDataContext();
            if (PQ.Permission == "0")
            {
                var t = db.BAOCAO_DICHVU_ADMIN(dtTu.Value.Date, dtDen.Value.Date).ToList();

                if (t.Count > 0)
                {
                    ds.AddRange(t.Select(w => new MODEL.BCDoanhthuloinhuan { sott = 0, ten = w.ten, doanhthu=w.doanhthu.Value, username=w.phutrach, loinhuan=w.loinhuan.Value, tienvon=w.tienvon.Value }).ToList());

                }

            }
            else if (PQ.Permission == "1")
            {
                var t = db.BAOCAO_DICHVU_QUANLY(PQ.Bophan, dtTu.Value.Date, dtDen.Value.Date).ToList();

                if (t.Count > 0)
                {
                    ds.AddRange(t.Select(w => new MODEL.BCDoanhthuloinhuan { sott = 0, ten = w.ten, doanhthu = w.doanhthu.Value, username = w.phutrach, loinhuan = w.loinhuan.Value, tienvon = w.tienvon.Value }).ToList());

                }

            }
            else
            {
                var t = db.BAOCAO_DICHVU_QUANLY(PQ.Bophan, dtTu.Value.Date, dtDen.Value.Date).ToList();

                if (t.Count > 0)
                {
                    ds.AddRange(t.Where(W => W.phutrach == PQ.UserName).Select(w => new MODEL.BCDoanhthuloinhuan { sott = 0, ten = w.ten, doanhthu = w.doanhthu.Value, username = w.phutrach, loinhuan = w.loinhuan.Value, tienvon = w.tienvon.Value }).ToList());

                }

            }

            ChartValues<double> sokh = new ChartValues<double>();
            ChartValues<double> solan = new ChartValues<double>();
            List<string> nhanvien = new List<string>();

            ColumnSeries cotsolan = new ColumnSeries();
            cotsolan.Title = "DOANH THU";
            
            ColumnSeries cotsokh = new ColumnSeries();
            cotsokh.Title = "LỢI NHUẬN";

            var q = db.nhomdichvus.OrderBy(w=>w.ten);
            foreach (var ok in ds)
            {
                sokh.Add(ok.doanhthu);
                solan.Add(ok.loinhuan);
                nhanvien.Add(ok.ten);

               

            }
            cotsolan.Values = sokh;
            cotsokh.Values = solan;
            dstam.Add(cotsolan);
            dstam.Add(cotsokh);

            if (ds.Count > 0)
            {
               
                foreach (var n in q)
                {
                    StackedColumnSeries st = new StackedColumnSeries();
                    st.StackMode = StackMode.Values;
                    st.DataLabels = true;
                    st.Title = n.ten;
                    ChartValues<double> tien = new ChartValues<double>();
                    foreach (var ok in ds)
                    {
                        tien.Add(db.cungcapdichvus.Where(w => w.ketthuc.Value == true & w.phutrach == ok.username & w.nhomdichvu == n.ma & w.kethucngay.Value.Date >= dtTu.Value.Date & w.kethucngay.Value.Date <= dtDen.Value.Date).AsEnumerable().Sum(w => w.sotien.Value));
                    }
                    
                    st.Values = tien;

                    dstam.Add(st);
                }
            }

            

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "",
                Labels = nhanvien
            });

            cartesianChart1.Series = dstam;
            cartesianChart1.AxisY.Add(new Axis
            {
                //Title = "Doanh thu",
                LabelFormatter = value => value.ToString("N0")
            });

            if (hienbang)
            {
                frm_DlgDoanhthuBang f = new frm_DlgDoanhthuBang();
                f.lbngay.Text = "Từ ngày " + dtTu.Value.ToString("dd/MM/yyyy") + " đến " + dtDen.Value.ToString("dd/MM/yyyy");
                f.ds = ds;
                f.ShowDialog();
            }

        }      

    
        private void btnXem_Click(object sender, EventArgs e)
        {
            hienbang = false;
            LoadData();
        }

        private void btnBaocaobang_Click(object sender, EventArgs e)
        {
            hienbang = true;
            LoadData();
        }
    }
}
