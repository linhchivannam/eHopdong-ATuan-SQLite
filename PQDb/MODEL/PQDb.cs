
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data.SQLite;

namespace PQDb.MODEL
{
    public class PQDb
    {
        string dbPath = "PQdb.db";
        SQLiteConnection connection;

      public  PQDb() {
            CheckConect();
            connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            connection.Open();
           // CheckConect();
        }
        private void CheckConect()
        {           

            // Kiểm tra xem cơ sở dữ liệu đã tồn tại chưa
            if (!File.Exists(dbPath))
            {
                Console.WriteLine("Cơ sở dữ liệu không tồn tại, đang tạo mới...");
                CreateDatabase(dbPath);

                using (connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    // Tạo bảng (nếu chưa tạo)
                    CreateTables(connection);
                    InsertNguoidung( "phuqui", "Mr Quí", "c4ca4238a0b923820dcc509a6f75849b");


                }
            }

            
        }
         SQLiteConnection Kettnoi()
        {
            var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            
                connection.Open();
            return connection;
        }
        static void CreateDatabase(string dbPath)
        {
            SQLiteConnection.CreateFile(dbPath);
            Console.WriteLine("Cơ sở dữ liệu đã được tạo.");
        }

        static void CreateTables(SQLiteConnection connection)
        {
            string createDulieuTable = @"
        CREATE TABLE IF NOT EXISTS dulieu (
            ma INTEGER PRIMARY KEY,
            noidung TEXT
        );";

            string createHopdongTable = @"
        CREATE TABLE IF NOT EXISTS hopdong (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            sohopdong TEXT(20),
            ngay DATETIME,
            noidung TEXT,
            batdau DATETIME,
            ketthuc DATETIME,
            sotien  REAL,
            ghichu TEXT,
            ma TEXT ,
            ten TEXT,
            daidien TEXT ,
            chucvu TEXT,
            diachi TEXT,
            dienthoai TEXT,
            masothue TEXT,
            taikhoannganhang TEXT,
            sotaikhoan TEXT
        );";

            string createKhachhangTable = @"
        CREATE TABLE IF NOT EXISTS khachhang (
            ma TEXT PRIMARY KEY,
            ten TEXT,
            daidien TEXT ,
            chucvu TEXT,
            diachi TEXT,
            dienthoai TEXT,
            masothue TEXT,
            taikhoannganhang TEXT,
            sotaikhoan TEXT
        );";

            string creatNguoidungTable = @"
        CREATE TABLE IF NOT EXISTS nguoidung (
            ma TEXT PRIMARY KEY,
            ten TEXT,
            pass TEXT
        );";

            using (var command = new SQLiteCommand(createDulieuTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new SQLiteCommand(createHopdongTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new SQLiteCommand(createKhachhangTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(creatNguoidungTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        
        static List<Dulieu> GetDulieu(SQLiteConnection connection)
        {
            List<Dulieu> dulieuList = new List<Dulieu>();
            string select = "SELECT ma, noidung FROM dulieu;";

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dulieuList.Add(new Dulieu
                    {
                        Ma = reader.GetInt32(0),
                        Noidung = reader.GetString(1)
                    });
                }
            }

            return dulieuList;
        }

        // Tìm kiếm dữ liệu trong bảng dulieu
        static List<Dulieu> SearchDulieu(SQLiteConnection connection, string noidung)
        {
            List<Dulieu> results = new List<Dulieu>();
            string search = "SELECT ma, noidung FROM dulieu WHERE noidung LIKE @noidung;";

            using (var command = new SQLiteCommand(search, connection))
            {
                command.Parameters.AddWithValue("@noidung", $"%{noidung}%");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new Dulieu
                        {
                            Ma = reader.GetInt32(0),
                            Noidung = reader.GetString(1)
                        });
                    }
                }
            }

            return results;
        }

        // Đọc tất cả dữ liệu từ bảng hopdong
        public Hopdong Get1Hopdong(string where)
        {
            Hopdong a = new Hopdong();
            List<Hopdong> hopdongList = new List<Hopdong>();
            string select = "SELECT id, sohopdong, ngay, noidung, batdau, ketthuc,ghichu ,ma, ten, diachi, dienthoai, masothue, taikhoannganhang, sotaikhoan,sotien FROM hopdong where id='" + where + "' limit 1;";

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
               if(reader.Read())
                {

                    a.Id = reader.GetInt32(0);
                    a.Sohopdong = reader.GetString(1);
                    a.Ngay = reader.GetDateTime(2);
                    a.Noidung = reader.GetString(3);
                    a.Batdau = reader.GetDateTime(4);
                    a.Ketthuc = reader.GetDateTime(5);
                    a.Ghichu = reader.GetString(6);
                    a.Ma = reader.GetString(7);
                    a.Ten = reader.GetString(8);
                    a.Diachi = reader.GetString(9);
                    a.Dienthoai = reader.GetString(10);
                    a.Masothue = reader.GetString(11);
                    a.Taikhoannganhang = reader.GetString(12);
                    a.Sotaikhoan = reader.GetString(13);
                    a.Sotien = reader.GetDouble(14);
                    return a;
                }
              //  return null;
            }

            return null;
        }

