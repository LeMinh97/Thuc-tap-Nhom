using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Data
{
    public class DSNhanh
    {
        public DSNhanh(string maNhanh, string tenNhanh, string diaChi)
        {
            this.MaNhanh = maNhanh;
            this.TenNhanh = tenNhanh;
            this.DiaChi = diaChi;
        }

        public DSNhanh(DataRow row)
        {
            this.MaNhanh = row["MaNhanh"].ToString();
            this.TenNhanh = row["TenNhanh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }

        private string maNhanh;

        public string MaNhanh
        {
            get { return maNhanh; }
            set { maNhanh = value; }
        }

        private string tenNhanh;

        public string TenNhanh
        {
            get { return tenNhanh; }
            set { tenNhanh = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
