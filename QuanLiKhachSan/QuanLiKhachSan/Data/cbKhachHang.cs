using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Data
{
    public class cbKhachHang
    {
        public cbKhachHang(string maKH, string tenKH, string gioiTinh, DateTime ngaySinh, string soCMT, string sdt)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SoCMT = soCMT;
            this.Sdt = sdt;
        }

        public cbKhachHang(DataRow row)
        {
            this.MaKH = row["MaKhachHang"].ToString();
            this.TenKH = row["TenKhachHang"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.SoCMT = row["SoCMT"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string soCMT;

        public string SoCMT
        {
            get { return soCMT; }
            set { soCMT = value; }
        }

        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
