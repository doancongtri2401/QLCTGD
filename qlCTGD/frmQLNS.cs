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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlCTGD
{
    public partial class frmQLNS : Form
    {
        private string connectionString = "Data Source=WINDOWS-PC\\CONGTRI;Initial Catalog=QLCTGD;Integrated Security=True";

        public frmQLNS()
        {
            InitializeComponent();
            LoadNgan_Sach();
            LoadComboBoxData();
        }

        private void frmQLNS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCTGDDataSet1.Ngan_Sach' table. You can move, or remove it, as needed.
            this.ngan_SachTableAdapter.Fill(this.qLCTGDDataSet1.Ngan_Sach);

        }

        private void LoadNgan_Sach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Ngan_Sach";
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
                string query = "INSERT INTO Ngan_Sach (ID_ngansach, Ten_ngansach, Gioi_hanchitieu, Khoang_thoigian, ID_nguoidung) " +
                               "VALUES (@ID, @Ten, @GioiHan, @KhoangTG, @IDNguoiSD)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox3.Text);
                cmd.Parameters.AddWithValue("@Ten", textBox1.Text);
                cmd.Parameters.AddWithValue("@GioiHan", textBox2.Text);
                cmd.Parameters.AddWithValue("@KhoangTG", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@IDNguoiSD", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm ngân sách thành công!");
                LoadNgan_Sach();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Ngan_Sach SET ID_ngansach = @ID, Ten_ngansach = @Ten, Gioi_hanchitieu = @GioiHan, " +
                               "Khoang_thoigian = @KhoangTG, ID_nguoidung = @IDNguoiSD WHERE ID_ngansach = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox3.Text);
                cmd.Parameters.AddWithValue("@Ten",textBox1.Text);
                cmd.Parameters.AddWithValue("@GioiHan", textBox2.Text);
                cmd.Parameters.AddWithValue("@KhoangTG", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@IDNguoiSD", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật ngân sách thành công!");
                LoadNgan_Sach();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Ngan_Sach WHERE ID_ngansach = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa ngân sách thành công!");
                    LoadNgan_Sach();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDngansachDataGridViewTextBoxColumn"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Ngan_Sach SET Khoang_thoigian = @KhoangTG WHERE ID_ngansach = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KhoangTG", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Cập nhật lại DataGridView sau khi thay đổi
                LoadNgan_Sach();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox3.Text = row.Cells["iDngansachDataGridViewTextBoxColumn"].Value.ToString();
                textBox1.Text = row.Cells["tenngansachDataGridViewTextBoxColumn"].Value.ToString();
                textBox2.Text = row.Cells["gioihanchitieuDataGridViewTextBoxColumn"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["khoangthoigianDataGridViewTextBoxColumn"].Value);
                comboBox1.Text = row.Cells["iDnguoidungDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
    }
}
    

        
    
