using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.DAO
{
    public class MTNguoiMuonDAO
    {
        private static MTNguoiMuonDAO instance;

        public static MTNguoiMuonDAO Instance
        {
            get {if(instance==null) instance=new MTNguoiMuonDAO(); return MTNguoiMuonDAO.instance; }
            private set { MTNguoiMuonDAO.instance = value; }
        }
        private MTNguoiMuonDAO() { }
        public List<MTNguoiMuon> LayDSNguonMuon()
        {
            List<MTNguoiMuon> list = new List<MTNguoiMuon>();
            string query = "SELECT * FROM dbo.NguoiDoc";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MTNguoiMuon mtNM = new MTNguoiMuon(item);
                list.Add(mtNM);
            }
            return list;
        }
    }
}
