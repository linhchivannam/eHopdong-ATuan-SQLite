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
    public partial class uBaoChamsoc : UserControl
    {
        private static uBaoChamsoc _instance;
        public static uBaoChamsoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uBaoChamsoc();

                return _instance;
            }
        }
        public uBaoChamsoc()
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

            db = new LINQ.DbDataContext();
            List<MODEL.BCChamsoc> ds = new List<MODEL.BCChamsoc>();
            if (PQ.Permission == "0")
            {
                var t = db.BAOCAO_CHAMSOC_ADMIN( dtTu.Value.Date, dtDen.Value.Date).ToList();
               
                if (t.Count > 0)
                {
                    ds.AddRange(t.Select(w => new MODEL.BCChamsoc { sokh = w.sokh.Value, solan = w.solan.Value, sott = 0, ten = w.ten }).ToList());                  

                }

            }
            else if(PQ.Permission == "1")
            {
                var t = db.BAOCAO_CHAMSOC_QUANLY(PQ.Bophan,dtTu.Value.Date, dtDen.Value.Date).ToList();

                if (t.Count > 0)
                {
                    ds.AddRange(t.Select(w => new MODEL.BCChamsoc { sokh = w.sokh.Value, solan = w.solan.Value, sott = 0, ten = w.ten }).ToList());

                }

            }
            else 
            {
                var t = db.BAOCAO_CHAMSOC_QUANLY(PQ.Bophan, dtTu.Value.Date, dtDen.Value.Date).ToList();

                if (t.Count > 0)
                {
                    ds.AddRange(t.Where(W=>W.username==PQ.UserName).Select(w => new MODEL.BCChamsoc { sokh = w.sokh.Value, solan = w.solan.Value, sott = 0, ten = w.ten }).ToList());

                }

            }

            ChartValues<double> sokh = new ChartValues<double>();
            ChartValues<double> solan = new ChartValues<double>();
            List<string> nhanvien = new List<string>();

            ColumnSeries cotsolan = new ColumnSeries();
            cotsolan.Title = "Lượt chăm sóc";
            ColumnSeries cotsokh = new ColumnSeries();
            cotsokh.Title = "Số khách hàng";

            foreach (var ok in ds)
            {
                sokh.Add(ok.sokh);
                solan.Add(ok.solan);
                nhanvien.Add(ok.ten);
            }

            cotsolan.Values = solan;
            cotsokh.Values = sokh;
            
            dstam.Add(cotsokh);
            dstam.Add(cotsolan);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "",
                Labels = nhanvien
            });

            cartesianChart1.Series = dstam;


            if (hienbang)
            {
                frm_DlgChamsocBang f = new frm_DlgChamsocBang();
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
