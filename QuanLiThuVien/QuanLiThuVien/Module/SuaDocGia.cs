using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class SuaDocGia
    {
        private static SuaDocGia instance;

        public static SuaDocGia Instance
        {
            get { if (instance == null) instance = new SuaDocGia(); return SuaDocGia.instance; }
            private set { SuaDocGia.instance = value; }
        }
        private SuaDocGia() { }

        public bool SuaND(string ID, string TenND, string DiaChi, string SDT)
        {
            string query = "UPDATE dbo.NguoiDoc SET TenNguoiDoc=N'" + TenND + "', DiaChi=N'" + DiaChi + "',SDT=N'" + SDT + "' WHERE MaNguoiDoc='"+ID+"'";
            int result =DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }

    }
}
