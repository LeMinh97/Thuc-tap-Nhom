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
    public partial class fr_Main : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_Main(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            HienTenTaiKhoan();
        }

        private void HienTenTaiKhoan()
        {
            lbHienTenTaiKhoan.Text = lbHienTenTaiKhoan.Text + TkDangNhap.LoaiTK + ": " + TkDangNhap.TenND;
        }

        private void TaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TkDangNhap.LoaiTK.ToString() == "Quản lí")
            {
                fr_TaiKhoan f = new fr_TaiKhoan(TkDangNhap);
                this.Hide();
                f.Show();
            }
            else MessageBox.Show("Mục này chỉ dành cho Quản lí", "Thông báo");
        }

        private void DangNhapLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DangNhap f = new fr_DangNhap();
            this.Hide();
            f.Show();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_ThuePhong f = new fr_ThuePhong(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void TraPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SdDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Phong f = new fr_Phong(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_KhachHang f = new fr_KhachHang(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void vậtDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
