using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class XoaMuonTra
    {
        private static XoaMuonTra instance;
        public static XoaMuonTra Instance
        {
            get { if (instance == null) instance = new XoaMuonTra(); return XoaMuonTra.instance; }
            private set { XoaMuonTra.instance = value; }
        }
        private XoaMuonTra() { }
        public bool XoaMT(string MaNM,string MaCS)
        {
            string query = "DELETE dbo.PhieuMuon WHERE MaNguoiDoc='"+MaNM+"' AND MaCuonSach='"+MaCS+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
