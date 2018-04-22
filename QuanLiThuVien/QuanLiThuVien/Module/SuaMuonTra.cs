using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class SuaMuonTra
    {
        private static SuaMuonTra instance;

        public static SuaMuonTra Instance
        {
            get { if (instance == null) instance = new SuaMuonTra(); return SuaMuonTra.instance; }
            private set { SuaMuonTra.instance = value; }
        }
        private SuaMuonTra() { }

        public bool SuaMT(string MaNM, string MaCS, DateTime NgayMuon, DateTime NgayTra)
        {
            string query = "UPDATE dbo.PhieuMuon SET NgayMuon='"+NgayMuon+"',NgayTra='"+NgayTra+"' WHERE MaNguoiDoc='"+MaNM+"'AND MaCuonSach='"+MaCS+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
