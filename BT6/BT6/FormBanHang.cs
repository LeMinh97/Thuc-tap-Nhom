using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT6
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=BanHangDB; Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTHoaDon", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBanHang.DataSource = dt;
        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDBDataHoaDon.CTHoaDon' table. You can move, or remove it, as needed.
            this.cTHoaDonTableAdapter.Fill(this.banHangDBDataHoaDon.CTHoaDon);
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Delete CTHoaDon", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBanHang.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string don = txtDon.Text;
            string sp = txtTenSP.Text;
            string gia = txtGia.Text;
            string sl = txtSL.Text;
            string tien = TxtTien.Text;
            SqlCommand cmd = new SqlCommand("ThemHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@don", don);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@sp", sp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@sl", sl);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@gia", gia);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@tien", tien);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
            else MessageBox.Show("Không thể thêm mới");
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int sc = dgvBanHang.Rows.Count;
            float tongtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongtien += float.Parse(dgvBanHang.Rows[i].Cells[4].Value.ToString());
            }
            txtTong.Text = tongtien.ToString();
        }
    }
}
