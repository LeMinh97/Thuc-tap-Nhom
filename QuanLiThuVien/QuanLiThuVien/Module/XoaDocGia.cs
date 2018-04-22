using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class XoaDocGia
    {
        private static XoaDocGia instance;

        public static XoaDocGia Instance
        {
            get { if (instance == null) instance = new XoaDocGia(); return XoaDocGia.instance; }
            private set { XoaDocGia.instance = value; }
        }
        private XoaDocGia() { }

        public bool XoaND(string ID)
        {
            string query1 = "DELETE dbo.PhieuMuon WHERE MaNguoiDoc='" + ID + "'";
            string query2 = "DELETE dbo.NguoiDoc WHERE MaNguoiDoc='"+ID+"'";
            int result1=DataProvider.Instance.ExecuteNonQuery(query1);
            int result2 = DataProvider.Instance.ExecuteNonQuery(query2);
            return (result2 > 0 && (result1 > 0|| result1<=0));
        }
    }
}
