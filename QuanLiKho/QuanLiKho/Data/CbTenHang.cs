using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Data
{
    public class CbTenHang
    {
        public CbTenHang(string maHang,string tenHang,string nganhHang, string dvt,int soLuong)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.NganhHang = nganhHang;
            this.Dvt = dvt;
            this.SoLuong = soLuong;
        }

        public CbTenHang(DataRow row)
        {
            this.MaHang = row["MaHang"].ToString();
            this.TenHang = row["TenHang"].ToString();
            this.NganhHang = row["NganhHang"].ToString();
            this.Dvt = row["DVT"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        private string nganhHang;

        public string NganhHang
        {
            get { return nganhHang; }
            set { nganhHang = value; }
        }
        private string dvt;

        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; }
        }

        
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
