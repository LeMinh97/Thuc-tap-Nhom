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
            HienTenNguoiDung();
        }

        private void HienTenNguoiDung()
        {
            lbHienTenNguoiDung.Text = lbHienTenNguoiDung.Text + TkDangNhap.LoaiTK + ": " + TkDangNhap.TenND;
        }
        private void fr_Main_Load(object sender, EventArgs e)
        {

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

        private void hangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_HangHoa f = new fr_HangHoa();
            this.Hide();
            f.Show();
        }

        private void nhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_NhapHang f = new fr_NhapHang();
            this.Hide();
            f.Show();
        }

        private void xuatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_XuatHang f = new fr_XuatHang();
            this.Hide();
            f.Show();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_ThongKe f = new fr_ThongKe();
            this.Hide();
            f.Show();
        }
    }
}
