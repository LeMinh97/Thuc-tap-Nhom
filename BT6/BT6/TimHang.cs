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
    public partial class TimHang : Form
    {
        public TimHang()
        {
            InitializeComponent();
        }
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=BanHangDB; Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SP", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSP.DataSource = dt;
        }
        private void TimHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDBDataTK.SP' table. You can move, or remove it, as needed.
            this.sPTableAdapter.Fill(this.banHangDBDataTK.SP);
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text;
            if(radioButton1.Checked==true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SP where TenSP like N'%'+N'" + key + "'+N'%'",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSP.DataSource = dt;
                return;
            }
            else if(radioButton2.Checked==true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SP where MaLoai like N'%'+N'" + key + "'+N'%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSP.DataSource = dt;
                return;
            }
            else if(radioButton3.Checked==true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SP where GiaTien like N'%'+N'" + key + "'+N'%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSP.DataSource = dt;
                return;
            }
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            LoadData();
        }
    }
}
