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
    public partial class fr_VatDung : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_VatDung(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSVatDung();
            RefreshText();
        }

        private void LoadDSVatDung()
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung";
            dgvDoDung.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshText();
            LoadCBMaPhong();
            LoadCBTenDoDung();
        }

        private void RefreshText()
        {
            cbMaPhong.Text = "";
            cbTenDoDung.Text = "";
            cbTimKiem.Text = "";
            dtpNgayKT.Value = DateTime.Now;
            txtSoLgBanDau.Text = "";
            txtSoLgDaDung.Text = "";
            txtTimKiem.Text = "";
        }

        private void LoadCBMaPhong()
        {
            List<cbPhong> listPhong = cbPhongDAO.Instance.LayDSPhong();
            cbMaPhong.DataSource = listPhong;
            cbMaPhong.DisplayMember = "MaPhong";
        }

        private void LoadCBTenDoDung()
        {
            List<cbDoDung> listDoDung = cbDoDungDAO.Instance.LayDSTenDoDung();
            cbTenDoDung.DataSource = listDoDung;
            cbTenDoDung.DisplayMember = "TenDoDung";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maDoDung = (cbTenDoDung.SelectedItem as cbDoDung).MaDoDung;
            DateTime ngayKT = dtpNgayKT.Value;
            int soLgBanDau = Convert.ToInt32(txtSoLgBanDau.Text);
            int soLgDaDung = Convert.ToInt32(txtSoLgDaDung.Text);
            if (maPhong == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã phòng!", "Thông báo");
            }
            else if (maDoDung == "")
            {
                MessageBox.Show("Bạn chưa chọn Tên đồ dùng!", "Thông báo");
            }
            else if (txtSoLgBanDau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Số lượng ban đầu!", "Thông báo");
            }
            else if (txtSoLgDaDung.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập Số lượng đã dùng!", "Thông báo");
            }
            else
            {
                if (DoDung.Instance.ThemDoDung(maPhong,maDoDung,ngayKT,soLgBanDau,soLgDaDung) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSVatDung();
                    RefreshText();
                }
                else MessageBox.Show("Có lỗi khi thêm Đồ dùng!", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maDoDung = (cbTenDoDung.SelectedItem as cbDoDung).MaDoDung;
            DateTime ngayKT = dtpNgayKT.Value;
            int soLgBanDau = Convert.ToInt32(txtSoLgBanDau.Text);
            int soLgDaDung = Convert.ToInt32(txtSoLgDaDung.Text);
            if (DoDung.Instance.SuaDoDung(maPhong, maDoDung, ngayKT, soLgBanDau, soLgDaDung) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSVatDung();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi sửa Đồ dùng!", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maDoDung = (cbTenDoDung.SelectedItem as cbDoDung).MaDoDung;
            DateTime ngayKT = dtpNgayKT.Value;
            if (DoDung.Instance.XoaDoDung(maPhong, maDoDung, ngayKT) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDSVatDung();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi xóa Đồ dùng!", "Thông Báo");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSVatDung();
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
                    dgvDoDung.DataSource = DoDung.Instance.TkTheoTatCa(maTK);
                    if (DoDung.Instance.CheckTkTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phòng")
                {
                    dgvDoDung.DataSource = DoDung.Instance.TkTheoMaPhong(maTK);
                    if (DoDung.Instance.CheckTkTheoMaPhong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên đồ dùng")
                {
                    dgvDoDung.DataSource = DoDung.Instance.TkTheoTenDoDung(maTK);
                    if (DoDung.Instance.CheckTkTheoTenDoDung(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày kiểm tra")
                {
                    dgvDoDung.DataSource = DoDung.Instance.TkTheoNgayKT(maTK);
                    if (DoDung.Instance.CheckTkTheoNgayKT(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số lượng ban đầu")
                {
                    dgvDoDung.DataSource = DoDung.Instance.TkTheoSoLgBanDau(maTK);
                    if (DoDung.Instance.CheckTkTheoSoLuongBanDau(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số lượng đã dùng")
                {
                    dgvDoDung.DataSource = DoDung.Instance.TkTheoSoLgDaDung(maTK);
                    if (DoDung.Instance.CheckTkTheoSoLuongDaDung(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void dgvDoDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbTenDoDung.Text = Convert.ToString(dgvDoDung.CurrentRow.Cells["tenDoDung"].Value);
                cbMaPhong.Text = Convert.ToString(dgvDoDung.CurrentRow.Cells["maPhong"].Value);
                dtpNgayKT.Text = Convert.ToString(dgvDoDung.CurrentRow.Cells["ngayKT"].Value);
                txtSoLgBanDau.Text = Convert.ToString(dgvDoDung.CurrentRow.Cells["soLuongBanDau"].Value);
                txtSoLgDaDung.Text = Convert.ToString(dgvDoDung.CurrentRow.Cells["soLuongDaDung"].Value);
            }
        }

        private void dgvDoDung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDoDung.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
