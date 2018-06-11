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
    public partial class fr_Phong : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_Phong(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSPhong();
            RefreshText();
        }

        private void LoadDSPhong()
        {
            string query = "SELECT * FROM dbo.Phong";
            dgvPhong.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshText();
        }
        private void RefreshText()
        {
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtMoTa.Text = "";
            cbTinhTrang.Text = "";
            txtDonGiaGio.Text = "";
            txtTimKiem.Text = "";
            cbTimKiem.Text = "";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            string moTa = txtMoTa.Text;
            string tinhTrang = cbTinhTrang.SelectedItem.ToString();
            int donGiaGio = Convert.ToInt32(txtDonGiaGio.Text);
            if (maPhong == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã phòng!", "Thông báo");
            }
            else if (loaiPhong == "")
            {
                MessageBox.Show("Bạn chưa nhập Loại phòng!", "Thông báo");
            }
            else if (moTa == "")
            {
                MessageBox.Show("Bạn chưa nhập Mô tả!", "Thông báo");
            }
            else if (tinhTrang == "")
            {
                MessageBox.Show("Bạn chưa nhập Tình Trạng!", "Thông báo");
            }
            else if (txtDonGiaGio.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Đơn giá giờ!", "Thông báo");
            }
            else
            {
                if (Phong.Instance.ThemPhong(maPhong,loaiPhong,moTa,tinhTrang,donGiaGio) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSPhong();
                    RefreshText();
                }
                else MessageBox.Show("Có lỗi khi thêm phòng!", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            string moTa = txtMoTa.Text;
            string tinhTrang = cbTinhTrang.SelectedItem.ToString();
            int donGiaGio = Convert.ToInt32(txtDonGiaGio.Text);

            if (Phong.Instance.SuaPhong(maPhong, loaiPhong, moTa, tinhTrang, donGiaGio) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSPhong();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi sửa phòng!", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            if (Phong.Instance.XoaPhong(maPhong) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDSPhong();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi xóa phòng!", "Thông Báo");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSPhong();
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
                    dgvPhong.DataSource = Phong.Instance.TkTheoTatCa(maTK);
                    if (Phong.Instance.CheckTkTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phòng")
                {
                    dgvPhong.DataSource = Phong.Instance.TkTheoMaPhong(maTK);
                    if (Phong.Instance.CheckTkTheoMaPhong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Loại phòng")
                {
                    dgvPhong.DataSource = Phong.Instance.TkTheoLoaiPhong(maTK);
                    if (Phong.Instance.CheckTkTheoLoaiPhong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mô tả")
                {
                    dgvPhong.DataSource = Phong.Instance.TkTheoMoTa(maTK);
                    if (Phong.Instance.CheckTkTheoMoTa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tình trạng")
                {
                    dgvPhong.DataSource = Phong.Instance.TkTheoTinhTrang(maTK);
                    if (Phong.Instance.CheckTkTheoTinhTrang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Đơn giá giờ")
                {
                    dgvPhong.DataSource = Phong.Instance.TkTheoDonGiaGio(maTK);
                    if (Phong.Instance.CheckTkTheoDonGiaGio(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["maPhong"].Value);
                txtLoaiPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["loaiPhong"].Value);
                txtMoTa.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["moTa"].Value);
                cbTinhTrang.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["tinhTrang"].Value);
                txtDonGiaGio.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["donGiaGio"].Value);
            }
        }

        private void dgvPhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

    }
}
