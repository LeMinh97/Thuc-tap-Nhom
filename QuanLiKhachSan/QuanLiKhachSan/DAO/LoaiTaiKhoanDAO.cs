using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.DAO
{
    public class LoaiTaiKhoanDAO
    {
        private static LoaiTaiKhoanDAO instance;

        public static LoaiTaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new LoaiTaiKhoanDAO(); return LoaiTaiKhoanDAO.instance; }
            private set { LoaiTaiKhoanDAO.instance = value; }
        }
        private LoaiTaiKhoanDAO() { }
        public List<LoaiTaiKhoan> LayDSLoaiTK()
        {
            List<LoaiTaiKhoan> list = new List<LoaiTaiKhoan>();
            string query = "SELECT * FROM dbo.LoaiTK";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiTaiKhoan dsLoaiTK = new LoaiTaiKhoan(item);
                list.Add(dsLoaiTK);
            }
            return list;
        }
    }
}
