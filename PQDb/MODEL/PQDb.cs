
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data.SQLite;

namespace PQDb.MODEL
{
     class PQDb
    {
        private void CheckConect()
        {
            string dbPath = "pq.db";

            // Kiểm tra xem cơ sở dữ liệu đã tồn tại chưa
            if (!File.Exists(dbPath))
            {
                Console.WriteLine("Cơ sở dữ liệu không tồn tại, đang tạo mới...");
                CreateDatabase(dbPath);
            }

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // Tạo bảng (nếu chưa tạo)
                CreateTables(connection);

                // Thao tác với bảng dulieu
                InsertDulieu(connection, 1, "Nội dung 1");
                InsertDulieu(connection, 2, "Nội dung 2");

                // Đọc và tìm kiếm
                List<Dulieu> dulieuList = GetDulieu(connection);
                Console.WriteLine("Danh sách dữ liệu trong bảng dulieu:");
                foreach (var dulieu in dulieuList)
                {
                    Console.WriteLine($"Mã: {dulieu.Ma}, Nội dung: {dulieu.Noidung}");
                }

                var foundDulieu = SearchDulieu(connection, "Nội dung 1");
                Console.WriteLine("\nKết quả tìm kiếm trong bảng dulieu:");
                foreach (var dulieu in foundDulieu)
                {
                    Console.WriteLine($"Mã: {dulieu.Ma}, Nội dung: {dulieu.Noidung}");
                }

                // Đọc và tìm kiếm trong bảng hopdong
                List<Hopdong> hopdongList = GetHopdong(connection);
                Console.WriteLine("\nDanh sách hợp đồng:");
                foreach (var hopdong in hopdongList)
                {
                    Console.WriteLine($"ID: {hopdong.Id}, Số hợp đồng: {hopdong.Sohopdong}, Ngày: {hopdong.Ngay}, Nội dung: {hopdong.Noidung}");
                }

                // Đọc và tìm kiếm trong bảng khachhang
                List<Khachhang> khachhangList = GetKhachhang(connection);
                Console.WriteLine("\nDanh sách khách hàng:");
                foreach (var khachhang in khachhangList)
                {
                    Console.WriteLine($"Mã: {khachhang.Ma}, Tên: {khachhang.Ten}, Địa chỉ: {khachhang.Diachi}");
                }
            }
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
            noidung TEXT
        );";

            string createKhachhangTable = @"
        CREATE TABLE IF NOT EXISTS khachhang (
            ma TEXT PRIMARY KEY,
            ten TEXT,
            diachi TEXT,
            dienthoai TEXT,
            masothue TEXT,
            taikhoannganhang TEXT,
            sotaikhoan TEXT
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
        static List<Hopdong> GetHopdong(SQLiteConnection connection)
        {
            List<Hopdong> hopdongList = new List<Hopdong>();
            string select = "SELECT id, sohopdong, ngay, noidung FROM hopdong;";

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
                        Noidung = reader.GetString(3)
                    });
                }
            }

            return hopdongList;
        }

        // Đọc tất cả dữ liệu từ bảng khachhang
        static List<Khachhang> GetKhachhang(SQLiteConnection connection)
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

        static void UpdateDulieu(SQLiteConnection connection, int ma, string noidung)
        {
            string update = "UPDATE dulieu SET noidung = @noidung WHERE ma = @ma;";
            using (var command = new SQLiteCommand(update, connection))
            {
                command.Parameters.AddWithValue("@noidung", noidung);
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
        static void InsertHopdong(SQLiteConnection connection, string sohopdong, DateTime ngay, string noidung)
        {
            string insert = "INSERT INTO hopdong (sohopdong, ngay, noidung) VALUES (@sohopdong, @ngay, @noidung);";
            using (var command = new SQLiteCommand(insert, connection))
            {
                command.Parameters.AddWithValue("@sohopdong", sohopdong);
                command.Parameters.AddWithValue("@ngay", ngay);
                command.Parameters.AddWithValue("@noidung", noidung);
                command.ExecuteNonQuery();
            }
        }

        static void UpdateHopdong(SQLiteConnection connection, int id, string sohopdong, DateTime ngay, string noidung, DateTime batdau, DateTime ketthuc, string ghichu, string ma, string ten, string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
        {
            string update = "UPDATE hopdong SET sohopdong = @sohopdong, ngay = @ngay, noidung = @noidung," +
                "batdau =@batdau, ketthuc=@ketthuc, ghichu=@ghichu, " +
                "ten = @ten, diachi = @diachi, dienthoai = @dienthoai, masothue = @masothue, taikhoannganhang = @taikhoannganhang, sotaikhoan = @sotaikhoan" +
                " WHERE id = @id;";
            using (var command = new SQLiteCommand(update, connection))
            {
                command.Parameters.AddWithValue("@sohopdong", sohopdong);
                command.Parameters.AddWithValue("@ngay", ngay);
                command.Parameters.AddWithValue("@noidung", noidung);
                command.Parameters.AddWithValue("@id", id);

                command.Parameters.AddWithValue("@batdau", batdau);
                command.Parameters.AddWithValue("@ketthuc", ketthuc);
                command.Parameters.AddWithValue("@ghichu", ghichu);

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

        static void DeleteHopdong(SQLiteConnection connection, int id)
        {
            string delete = "DELETE FROM hopdong WHERE id = @id;";
            using (var command = new SQLiteCommand(delete, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        // Các thao tác với bảng khachhang
        static void InsertKhachhang(SQLiteConnection connection, string ma, string ten, string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
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

        static void UpdateKhachhang(SQLiteConnection connection, string ma, string ten, string diachi, string dienthoai, string masothue, string taikhoannganhang, string sotaikhoan)
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

        static void DeleteKhachhang(SQLiteConnection connection, string ma)
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
        public int Id { get; set; }
        public string Sohopdong { get; set; }
        public DateTime Ngay { get; set; }
        public string Noidung { get; set; }
        public DateTime Batdau { get; set; }
        public DateTime Ketthuc { get; set; }
        public double Sotien { get; set; }
        public string Ghichu { get; set; }

        public string Ma { get; set; }
        public string Ten { get; set; }
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
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public string Masothue { get; set; }
        public string Taikhoannganhang { get; set; }
        public string Sotaikhoan { get; set; }
    }
}
