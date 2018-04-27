using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Data
{
    public class LoaiTaiKhoan
    {
        public LoaiTaiKhoan(string maLoaiTK,string loaiTK)
        {
            this.MaLoaiTK = maLoaiTK;
            this.LoaiTK = loaiTK;
        }
        public LoaiTaiKhoan(DataRow row)
        {
            this.MaLoaiTK = row["MaLoaiTK"].ToString();
            this.LoaiTK = row["LoaiTK"].ToString();
        }
        private string maLoaiTK;

        public string MaLoaiTK
        {
            get { return maLoaiTK; }
            set { maLoaiTK = value; }
        }


        private string loaiTK;

        public string LoaiTK
        {
            get { return loaiTK; }
            set { loaiTK = value; }
        }
    }
}
