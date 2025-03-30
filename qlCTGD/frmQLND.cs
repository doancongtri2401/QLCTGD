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
    public partial class frmQLND : Form
    {
        private string connectionString = "Data Source=WINDOWS-PC\\CONGTRI;Initial Catalog=QLCTGD;Integrated Security=True;";

        public frmQLND()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmQLND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCTGDDataSet3.Nguoi_Dung' table. You can move, or remove it, as needed.
            this.nguoi_DungTableAdapter.Fill(this.qLCTGDDataSet3.Nguoi_Dung);
            LoadData();
            comboBox1.Items.Add("0 - User");
            comboBox1.Items.Add("1 - Admin");
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Nguoi_Dung";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Nguoi_Dung (ID_nguoidung, Ten_dangnhap, Mat_khau, Vai_tro) VALUES (@id, @tendangnhap, @matkhau, @vaitro)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@tendangnhap", textBox2.Text);
                cmd.Parameters.AddWithValue("@matkhau", textBox3.Text);
                cmd.Parameters.AddWithValue("@vaitro", comboBox1.SelectedIndex);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm người dùng thành công!");
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Nguoi_Dung SET Ten_dangnhap = @tendangnhap, Mat_khau = @matkhau, Vai_tro = @vaitro WHERE ID_nguoidung = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@tendangnhap", textBox2.Text);
                cmd.Parameters.AddWithValue("@matkhau", textBox3.Text);
                cmd.Parameters.AddWithValue("@vaitro", comboBox1.SelectedIndex);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật người dùng thành công!");
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Nguoi_Dung WHERE ID_nguoidung = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa người dùng thành công!");
                    LoadData();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["iDnguoidungDataGridViewTextBoxColumn"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["tendangnhapDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["matkhauDataGridViewTextBoxColumn"].Value.ToString();
                comboBox1.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["vaitroDataGridViewTextBoxColumn"].Value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

