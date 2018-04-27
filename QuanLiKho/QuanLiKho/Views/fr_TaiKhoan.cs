using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKho.Views
{
    public partial class fr_TaiKhoan : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_TaiKhoan(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {

        }
    }
}
