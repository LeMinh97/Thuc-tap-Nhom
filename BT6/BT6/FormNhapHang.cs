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
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=BanHangDB; Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTNhapHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhap.DataSource = dt;
        }
            private void FormNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDBDataSetNhap.CTNhapHang' table. You can move, or remove it, as needed.
            this.cTNhapHangTableAdapter.Fill(this.banHangDBDataSetNhap.CTNhapHang);
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void BtnNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("NhapKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@SP", txtMaSP.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Nhap", txtPhieu.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SL", txtSL.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ngay", txtNgay.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Tien", txtTien.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
            else MessageBox.Show("Không thể thêm mới");
        }
    }
}
