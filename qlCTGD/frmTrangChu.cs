using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlCTGD
{
    public partial class frmTrangChu : Form
    {
        private int userRole;

        public frmTrangChu(int role)
        {
            InitializeComponent();
            this.userRole = role;
            SetPermissions();
        }

        private void SetPermissions()
        {
            if (userRole == 0) // Nếu là User
            {
                button1.Enabled = false;  // Ẩn chức năng quản lý người dùng
                button2.Enabled = false;  // Ẩn chức năng báo cáo tài chính
            }
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCTGDDataSet.Giao_Dich' table. You can move, or remove it, as needed.
            this.giao_DichTableAdapter.Fill(this.qLCTGDDataSet.Giao_Dich);
            this.IsMdiContainer = true; // Đặt form này là MDI Container
        }
        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmQLGD();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ngânSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmQLNS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDN();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmQLND();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmBCvTK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Hiển thị lại form đăng nhập
                frmDN loginForm = new frmDN();
                loginForm.Show();

                // Đóng form hiện tại
                this.Close();
            }
        }

        private void khoảnVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKhoanVay();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}







