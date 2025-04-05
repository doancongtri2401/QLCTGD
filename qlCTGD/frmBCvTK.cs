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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlCTGD
{
    public partial class frmBCvTK : Form
    {
        private string connectionString = "Data Source=WINDOWS-PC\\CONGTRI;Initial Catalog=QLCTGD;Integrated Security=True;";
        public frmBCvTK()
        {
            InitializeComponent();
            LoadBaoCao();
            LoadComboBoxData();
        }

        private void frmBCvTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCTGDDataSet2.Bao_CaoChiTieu' table. You can move, or remove it, as needed.
            this.bao_CaoChiTieuTableAdapter.Fill(this.qLCTGDDataSet2.Bao_CaoChiTieu);

        }

        private void LoadBaoCao()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Bao_CaoChiTieu";
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
                string query = "INSERT INTO Bao_CaoChiTieu (ID_baocao, Ngay_taobaocao, Tong_thunhap, Tong_chitieu, Tong_tietkiem, ID_nguoidung) " +
                               "VALUES (@ID, @Ngay, @ThuNhap, @ChiTieu, @TietKiem, @IDNguoiSD)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox4.Text);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ThuNhap", textBox1.Text);
                cmd.Parameters.AddWithValue("@ChiTieu", textBox2.Text);
                cmd.Parameters.AddWithValue("@TietKiem", textBox3.Text);
                cmd.Parameters.AddWithValue("@IDNguoiSD", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo báo cáo thành công!");
                LoadBaoCao();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa báo cáo này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Bao_CaoChiTieu WHERE ID_baocao = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa báo cáo thành công!");
                    LoadBaoCao();
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
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDbaocaoDataGridViewTextBoxColumn"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Bao_CaoChiTieu SET Ngay_taobaocao = @NgayBC WHERE ID_baocao = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayBC", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Cập nhật lại DataGridView sau khi thay đổi
                LoadBaoCao();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                textBox4.Text = row.Cells["iDbaocaoDataGridViewTextBoxColumn"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngaytaobaocaoDataGridViewTextBoxColumn"].Value);
                textBox1.Text = row.Cells["tongthunhapDataGridViewTextBoxColumn"].Value.ToString();
                textBox2.Text = row.Cells["tongchitieuDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = row.Cells["tongtietkiemDataGridViewTextBoxColumn"].Value.ToString();
                comboBox1.Text = row.Cells["iDnguoidungDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Bao_CaoChiTieu SET ID_baocao = @ID, Ngay_taobaocao = @Ngay, Tong_thunhap = @ThuNhap, Tong_chitieu = @ChiTieu, " +
                               "Tong_tietkiem = @TietKiem, ID_nguoidung = @IDNguoiSD WHERE ID_baocao = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBox4.Text);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ThuNhap", textBox1.Text);
                cmd.Parameters.AddWithValue("@ChiTieu", textBox2.Text);
                cmd.Parameters.AddWithValue("@TietKiem", textBox3.Text);
                cmd.Parameters.AddWithValue("@IDNguoiSD", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật báo cáo thành công!");
                LoadBaoCao();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TinhTongChiTieu();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TinhTongChiTieu();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TinhTongChiTieu()
        {
            if (decimal.TryParse(textBox1.Text, out decimal Tong_thunhap) &&
                decimal.TryParse(textBox3.Text, out decimal Tong_tietkiem))
            {
                decimal Tong_chitieu = Tong_thunhap - Tong_tietkiem;
                textBox2.Text = Tong_chitieu.ToString();
            }
            else
            {
                textBox2.Text = "0"; // Tránh lỗi khi nhập không hợp lệ
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo nội dung báo cáo
                string reportContent = "====== BÁO CÁO CHI TIÊU ======\n";
                reportContent += $"ID báo cáo: {textBox4.Text}\n";
                reportContent += $"Ngày báo cáo: {dateTimePicker1.Value.ToString("dd/MM/yyyy")}\n";
                reportContent += $"Tổng thu nhập: {textBox1.Text}\n";
                reportContent += $"Tổng chi tiêu: {textBox2.Text}\n";
                reportContent += $"Tổng tiết kiệm: {textBox3.Text}\n";
                reportContent += $"ID Người dùng: {comboBox1.SelectedValue}\n";
                reportContent += "==================================\n";

                // Hộp thoại chọn vị trí lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt";
                saveFileDialog.Title = "Lưu báo cáo chi tiêu";
                saveFileDialog.FileName = $"BaoCaoChiTieu_{DateTime.Now:yyyyMMdd}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, reportContent);
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
