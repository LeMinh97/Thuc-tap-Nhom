using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Data
{
    public class CbMaPhieuNhap
    {
        public CbMaPhieuNhap(string maPhieuNhap,DateTime ngayNhap,string maNCC)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.NgayNhap = ngayNhap;
            this.MaNCC = maNCC;
        }
        public CbMaPhieuNhap(DataRow row)
        {
            this.MaPhieuNhap = row["MaPhieuNhap"].ToString();
            this.NgayNhap = (DateTime)row["NgayNhap"];
            this.MaNCC = row["MaNCC"].ToString();
        }
        private string maPhieuNhap;

        public string MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }
        private DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
    }
}
