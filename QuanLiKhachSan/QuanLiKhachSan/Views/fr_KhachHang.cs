using QuanLiKhachSan.Data;
using QuanLiKhachSan.Module;
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
    public partial class fr_KhachHang : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_KhachHang(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSKhachHang();
        }

        private void LoadDSKhachHang()
        {
            string query = "SELECT * FROM dbo.KhachHang";
            dgvKhachHang.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshText();
        }

        private void RefreshText()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cbGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtSoCMT.Text = "";
            txtSoDT.Text = "";
            txtTimKiem.Text = "";
            cbTimKiem.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = dtpNgaySinh.Value;
            string soCMT = txtSoCMT.Text;
            string sdt = txtSoDT.Text;
            if (maKH == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã khách hàng!", "Thông báo");
            }
            else if (tenKH == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên khách hàng!", "Thông báo");
            }
            else if (soCMT == "")
            {
                MessageBox.Show("Bạn chưa nhập Số CMT!", "Thông báo");
            }
            else if (sdt == "")
            {
                MessageBox.Show("Bạn chưa nhập SDT!", "Thông báo");
            }
            else if (cbGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Đơn giá giờ!", "Thông báo");
            }
            else
            {
                if (KhachHang.Instance.ThemKhachHang(maKH,tenKH,gioiTinh,ngaySinh,soCMT,sdt) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSKhachHang();
                }
                else MessageBox.Show("Có lỗi khi thêm khách hàng!", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = dtpNgaySinh.Value;
            string soCMT = txtSoCMT.Text;
            string sdt = txtSoDT.Text;
            if (KhachHang.Instance.SuaKhachHang(maKH, tenKH, gioiTinh, ngaySinh, soCMT, sdt) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSKhachHang();
            }
            else MessageBox.Show("Có lỗi khi sửa khách hàng!", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            if (KhachHang.Instance.XoaKhachHang(maKH) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDSKhachHang();
            }
            else MessageBox.Show("Có lỗi khi xóa khách hàng!", "Thông Báo");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiem.Text;
            string cbTim = cbTimKiem.SelectedItem.ToString();
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
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoTatCa(maTK);
                    if (KhachHang.Instance.CheckTkTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã khách hàng")
                {
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoMaKhachHang(maTK);
                    if (KhachHang.Instance.CheckTkTheoMaKhachHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên khách hàng")
                {
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoTenKhachHang(maTK);
                    if (KhachHang.Instance.CheckTkTheoTenKhachHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Giới tính")
                {
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoGioiTinh(maTK);
                    if (KhachHang.Instance.CheckTkTheoGioiTinh(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày sinh")
                {
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoNgaySinh(maTK);
                    if (KhachHang.Instance.CheckTkTheoNgaySinh(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số CMT")
                {
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoSoCMT(maTK);
                    if (KhachHang.Instance.CheckTkTheoSoCMT(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số DT")
                {
                    dgvKhachHang.DataSource = KhachHang.Instance.TkTheoSDT(maTK);
                    if (KhachHang.Instance.CheckTkTheoSDT(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSKhachHang();
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["maKH"].Value);
                txtTenKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["tenKH"].Value);
                txtSoCMT.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["soCMT"].Value);
                txtSoDT.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["sdt"].Value);
                cbGioiTinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["gioiTinh"].Value);
                dtpNgaySinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["ngaySinh"].Value);
            }
        }

        private void dgvKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
