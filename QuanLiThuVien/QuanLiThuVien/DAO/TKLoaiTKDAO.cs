using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.DAO
{
    public class TKLoaiTKDAO
    {
        private static TKLoaiTKDAO instance;

        public static TKLoaiTKDAO Instance
        {
            get { if (instance == null) instance = new TKLoaiTKDAO(); return TKLoaiTKDAO.instance; }
            private set { TKLoaiTKDAO.instance = value; }
        }
        private TKLoaiTKDAO() { }
        public List<TKLoaiTK> LayDSLoaiTK()
        {
            List<TKLoaiTK> list = new List<TKLoaiTK>();
            string query = "SELECT * FROM dbo.LoaiTK";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                TKLoaiTK dsLoaiTK = new TKLoaiTK(item);
                list.Add(dsLoaiTK);
            }
            return list;
        }
        
    }
}
