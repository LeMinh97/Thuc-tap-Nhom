using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truong
{
    public partial class FormGV : Form
    {
        public FormGV()
        {
            InitializeComponent();
        }
        string Strconn = @"Data Source=STCHIEN\SQLEXPRESS;Initial Catalog=Truong;Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from GV", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGV.DataSource = dt;
        }
        private void FormGV_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Strconn);
            conn.Open();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MonDay", txtMon.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SDT", txtSDT.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm Thành Công");
                LoadData();
            }
            else MessageBox.Show("Không thêm được!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ten", txtTen.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtMon.Text = "";
                    txtSDT.Text = "";
                    txtTen.Text = "";
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MonDay", txtMon.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SDT", txtSDT.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa Thành Công");
                LoadData();
            }
            else MessageBox.Show("Không sửa được!");
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tenGV = txtTen.Text;
            string monDay = txtMon.Text;
            string sdt = txtSDT.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from GV where TenGV like N'%'+N'" + tenGV + "'+N'%' and MonDay like N'%'+N'" + monDay + "'+N'%' and SDT like N'%'+N'" + sdt + "'+N'%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGV.DataSource = dt;
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            txtMon.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            LoadData();
        }
    }
}
