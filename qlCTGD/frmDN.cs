using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlCTGD
{
    public partial class frmDN : Form
    {
        private string connectionString = "Data Source=WINDOWS-PC\\CONGTRI;Initial Catalog=QLCTGD;Integrated Security=True;";

        public frmDN()
        {
            InitializeComponent();
        }

        private void frmDN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Vai_tro FROM Nguoi_Dung WHERE Ten_dangnhap = @username AND Mat_khau = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    int userRole = Convert.ToInt32(role);
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmTrangChu frm = new frmTrangChu(userRole); // Truyền vai trò vào form chính
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