        public List<Hopdong> GetHopdong( string where)
        {
            List<Hopdong> hopdongList = new List<Hopdong>();
            string select = "SELECT id, sohopdong, ngay, noidung, batdau, ketthuc,ghichu ,ma, ten, diachi, dienthoai, masothue, taikhoannganhang, sotaikhoan,sotien FROM hopdong "+where+";";

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    hopdongList.Add(new Hopdong
                    {
                        Id = reader.GetInt32(0),
                        Sohopdong = reader.GetString(1),
                        Ngay = reader.GetDateTime(2),
                        Noidung = reader.GetString(3),
                        Batdau = reader.GetDateTime(4),
                        Ketthuc = reader.GetDateTime(5),
                        Ghichu = reader.GetString(6),
                        Ma = reader.GetString(7),
                        Ten = reader.GetString(8),
                        Diachi = reader.GetString(9),
                        Dienthoai = reader.GetString(10),
                        Masothue = reader.GetString(11),
                        Taikhoannganhang = reader.GetString(12),
                        Sotaikhoan = reader.GetString(13),
                        Sotien = reader.GetDouble(14)
                    });
                }
            }

            return hopdongList;
        }

        // Đọc tất cả dữ liệu từ bảng khachhang
        public List<Khachhang> GetKhachhang()
        {
            List<Khachhang> khachhangList = new List<Khachhang>();
            string select = "SELECT ma, ten, diachi, dienthoai, masothue, taikhoannganhang, sotaikhoan FROM khachhang;";

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    khachhangList.Add(new Khachhang
                    {
                        Ma = reader.GetString(0),
                        Ten = reader.GetString(1),
                        Diachi = reader.GetString(2),
                        Dienthoai = reader.GetString(3),
                        Masothue = reader.GetString(4),
                        Taikhoannganhang = reader.GetString(5),
                        Sotaikhoan = reader.GetString(6)
                    });
                }
            }

            return khachhangList;
        }
        public Khachhang Get1Khachhang(string ma)
        {
            Khachhang a = new Khachhang();
            string select = "SELECT ma, ten,daidien, chucvu, diachi, dienthoai, masothue, taikhoannganhang, sotaikhoan FROM khachhang where ma='"+ma+"' limit 1;";

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    a.Ma = reader.GetString(0);
                    a.Ten = reader.GetString(1);
                    a.Daidien = reader.GetString(2);
                    a.Chucvu = reader.GetString(3);
                    a.Diachi = reader.GetString(4);
                    a.Dienthoai = reader.GetString(5);
                    a.Masothue = reader.GetString(6);
                    a.Taikhoannganhang = reader.GetString(7);
                    a.Sotaikhoan = reader.GetString(8);

                }
                else
                    return null;
            }

            return a;
        }
        public List<Nguoidung> GetDSNguoidung()
        {
            string select = "SELECT ma, ten, pass FROM nguoidung where ma<>'phuqui' ";
            List<Nguoidung> ds = new List<Nguoidung>();

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ds.Add(new Nguoidung
                    {
                        Ma = reader.GetString(0),
                        Ten = reader.GetString(1),
                        Pass = reader.GetString(2)
                    });
                }
               
            }
            return ds;
        }
        public  Nguoidung GetNguoidung(string ma)
        {
            string select = "SELECT ma, ten, pass FROM nguoidung where ma='"+ma+"' LIMIT 1";
            Nguoidung a = new Nguoidung();

            using (var command = new SQLiteCommand(select, connection))
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    a.Ma = reader.GetString(0);
                    a.Ten = reader.GetString(1);
                    a.Pass = reader.GetString(2);

                }
                else
                    return null;
            }
            return a;                
        }
        public void InsertNguoidung( string ma, string ten, string pass)
        {
            var q = GetNguoidung(ma);
            if (q == null)
            {
                string insert = "INSERT INTO nguoidung(ma, ten,pass) VALUES (@ma, @ten, @pass);";
                using (var command = new SQLiteCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.ExecuteNonQuery();
                }
            }
        }
        static void InsertDulieu(SQLiteConnection connection, int ma, string noidung)
        {
            string insert = "INSERT INTO dulieu (ma, noidung) VALUES (@ma, @noidung);";
            using (var command = new SQLiteCommand(insert, connection))
            {
                command.Parameters.AddWithValue("@ma", ma);
                command.Parameters.AddWithValue("@noidung", noidung);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateNguoidung( string ma, string ten, string pass)
        {
            string update = "UPDATE nguoidung SET ten = @ten, pass=@pass WHERE ma = @ma;";
            using (var command = new SQLiteCommand(update, connection))
            {
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@ma", ma);
                command.ExecuteNonQuery();
            }
        }

        static void DeleteDulieu(SQLiteConnection connection, int ma)
        {
            string delete = "DELETE FROM dulieu WHERE ma = @ma;";
            using (var command = new SQLiteCommand(delete, connection))
            {
                command.Parameters.AddWithValue("@ma", ma);
                command.ExecuteNonQuery();
            }
        }

        // Các thao tác với bảng hopdong
        public void InsertHopdong( string sohopdong, DateTime ngay, string noidung,DateTime batdau, DateTime ketthuc,double sotien, string ghichu, string ma, string ten,string daidien, string chucvu , string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
        {
            string insert = "INSERT INTO hopdong (sohopdong, ngay, noidung, batdau, ketthuc,sotien, ghichu, ma, ten,daidien, chucvu, diachi, dienthoai, masothue, taikhoannganhang, sotaikhoan) VALUES (@sohopdong, @ngay, @noidung, @batdau, @ketthuc,@sotien, @ghichu, @ma, @ten,@daidien, @chucvu, @diachi, @dienthoai, @masothue, @taikhoannganhang, @sotaikhoan);";
            using (var command = new SQLiteCommand(insert, connection))
            {
                command.Parameters.AddWithValue("@sohopdong", sohopdong);
                command.Parameters.AddWithValue("@ngay", ngay);
                command.Parameters.AddWithValue("@noidung", noidung);

                command.Parameters.AddWithValue("@batdau", batdau);
                command.Parameters.AddWithValue("@ketthuc", ketthuc);
                command.Parameters.AddWithValue("@sotien", sotien);
                command.Parameters.AddWithValue("@ghichu", ghichu);

                command.Parameters.AddWithValue("@ma", ma);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@daidien", daidien);
                command.Parameters.AddWithValue("@chucvu", chucvu);
                command.Parameters.AddWithValue("@diachi", diachi);
                command.Parameters.AddWithValue("@dienthoai", dienthoai);
                command.Parameters.AddWithValue("@masothue", masothue);
                command.Parameters.AddWithValue("@taikhoannganhang", taikhoannganhang);
                command.Parameters.AddWithValue("@sotaikhoan", sotaikhoan);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateHopdong( long id, string sohopdong, DateTime ngay, string noidung, DateTime batdau, DateTime ketthuc,double sotien, string ghichu, string ma, string ten,string daidien, string chucvu ,string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
        {
            string update = "UPDATE hopdong SET sohopdong = @sohopdong, ngay = @ngay, noidung = @noidung," +
                "batdau =@batdau, ketthuc=@ketthuc,sotien=@sotien, ghichu=@ghichu, " +
                "ten = @ten,daidien=@daidien, chucvu=@chucvu, diachi = @diachi, dienthoai = @dienthoai, masothue = @masothue, taikhoannganhang = @taikhoannganhang, sotaikhoan = @sotaikhoan" +
                " WHERE id = @id;";
            using (var command = new SQLiteCommand(update, connection))
            {
                command.Parameters.AddWithValue("@sohopdong", sohopdong);
                command.Parameters.AddWithValue("@ngay", ngay);
                command.Parameters.AddWithValue("@noidung", noidung);
                command.Parameters.AddWithValue("@id", id);

                command.Parameters.AddWithValue("@batdau", batdau);
                command.Parameters.AddWithValue("@ketthuc", ketthuc);
                command.Parameters.AddWithValue("@sotien", sotien);
                command.Parameters.AddWithValue("@ghichu", ghichu);

                command.Parameters.AddWithValue("@ma", ma);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@daidien", daidien);
                command.Parameters.AddWithValue("@chucvu", chucvu);
                command.Parameters.AddWithValue("@diachi", diachi);
                command.Parameters.AddWithValue("@dienthoai", dienthoai);
                command.Parameters.AddWithValue("@masothue", masothue);
                command.Parameters.AddWithValue("@taikhoannganhang", taikhoannganhang);
                command.Parameters.AddWithValue("@sotaikhoan", sotaikhoan);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteNguoidung(string id)
        {
            string delete = "DELETE FROM nguoidung WHERE ma = @id;";
            using (var command = new SQLiteCommand(delete, connection))
            {
                command.Parameters.AddWithValue("@ma", id);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteHopdong( long id)
        {
            string delete = "DELETE FROM hopdong WHERE id = @id;";
            using (var command = new SQLiteCommand(delete, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        // Các thao tác với bảng khachhang
        public void InsertKhachhang(SQLiteConnection connection, string ma, string ten, string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
        {
            string insert = "INSERT INTO khachhang (ma, ten, diachi, dienthoai, masothue, taikhoannganhang, sotaikhoan) VALUES (@ma, @ten, @diachi, @dienthoai, @masothue, @taikhoannganhang, @sotaikhoan);";
            using (var command = new SQLiteCommand(insert, connection))
            {
                command.Parameters.AddWithValue("@ma", ma);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@diachi", diachi);
                command.Parameters.AddWithValue("@dienthoai", dienthoai);
                command.Parameters.AddWithValue("@masothue", masothue);
                command.Parameters.AddWithValue("@taikhoannganhang", taikhoannganhang);
                command.Parameters.AddWithValue("@sotaikhoan", sotaikhoan);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateKhachhang(SQLiteConnection connection, string ma, string ten, string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
        {
            string update = "UPDATE khachhang SET ten = @ten, diachi = @diachi, dienthoai = @dienthoai, masothue = @masothue, taikhoannganhang = @taikhoannganhang, sotaikhoan = @sotaikhoan WHERE ma = @ma;";
            using (var command = new SQLiteCommand(update, connection))
            {
                command.Parameters.AddWithValue("@ma", ma);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@diachi", diachi);
                command.Parameters.AddWithValue("@dienthoai", dienthoai);
                command.Parameters.AddWithValue("@masothue", masothue);
                command.Parameters.AddWithValue("@taikhoannganhang", taikhoannganhang);
                command.Parameters.AddWithValue("@sotaikhoan", sotaikhoan);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteKhachhang( string ma)
        {
            string delete = "DELETE FROM khachhang WHERE ma = @ma;";
            using (var command = new SQLiteCommand(delete, connection))
            {
                command.Parameters.AddWithValue("@ma", ma);
                command.ExecuteNonQuery();
            }
        }
    }
    public class Dulieu
    {
        public int Ma { get; set; }
        public string Noidung { get; set; }
    }
    public class Nguoidung
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Pass { get; set; }
    }

    public class Hopdong
    {
        public long Id { get; set; }
        public string Sohopdong { get; set; }
        public DateTime Ngay { get; set; }
        public string Noidung { get; set; }
        public DateTime Batdau { get; set; }
        public DateTime Ketthuc { get; set; }
        public double Sotien { get; set; }
        public string Ghichu { get; set; }

        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Daidien { get; set; }
        public string Chucvu { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public string Masothue { get; set; }
        public string Taikhoannganhang { get; set; }
        public string Sotaikhoan { get; set; }
    }

    public class Khachhang
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Daidien { get; set; }
        public string Chucvu { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public string Masothue { get; set; }
        public string Taikhoannganhang { get; set; }
        public string Sotaikhoan { get; set; }
    }
}
