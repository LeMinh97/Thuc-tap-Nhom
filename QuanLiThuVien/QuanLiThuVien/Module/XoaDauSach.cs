using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class XoaDauSach
    {
        private static XoaDauSach instance;
        public static XoaDauSach Instance
        {
            get { if (instance == null) instance = new XoaDauSach(); return XoaDauSach.instance; }
            private set { XoaDauSach.instance = value; }
        }
        private XoaDauSach() { }

        public bool XoaDS(string MaDS)
        {
            string query1 = "DELETE dbo.DauSach WHERE MaDauSach='"+MaDS+"'";
            string query2 = "DELETE dbo.CuonSach WHERE MaDauSach='"+MaDS+"'";
            string query3 = "DELETE dbo.ChiTietTacGia WHERE MaDauSach='"+MaDS+"'";
            int result1 = DataProvider.Instance.ExecuteNonQuery(query1);
            int result2 = DataProvider.Instance.ExecuteNonQuery(query2);
            int result3 = DataProvider.Instance.ExecuteNonQuery(query3);
            return result1 > 0;
        }
    }
}
