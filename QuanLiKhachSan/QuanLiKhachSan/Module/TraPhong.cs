using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class TraPhong
    {
        private static TraPhong instance;

        public static TraPhong Instance
        {
            get { if (instance == null) instance = new TraPhong(); return TraPhong.instance; }
            private set { TraPhong.instance = value; }
        }
        private TraPhong() { }

        public DataTable LoadDSPhong(string maPhong)
        {
            string query = "SELECT ThuePhong.MaPhong, TenKhachHang, NgayThue, ThoiGianO, ThoiGianO*DonGiaGio AS ThanhTien1 FROM dbo.ThuePhong, dbo.KhachHang, dbo.Phong WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND ThuePhong.MaPhong=Phong.MaPhong AND ThuePhong.MaPhong='"+maPhong+"' AND ThanhToan LIKE N'Chưa'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public DataTable LoadDSDichVu(string maPhong)
        {
            string query = "SELECT MaPhong,TenDichVu, NgayDung, SoLuong,DonGia, SoLuong*DonGia AS ThanhTien FROM dbo.DichVu,dbo.SuDungDichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND ThanhToan LIKE N'Chưa' AND MaPhong='"+maPhong+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public DataTable LamRongDGVThuePhong()
        {
            string query = "SELECT ThuePhong.MaPhong, TenKhachHang, NgayThue, ThoiGianO, ThoiGianO*DonGiaGio AS ThanhTien1 FROM dbo.ThuePhong, dbo.KhachHang, dbo.Phong WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND ThuePhong.MaPhong=Phong.MaPhong AND ThuePhong.MaPhong='abcdef' AND ThanhToan LIKE N'Chưa'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public DataTable LamRongDGVDichVu()
        {
            string query = "SELECT MaPhong,TenDichVu, NgayDung, SoLuong,DonGia, SoLuong*DonGia AS ThanhTien FROM dbo.DichVu,dbo.SuDungDichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND ThanhToan LIKE N'Chưa' AND MaPhong='abcdef'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public bool ThanhToan(string maPhong, string tenKhachHang, DateTime ngayThanhToan, DateTime ngayThue, int thoiGianO, int tongTien)
        {
            string query = "INSERT dbo.ThanhToan( MaPhong ,TenKhachHang ,NgayThanhToan ,NgayThue ,ThoiGianO ,TongTien) VALUES  ( '"+maPhong+"' , N'"+tenKhachHang+"' ,  '"+ngayThanhToan+"' ,  '"+ngayThue+"' ,  "+thoiGianO+" , "+tongTien+"  )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            string query1 = "UPDATE dbo.Phong SET TinhTrang=N'Chưa' WHERE MaPhong='"+maPhong+"' AND TinhTrang LIKE N'OK'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            string query2 = "UPDATE dbo.ThuePhong SET ThanhToan=N'OK' WHERE MaPhong='"+maPhong+"' AND ThanhToan LIKE N'Chưa'";
            DataProvider.Instance.ExecuteNonQuery(query2);
            string query3 = "UPDATE dbo.SuDungDichVu SET ThanhToan=N'OK' WHERE MaPhong='"+maPhong+"' AND ThanhToan LIKE N'Chưa'";
            DataProvider.Instance.ExecuteNonQuery(query3);
            return result > 0;
        }

        public DataTable LoadDSLichSu()
        {
            string query = "SELECT * FROM dbo.ThanhToan";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
