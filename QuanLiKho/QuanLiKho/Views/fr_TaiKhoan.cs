using QuanLiKho.DAO;
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
            LoadDSTaiKhoan();
            LoadCbBoxLoaiTK();
            RefreshText();
        }
        void LoadDSTaiKhoan()
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE TaiKhoan.MaLoaiTK=LoaiTK.MaLoaiTK";
            dgvTaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void RefreshText()
        {
            txtTenDN.Text = "";
            txtTenND.Text = "";
            txtMatKhau.Text = "";
            cbLoaiTK.Text = "";
            txtTimKiemTK.Text = "";
            cbTimKiemTK.Text = "";
        }

        void LoadCbBoxLoaiTK()
        {
            List<LoaiTaiKhoan> listTK = LoaiTaiKhoanDAO.Instance.LayDSLoaiTK();
            cbLoaiTK.DataSource = listTK;
            cbLoaiTK.DisplayMember = "LoaiTK";
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text;
            string tenND = txtTenND.Text;
            string matKhau = txtMatKhau.Text;
            string maLoaiTK = (cbLoaiTK.SelectedItem as LoaiTaiKhoan).MaLoaiTK;
            if (tenDN == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên đăng nhập!", "Thông báo");
            }
            else if (tenND == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên người dùng!", "Thông báo");
            }
            else if (matKhau == "")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu!", "Thông báo");
            }
            else if (cbLoaiTK.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn Loại tài khoản!", "Thông báo");
            }
            else
            {
                if (TaiKhoanDAO.Instance.ThemTK(tenDN, tenND, matKhau, maLoaiTK) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSTaiKhoan();
                }
                else MessageBox.Show("Có lỗi khi thêm tài khoản!", "Thông Báo");
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text;
            string tenND = txtTenND.Text;
            string matKhau = txtMatKhau.Text;
            string maLoaiTK = (cbLoaiTK.SelectedItem as LoaiTaiKhoan).MaLoaiTK;
            if (TaiKhoanDAO.Instance.SuaTK(tenDN, tenND, matKhau, maLoaiTK) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSTaiKhoan();
            }
            else MessageBox.Show("Có lỗi khi sửa đầu sách!", "Thông Báo");
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text;
            if (TkDangNhap.TenDN == tenDN)
            {
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản này. Không thể xóa!", "Thông báo");
                RefreshText();
            }
            else
            {
                if (TaiKhoanDAO.Instance.XoaTK(tenDN) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    RefreshText();
                    LoadDSTaiKhoan();
                }
                else MessageBox.Show("Có lỗi khi xóa tài khoản!", "Thông Báo");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshText();
            LoadDSTaiKhoan();
        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemTK.Text;
            string cbTim = cbTimKiemTK.SelectedItem.ToString();
            if (cbTim == "")
            {
                MessageBox.Show("Bạn chưa chọn gì từ ComboBox!", "Thông báo");
            }
            else if (maTK == "")
            {
                MessageBox.Show("Bạn chưa nhập gì cả!", "Thông báo");
            }
            else
            {
                if (cbTim == "Tất cả")
                {
                    dgvTaiKhoan.DataSource = TaiKhoanDAO.Instance.TkTheoTatCa(maTK);
                    if (TaiKhoanDAO.Instance.CheckTkTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên đăng nhập")
                {
                    dgvTaiKhoan.DataSource = TaiKhoanDAO.Instance.TkTheoTenDangNhap(maTK);
                    if (TaiKhoanDAO.Instance.CheckTkTheoTenDangNhap(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên người dùng")
                {
                    dgvTaiKhoan.DataSource = TaiKhoanDAO.Instance.TkTheoTenTaiKhoan(maTK);
                    if (TaiKhoanDAO.Instance.CheckTkTheoTenTaiKhoan(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Loại tài khoản")
                {
                    dgvTaiKhoan.DataSource = TaiKhoanDAO.Instance.TkTheoLoaiTK(maTK);
                    if (TaiKhoanDAO.Instance.CheckTkTheoLoaiTK(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtTenDN.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["tenDN"].Value);
                txtTenND.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["TenND"].Value);
                txtMatKhau.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["matKhau"].Value);
                cbLoaiTK.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["loaiTK"].Value);
            }
        }

        private void dgvTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTaiKhoan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
