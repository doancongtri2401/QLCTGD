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
    public partial class frmKhoanVay : Form
    {
        private string connectionString = "Data Source=WINDOWS-PC\\CONGTRI;Initial Catalog=QLCTGD;Integrated Security=True;";

        public frmKhoanVay()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmKhoanVay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCTGDDataSet4.Khoan_Vay' table. You can move, or remove it, as needed.
            this.khoan_VayTableAdapter.Fill(this.qLCTGDDataSet4.Khoan_Vay);
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Khoan_Vay";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Khoan_Vay (ID_khoanvay, So_tienvay, Nguon_vay, Lai_suat, Ngay_vay, Ngay_thanhtoan, ID_nguoidung) " +
                               "VALUES (@ID, @SoTien, @NguonVay, @LaiSuat, @NgayVay, @NgayThanhToan, @IDNguoiDung)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@SoTien", textBox2.Text);
                cmd.Parameters.AddWithValue("@NguonVay", textBox3.Text);
                cmd.Parameters.AddWithValue("@LaiSuat", textBox4.Text);
                cmd.Parameters.AddWithValue("@NgayVay", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@NgayThanhToan", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@IDNguoiDung", comboBox1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khoản vay thành công!");

                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Khoan_Vay SET ID_khoanvay=@ID, So_tienvay=@SoTien, Nguon_vay=@NguonVay, Lai_suat=@LaiSuat, " +
                               "Ngay_vay=@NgayVay, Ngay_thanhtoan=@NgayThanhToan, ID_nguoidung=@IDNguoiDung WHERE ID_khoanvay=@ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@SoTien", textBox2.Text);
                cmd.Parameters.AddWithValue("@NguonVay", textBox3.Text);
                cmd.Parameters.AddWithValue("@LaiSuat", textBox4.Text);
                cmd.Parameters.AddWithValue("@NgayVay", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@NgayThanhToan", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@IDNguoiDung", comboBox1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa khoản vay thành công!");

                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Khoan_Vay WHERE ID_khoanvay=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa khoản vay thành công!");

                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["iDkhoanvayDataGridViewTextBoxColumn"].Value.ToString();
                textBox2.Text = row.Cells["sotienvayDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = row.Cells["nguonvayDataGridViewTextBoxColumn"].Value.ToString();
                textBox4.Text = row.Cells["laisuatDataGridViewTextBoxColumn"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngayvayDataGridViewTextBoxColumn"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["ngaythanhtoanDataGridViewTextBoxColumn"].Value);
                comboBox1.Text = row.Cells["iDnguoidungDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDkhoanvayDataGridViewTextBoxColumn"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Khoan_Vay SET Ngay_vay = @NgayVay WHERE ID_khoanvay = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayVay", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDkhoanvayDataGridViewTextBoxColumn"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Khoan_Vay SET Ngay_thanhtoan = @NgayTT WHERE ID_khoanvay = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayTT", dateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ID_nguoidung FROM Nguoi_Dung"; // Thay 'DanhMuc' bằng bảng bạn muốn lấy
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "iDnguoidungDataGridViewTextBoxColumn"; // Cột hiển thị
                    comboBox1.ValueMember = "ID_nguoidung";   // Giá trị thực tế

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
            
         
