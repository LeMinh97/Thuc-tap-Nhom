using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class ThemMuonTra
    {
        private static ThemMuonTra instance;

        public static ThemMuonTra Instance
        {
            get { if (instance == null) instance = new ThemMuonTra(); return ThemMuonTra.instance; }
            private set { ThemMuonTra.instance = value; }
        }
        private ThemMuonTra() { }
        public bool ThemMT(string MaNM,string MaCS,DateTime NgayMuon,DateTime NgayTra)
        {
            string query = "INSERT dbo.PhieuMuon( MaNguoiDoc, MaCuonSach, NgayMuon, NgayTra ) VALUES  ( '"+MaNM+"', '"+MaCS+"', '"+NgayMuon+"', '"+NgayTra+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
