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
    public partial class frmQLGD : Form
    {
        private string connectionString = "Data Source=WINDOWS-PC\\CONGTRI;Initial Catalog=QLCTGD;Integrated Security=True;";
        public frmQLGD()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxData();
        }

        private void frmQLGD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCTGDDataSet.Giao_Dich' table. You can move, or remove it, as needed.
            this.giao_DichTableAdapter.Fill(this.qLCTGDDataSet.Giao_Dich);

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Giao_Dich";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Giao_Dich (ID_giaodich, Loai_giaodich, Ngay_giaodich, So_tien, Ghi_chu, ID_danhmuc, ID_nguoidung) " +
                               "VALUES (@IDGD, @LoaiGiaoDich, @NgayGiaoDich, @SoTien, @GhiChu, @IDDanhMuc, @IDNguoiDung)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDGD", textBox3.Text);
                cmd.Parameters.AddWithValue("@LoaiGiaoDich", comboBox2.Text);
                cmd.Parameters.AddWithValue("@NgayGiaoDich", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SoTien", decimal.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@GhiChu", textBox2.Text);
                cmd.Parameters.AddWithValue("@IDDanhMuc", comboBox3.Text);
                cmd.Parameters.AddWithValue("@IDNguoiDung", comboBox4.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm giao dịch thành công!");
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giao dịch để sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Giao_Dich SET ID_giaodich = @IDGD, Loai_giaodich = @LoaiGiaoDich, Ngay_giaodich = @NgayGiaoDich, " +
                               "So_tien = @SoTien, Ghi_chu = @GhiChu, ID_danhmuc = @IDDanhMuc, ID_nguoidung = @IDNguoiDung " +
                               "WHERE ID_giaodich = @IDGD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDGD", textBox3.Text);
                cmd.Parameters.AddWithValue("@LoaiGiaoDich", comboBox2.Text);
                cmd.Parameters.AddWithValue("@NgayGiaoDich", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SoTien", decimal.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@GhiChu", textBox2.Text);
                cmd.Parameters.AddWithValue("@IDDanhMuc", comboBox3.Text);
                cmd.Parameters.AddWithValue("@IDNguoiDung", comboBox4.Text);
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa giao dịch thành công!");
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            if (textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giao dịch để xóa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Giao_Dich WHERE ID_giaodich = @IDGiaoDich";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDGiaoDich", textBox3.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa giao dịch thành công!");
                LoadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDgiaodichDataGridViewTextBoxColumn"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Giao_Dich SET Ngay_giaodich = @NgayGD WHERE ID_giaodich = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayGD", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Cập nhật lại DataGridView sau khi thay đổi
                LoadData();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Loai_giaodich FROM Giao_Dich"; // Thay 'DanhMuc' bằng bảng bạn muốn lấy
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "loaigiaodichDataGridViewTextBoxColumn"; // Cột hiển thị
                    comboBox2.ValueMember = "Loai_giaodich";   // Giá trị thực tế

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                try
                {
                    string query = "SELECT ID_danhmuc FROM Danh_Muc"; // Thay 'DanhMuc' bằng bảng bạn muốn lấy
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox3.DataSource = dt;
                    comboBox3.DisplayMember = "iDdanhmucDataGridViewTextBoxColumn"; // Cột hiển thị
                    comboBox3.ValueMember = "ID_danhmuc";   // Giá trị thực tế

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                try
                {
                    string query = "SELECT ID_nguoidung FROM Nguoi_Dung"; // Thay 'DanhMuc' bằng bảng bạn muốn lấy
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox4.DataSource = dt;
                    comboBox4.DisplayMember = "iDnguoidungDataGridViewTextBoxColumn"; // Cột hiển thị
                    comboBox4.ValueMember = "ID_nguoidung";   // Giá trị thực tế

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra có chọn hàng hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox và điều khiển
                textBox3.Text = row.Cells["iDgiaodichDataGridViewTextBoxColumn"].Value.ToString();
                comboBox2.SelectedValue = row.Cells["loaigiaodichDataGridViewTextBoxColumn"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngaygiaodichDataGridViewTextBoxColumn"].Value);
                textBox1.Text = row.Cells["sotienDataGridViewTextBoxColumn"].Value.ToString();
                textBox2.Text = row.Cells["ghichuDataGridViewTextBoxColumn"].Value.ToString();
                comboBox3.SelectedValue = row.Cells["iDdanhmucDataGridViewTextBoxColumn"].Value;
                comboBox4.SelectedValue = row.Cells["iDnguoidungDataGridViewTextBoxColumn"].Value;
            }
        }
    }
}
