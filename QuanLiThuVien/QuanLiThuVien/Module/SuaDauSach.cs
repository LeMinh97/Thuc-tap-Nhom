using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class SuaDauSach
    {
        private static SuaDauSach instance;
        public static SuaDauSach Instance
        {
            get { if (instance == null) instance = new SuaDauSach(); return SuaDauSach.instance; }
            private set { SuaDauSach.instance = value; }
        }
        private SuaDauSach() { }

        public bool SuaDS(string MaDS, string TenDS, string TheLoai, string MaNXB, string MaNhanh)
        {
            string query = "UPDATE dbo.DauSach SET TenDauSach=N'"+TenDS+"',TheLoai=N'"+TheLoai+"',MaNhaXB='"+MaNXB+"',MaNhanh='"+MaNhanh+"' WHERE MaDauSach='"+MaDS+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
