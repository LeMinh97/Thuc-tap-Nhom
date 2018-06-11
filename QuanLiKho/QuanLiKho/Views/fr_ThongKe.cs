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
    public partial class fr_ThongKe : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_ThongKe(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnVeMenu1_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int tienNhap, tienXuat, tienLai;
            tienNhap = tienXuat = tienLai = 0;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            dgvNhap.DataSource = ThongKe.Instance.HienDSNhap(ngayBatDau, ngayKetThuc);
            dgvXuat.DataSource = ThongKe.Instance.HienDSXuat(ngayBatDau, ngayKetThuc);
            for (int i = 0; i < dgvNhap.RowCount; i++)
            {
                tienNhap += Convert.ToInt32(dgvNhap.Rows[i].Cells["soLuong"].Value) * Convert.ToInt32(dgvNhap.Rows[i].Cells["donGiaNhap"].Value);
            }
            for (int i = 0; i < dgvXuat.RowCount; i++)
            {
                tienXuat += Convert.ToInt32(dgvXuat.Rows[i].Cells["soLuong1"].Value) * Convert.ToInt32(dgvXuat.Rows[i].Cells["donGiaXuat"].Value);
            }
            tienLai = tienXuat - tienNhap;
            txtLai.Text = tienLai.ToString();
            if (ThongKe.Instance.CheckHienDSNhap(ngayBatDau, ngayKetThuc) == false && ThongKe.Instance.CheckHienDSXuat(ngayBatDau, ngayKetThuc) == false)
                MessageBox.Show("Không có nhập xuất trong khoảng thời gian này!", "Thông báo");
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string cbSX = cbSapXep.SelectedItem.ToString();
            if(cbSX=="Số lượng từ cao đến thấp")
            {
                dgvTonKho.DataSource = ThongKe.Instance.SapXepSoLuongTuCaoToiThap();
            }else if(cbSX=="Số lượng từ thấp đến cao")
            {
                dgvTonKho.DataSource = ThongKe.Instance.SapXepSoLuongTuThapToiCao();
            }else if(cbSX=="Ngành hàng")
            {
                dgvTonKho.DataSource = ThongKe.Instance.SapXepTheoNganhHang();
            }
        }

        private void lbLai_Click(object sender, EventArgs e)
        {

        }
    }
}
