using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Data
{
    public class TaiKhoan
    {
        public TaiKhoan(string tenDN, string tenND, string matKhau, string loaiTK)
        {
            this.TenDN = tenDN;
            this.TenND = tenND;
            this.MatKhau = matKhau;
            this.LoaiTK = loaiTK;
        }
        public TaiKhoan(DataRow row)
        {
            this.TenDN = row["TenDN"].ToString();
            this.TenND = row["TenND"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.LoaiTK = row["LoaiTK"].ToString();
        }
        private string tenDN;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
        private string tenND;

        public string TenND
        {
            get { return tenND; }
            set { tenND = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string loaiTK;

        public string LoaiTK
        {
            get { return loaiTK; }
            set { loaiTK = value; }
        }
    }
}
