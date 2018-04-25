using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Data
{
    public class TKLoaiTK
    {
        public TKLoaiTK(int maLoaiTK,string loaiTK)
        {
            this.MaLoaiTK = maLoaiTK;
            this.LoaiTK = loaiTK;
        }
        public TKLoaiTK(DataRow row)
        {
            this.MaLoaiTK = (int)row["MaLoaiTK"];
            this.LoaiTK = row["LoaiTK"].ToString();
        }
        private int maLoaiTK;

        public int MaLoaiTK
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
