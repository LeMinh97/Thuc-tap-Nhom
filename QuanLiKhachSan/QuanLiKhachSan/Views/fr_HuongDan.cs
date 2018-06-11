using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.Views
{
    public partial class fr_HuongDan : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_HuongDan(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }
    }
}
