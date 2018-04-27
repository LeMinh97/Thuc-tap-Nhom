using QuanLiKho.DAO;
using QuanLiKho.Data;
using QuanLiKho.Module;
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
    public partial class fr_DangNhap : Form
    {
        public fr_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            if (DangNhap.Instance.KtDangNhap(username, password) == true)
            {
                TaiKhoan TkDangNhap = TaiKhoanDAO.Instance.LayTKtuTenDN(username);
                fr_Main f = new fr_Main(TkDangNhap);
                this.Hide();
                f.Show();
            }
            else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
