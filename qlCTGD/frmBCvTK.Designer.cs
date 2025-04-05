namespace qlCTGD
{
    partial class frmBCvTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDbaocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytaobaocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongthunhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongchitieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtietkiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnguoidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoCaoChiTieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCTGDDataSet2 = new qlCTGD.QLCTGDDataSet2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bao_CaoChiTieuTableAdapter = new qlCTGD.QLCTGDDataSet2TableAdapters.Bao_CaoChiTieuTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoChiTieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCTGDDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(25, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 256);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng báo cáo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDbaocaoDataGridViewTextBoxColumn,
            this.ngaytaobaocaoDataGridViewTextBoxColumn,
            this.tongthunhapDataGridViewTextBoxColumn,
            this.tongchitieuDataGridViewTextBoxColumn,
            this.tongtietkiemDataGridViewTextBoxColumn,
            this.iDnguoidungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.baoCaoChiTieuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDbaocaoDataGridViewTextBoxColumn
            // 
            this.iDbaocaoDataGridViewTextBoxColumn.DataPropertyName = "ID_baocao";
            this.iDbaocaoDataGridViewTextBoxColumn.HeaderText = "ID_baocao";
            this.iDbaocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDbaocaoDataGridViewTextBoxColumn.Name = "iDbaocaoDataGridViewTextBoxColumn";
            this.iDbaocaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaytaobaocaoDataGridViewTextBoxColumn
            // 
            this.ngaytaobaocaoDataGridViewTextBoxColumn.DataPropertyName = "Ngay_taobaocao";
            this.ngaytaobaocaoDataGridViewTextBoxColumn.HeaderText = "Ngay_taobaocao";
            this.ngaytaobaocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaytaobaocaoDataGridViewTextBoxColumn.Name = "ngaytaobaocaoDataGridViewTextBoxColumn";
            this.ngaytaobaocaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongthunhapDataGridViewTextBoxColumn
            // 
            this.tongthunhapDataGridViewTextBoxColumn.DataPropertyName = "Tong_thunhap";
            this.tongthunhapDataGridViewTextBoxColumn.HeaderText = "Tong_thunhap";
            this.tongthunhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongthunhapDataGridViewTextBoxColumn.Name = "tongthunhapDataGridViewTextBoxColumn";
            this.tongthunhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongchitieuDataGridViewTextBoxColumn
            // 
            this.tongchitieuDataGridViewTextBoxColumn.DataPropertyName = "Tong_chitieu";
            this.tongchitieuDataGridViewTextBoxColumn.HeaderText = "Tong_chitieu";
            this.tongchitieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongchitieuDataGridViewTextBoxColumn.Name = "tongchitieuDataGridViewTextBoxColumn";
            this.tongchitieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongtietkiemDataGridViewTextBoxColumn
            // 
            this.tongtietkiemDataGridViewTextBoxColumn.DataPropertyName = "Tong_tietkiem";
            this.tongtietkiemDataGridViewTextBoxColumn.HeaderText = "Tong_tietkiem";
            this.tongtietkiemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongtietkiemDataGridViewTextBoxColumn.Name = "tongtietkiemDataGridViewTextBoxColumn";
            this.tongtietkiemDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDnguoidungDataGridViewTextBoxColumn
            // 
            this.iDnguoidungDataGridViewTextBoxColumn.DataPropertyName = "ID_nguoidung";
            this.iDnguoidungDataGridViewTextBoxColumn.HeaderText = "ID_nguoidung";
            this.iDnguoidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDnguoidungDataGridViewTextBoxColumn.Name = "iDnguoidungDataGridViewTextBoxColumn";
            this.iDnguoidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // baoCaoChiTieuBindingSource
            // 
            this.baoCaoChiTieuBindingSource.DataMember = "Bao_CaoChiTieu";
            this.baoCaoChiTieuBindingSource.DataSource = this.qLCTGDDataSet2;
            // 
            // qLCTGDDataSet2
            // 
            this.qLCTGDDataSet2.DataSetName = "QLCTGDDataSet2";
            this.qLCTGDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo chi tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng thu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tổng chi tiêu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiết kiệm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày báo cáo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bao_CaoChiTieuTableAdapter
            // 
            this.bao_CaoChiTieuTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tạo báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xóa báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID báo cáo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID người dùng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 22);
            this.textBox4.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sửa báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(801, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 50);
            this.button4.TabIndex = 17;
            this.button4.Text = "Xuất báo cáo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmBCvTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 547);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBCvTK";
            this.Text = "Báo cáo chi tiêu";
            this.Load += new System.EventHandler(this.frmBCvTK_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoChiTieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCTGDDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLCTGDDataSet2 qLCTGDDataSet2;
        private System.Windows.Forms.BindingSource baoCaoChiTieuBindingSource;
        private QLCTGDDataSet2TableAdapters.Bao_CaoChiTieuTableAdapter bao_CaoChiTieuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbaocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytaobaocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongthunhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongchitieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtietkiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnguoidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}