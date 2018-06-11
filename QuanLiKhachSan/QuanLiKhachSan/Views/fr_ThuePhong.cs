using QuanLiKhachSan.DAO;
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
    public partial class fr_ThuePhong : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_ThuePhong(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSThuePhong();
            RefreshText();
        }

        private void LoadDSThuePhong()
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang";
            dgvThuePhong.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshText();
            LoadCBMaPhong();
            LoadCBTenKhachHang();
        }

        private void RefreshText()
        {
            cbTenKH.Text = "";
            cbMaPhong.Text = "";
            cbTimKiem.Text = "";
            dtpNgayThue.Value = DateTime.Now;
            txtThoiGianO.Text = "";
            txtTimKiem.Text = "";
        }

        private void LoadCBMaPhong()
        {
            List<cbPhong> listPhong = cbPhongDAO.Instance.LayDSPhongTrong();
            cbMaPhong.DataSource = listPhong;
            cbMaPhong.DisplayMember = "MaPhong";
        }

        private void LoadCBTenKhachHang()
        {
            List<cbKhachHang> listKhachHang = cbKhachHangDAO.Instance.LayDSKhachHang();
            cbTenKH.DataSource = listKhachHang;
            cbTenKH.DisplayMember = "TenKH";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maKH = (cbTenKH.SelectedItem as cbKhachHang).MaKH;
            DateTime ngayThue = dtpNgayThue.Value;
            int thoiGianO = Convert.ToInt32(txtThoiGianO.Text);
            string thanhToan = cbThanhToan.SelectedItem.ToString();

            if (maPhong == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã phòng!", "Thông báo");
            }
            else if (maKH == "")
            {
                MessageBox.Show("Bạn chưa chọn Tên khách hàng!", "Thông báo");
            }
            else if (txtThoiGianO.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Thời gian ở!", "Thông báo");
            }
            else if (thanhToan == "")
            {
                MessageBox.Show("Bạn chưa chọn Tình trạng thanh toán!", "Thông báo");
            }
            else
            {
                if (ThuePhong.Instance.ThemThuePhong(maKH,maPhong,ngayThue,thoiGianO,thanhToan) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSThuePhong();
                    RefreshText();
                }
                else MessageBox.Show("Có lỗi khi thêm thuê phòng!", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = cbMaPhong.Text;
            string maKH = (cbTenKH.SelectedItem as cbKhachHang).MaKH;
            DateTime ngayThue = dtpNgayThue.Value;
            int thoiGianO = Convert.ToInt32(txtThoiGianO.Text);
            string thanhToan = cbThanhToan.SelectedItem.ToString();

            if (ThuePhong.Instance.SuaThuePhong(maKH,maPhong,ngayThue,thoiGianO,thanhToan) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSThuePhong();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi sửa thuê phòng!", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = cbMaPhong.Text;
            string maKH = (cbTenKH.SelectedItem as cbKhachHang).MaKH;
            DateTime ngayThue = dtpNgayThue.Value;

            if (ThuePhong.Instance.XoaThuePhong(maKH,maPhong,ngayThue) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDSThuePhong();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi xóa thuê phòng!", "Thông Báo");
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
                    dgvThuePhong.DataSource = ThuePhong.Instance.TkTheoTatCa(maTK);
                    if (ThuePhong.Instance.CheckTkTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phòng")
                {
                    dgvThuePhong.DataSource = ThuePhong.Instance.TkTheoMaPhong(maTK);
                    if (ThuePhong.Instance.CheckTkTheoMaPhong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên khách hàng")
                {
                    dgvThuePhong.DataSource = ThuePhong.Instance.TkTheoTenKhachHang(maTK);
                    if (ThuePhong.Instance.CheckTkTheoTenKhachHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày thuê")
                {
                    dgvThuePhong.DataSource = ThuePhong.Instance.TkTheoNgayThue(maTK);
                    if (ThuePhong.Instance.CheckTkTheoNgayThue(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Thời gian ở")
                {
                    dgvThuePhong.DataSource = ThuePhong.Instance.TkTheoThoiGianO(maTK);
                    if (ThuePhong.Instance.CheckTkTheoThoiGianO(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tình trạng thanh toán")
                {
                    dgvThuePhong.DataSource = ThuePhong.Instance.TkTheoThanhToan(maTK);
                    if (ThuePhong.Instance.CheckTkTheoThanhToan(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSThuePhong();
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

        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbMaPhong.Text = Convert.ToString(dgvThuePhong.CurrentRow.Cells["maPhong"].Value);
                cbTenKH.Text = Convert.ToString(dgvThuePhong.CurrentRow.Cells["tenKhachHang"].Value);
                dtpNgayThue.Text= Convert.ToString(dgvThuePhong.CurrentRow.Cells["ngayThue"].Value);
                txtThoiGianO.Text = Convert.ToString(dgvThuePhong.CurrentRow.Cells["thoiGianO"].Value);
                cbThanhToan.Text = Convert.ToString(dgvThuePhong.CurrentRow.Cells["thanhToan"].Value);
            }
        }

        private void dgvThuePhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThuePhong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
