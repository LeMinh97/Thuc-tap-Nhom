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
    public partial class fr_HangHoa : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }

        
        public fr_HangHoa(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSHangHoa();
            RefreshText();
        }
        private void LoadDSHangHoa()
        {
            string query = "SELECT * FROM dbo.HangHoa";
            dgvHangHoa.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        private void RefreshText()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtNganhHang.Text = "";
            txtDVT.Text = "";
            txtSoLuong.Text = "";
            txtTimKiem.Text = "";
            cbTimKiem.Text = "";
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string nganhHang = txtNganhHang.Text;
            string dvt = txtDVT.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            
            if (maHang == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã hàng!", "Thông báo");
            }
            else if (tenHang == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên hàng!", "Thông báo");
            }
            else if (nganhHang == "")
            {
                MessageBox.Show("Bạn chưa nhập Ngành hàng!", "Thông báo");
            }
            else if (dvt == "")
            {
                MessageBox.Show("Bạn chưa nhập Đơn vị tính!", "Thông báo");
            }
            else if (txtSoLuong.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập Số lượng!", "Thông báo");
            }
            else
            {
                if (ThemHangHoa.Instance.ThemHang(maHang,tenHang,nganhHang,dvt,soLuong) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSHangHoa();
                    RefreshText();
                }
                else MessageBox.Show("Có lỗi khi thêm hàng hóa!", "Thông Báo");
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string nganhHang = txtNganhHang.Text;
            string dvt = txtDVT.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            if ( SuaHangHoa.Instance.SuaHang(maHang,tenHang,nganhHang,dvt,soLuong)== true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSHangHoa();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi sửa hàng hóa!", "Thông Báo");
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            if (XoaHangHoa.Instance.XoaHang(maHang) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDSHangHoa();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi xóa hàng hóa!", "Thông Báo");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSHangHoa();
            RefreshText();
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
            string maTK = txtTimKiem.Text;
            string cbTim = cbTimKiem.SelectedItem.ToString();
            if (cbTimKiem.Text == null)
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
                    dgvHangHoa.DataSource = TimKiemHangHoa.Instance.TimKiemTheoTatCa(maTK);
                    if (TimKiemHangHoa.Instance.CheckTimKiemTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
                if (cbTim == "Mã hàng hóa")
                {
                    dgvHangHoa.DataSource = TimKiemHangHoa.Instance.TimKiemTheoMaHang(maTK);
                    if (TimKiemHangHoa.Instance.CheckTimKiemTheoMaHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
                if (cbTim == "Tên hàng hóa")
                {
                    dgvHangHoa.DataSource = TimKiemHangHoa.Instance.TimKiemTheoTenHang(maTK);
                    if (TimKiemHangHoa.Instance.CheckTimKiemTheoTenHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
                if (cbTim == "Ngành hàng")
                {
                    dgvHangHoa.DataSource = TimKiemHangHoa.Instance.TimKiemTheoNganhHang(maTK);
                    if (TimKiemHangHoa.Instance.CheckTimKiemTheoNganhHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
                if (cbTim == "Đơn vị tính")
                {
                    dgvHangHoa.DataSource = TimKiemHangHoa.Instance.TimKiemTheoDVT(maTK);
                    if (TimKiemHangHoa.Instance.CheckTimKiemTheoDVT(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaHang.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["maHang"].Value);
                txtTenHang.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["tenHang"].Value);
                txtNganhHang.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["nganhHang"].Value);
                txtDVT.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["dvt"].Value);
                txtSoLuong.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["soLuong"].Value);
            }
        }

        private void dgvHangHoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHangHoa.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
