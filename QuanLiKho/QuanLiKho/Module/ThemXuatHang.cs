using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class ThemXuatHang
    {
        private static ThemXuatHang instance;

        public static ThemXuatHang Instance
        {
            get { if (instance == null) instance = new ThemXuatHang(); return ThemXuatHang.instance; }
            private set { ThemXuatHang.instance = value; }
        }
        private ThemXuatHang() { }
        public bool ThemPhieuXuat(string maPX,DateTime ngayXuat,string maKH)
        {
            string query = "INSERT dbo.PhieuXuat( MaPhieuXuat, NgayXuat, MaKH ) VALUES  ( '"+maPX+"', '"+ngayXuat+"', '"+maKH+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemChiTietPhieuXuat(string maPX,string maHang,int soLuong, int donGiaXuat)
        {
            string query = "INSERT dbo.ChiTietPhieuXuat( MaPhieuXuat ,MaHang ,SoLuong ,DonGiaXuat) VALUES  ( '"+maPX+"' ,'"+maHang+"',"+soLuong+","+donGiaXuat+")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            string query1 = "UPDATE dbo.HangHoa SET SoLuong=SoLuong-"+soLuong+" WHERE MaHang='"+maHang+"'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }

    }
}
