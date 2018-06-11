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
    public partial class fr_TraPhong : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_TraPhong(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadCBMaPhong();
            RefreshText();
        }

        private void LoadCBMaPhong()
        {
            List<cbPhong> listPhong = cbPhongDAO.Instance.LayDSPhongDat();
            cbMaPhong.DataSource = listPhong;
            cbMaPhong.DisplayMember = "MaPhong";
        }

        private void RefreshText()
        {
            cbMaPhong.Text = "";
            txtTienDichVu.Text = "";
            txtTienPhong.Text = "";
            txtTongTien.Text = "";
            string query1 = "SELECT MaPhong,TenDichVu, NgayDung, SoLuong,DonGia, SoLuong*DonGia AS ThanhTien FROM dbo.DichVu,dbo.SuDungDichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND ThanhToan LIKE N'Chưa' AND MaPhong='abcdef'";
            dgvDichVu.DataSource = DataProvider.Instance.ExcuteQuery(query1);
            string query2 = "SELECT ThuePhong.MaPhong, TenKhachHang, NgayThue, ThoiGianO, ThoiGianO*DonGiaGio AS ThanhTien1 FROM dbo.ThuePhong, dbo.KhachHang, dbo.Phong WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND ThuePhong.MaPhong=Phong.MaPhong AND ThuePhong.MaPhong='abcdef' AND ThanhToan LIKE N'Chưa'";
            dgvThuePhong.DataSource = DataProvider.Instance.ExcuteQuery(query2);
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

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {
            int tienPhong, tienDichVu, tongTien;
            tienPhong=tienDichVu=tongTien=0;
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            dgvDichVu.DataSource = TraPhong.Instance.LoadDSDichVu(maPhong);
            dgvThuePhong.DataSource = TraPhong.Instance.LoadDSPhong(maPhong);
            tienPhong = Convert.ToInt32(dgvThuePhong.Rows[0].Cells["thanhTien1"].Value);
            for(int i=0;i<dgvDichVu.RowCount;i++)
            {
                tienDichVu += Convert.ToInt32(dgvDichVu.Rows[i].Cells["thanhTien"].Value);
            }
            tongTien = tienPhong + tienDichVu;
            txtTienPhong.Text = tienPhong.ToString();
            txtTienDichVu.Text = tienDichVu.ToString();
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maPhong=Convert.ToString(dgvThuePhong.Rows[0].Cells["maPhong1"].Value);
            string tenKhachHang=Convert.ToString(dgvThuePhong.Rows[0].Cells["tenKhachHang"].Value);
            DateTime ngayThanhToan= dtpNgayThanhToan.Value;
            DateTime ngayThue=Convert.ToDateTime(dgvThuePhong.Rows[0].Cells["ngayThue"].Value);
            int thoiGianO=Convert.ToInt32(dgvThuePhong.Rows[0].Cells["thoiGianO"].Value);
            int tongTien=Convert.ToInt32(txtTongTien.Text);
            if (TraPhong.Instance.ThanhToan(maPhong,tenKhachHang,ngayThanhToan,ngayThue,thoiGianO,tongTien) == true)
            {
                MessageBox.Show("Thanh toán thành công", "Thông Báo");
                LoadCBMaPhong();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi thanh toán!", "Thông Báo");
        }

        private void dgvThuePhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThuePhong.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }

        private void dgvDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDichVu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void tpLichSu_Click(object sender, EventArgs e)
        {
            dgvLichSu.DataSource = TraPhong.Instance.LoadDSLichSu();
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLichSu.Rows[e.RowIndex].Cells["STT2"].Value = e.RowIndex + 1;
        }
    }
}
