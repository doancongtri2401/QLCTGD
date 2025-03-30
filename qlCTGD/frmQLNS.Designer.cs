namespace qlCTGD
{
    partial class frmQLNS
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDngansachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenngansachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioihanchitieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoangthoigianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnguoidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCTGDDataSet1 = new qlCTGD.QLCTGDDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.ngan_SachTableAdapter = new qlCTGD.QLCTGDDataSet1TableAdapters.Ngan_SachTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCTGDDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(32, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngân sách";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID người dùng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID ngân sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khoảng thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới hạn chi tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên ngân sách";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(32, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng ngân sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDngansachDataGridViewTextBoxColumn,
            this.tenngansachDataGridViewTextBoxColumn,
            this.gioihanchitieuDataGridViewTextBoxColumn,
            this.khoangthoigianDataGridViewTextBoxColumn,
            this.iDnguoidungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nganSachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDngansachDataGridViewTextBoxColumn
            // 
            this.iDngansachDataGridViewTextBoxColumn.DataPropertyName = "ID_ngansach";
            this.iDngansachDataGridViewTextBoxColumn.HeaderText = "ID_ngansach";
            this.iDngansachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDngansachDataGridViewTextBoxColumn.Name = "iDngansachDataGridViewTextBoxColumn";
            this.iDngansachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenngansachDataGridViewTextBoxColumn
            // 
            this.tenngansachDataGridViewTextBoxColumn.DataPropertyName = "Ten_ngansach";
            this.tenngansachDataGridViewTextBoxColumn.HeaderText = "Ten_ngansach";
            this.tenngansachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenngansachDataGridViewTextBoxColumn.Name = "tenngansachDataGridViewTextBoxColumn";
            this.tenngansachDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioihanchitieuDataGridViewTextBoxColumn
            // 
            this.gioihanchitieuDataGridViewTextBoxColumn.DataPropertyName = "Gioi_hanchitieu";
            this.gioihanchitieuDataGridViewTextBoxColumn.HeaderText = "Gioi_hanchitieu";
            this.gioihanchitieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioihanchitieuDataGridViewTextBoxColumn.Name = "gioihanchitieuDataGridViewTextBoxColumn";
            this.gioihanchitieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // khoangthoigianDataGridViewTextBoxColumn
            // 
            this.khoangthoigianDataGridViewTextBoxColumn.DataPropertyName = "Khoang_thoigian";
            this.khoangthoigianDataGridViewTextBoxColumn.HeaderText = "Khoang_thoigian";
            this.khoangthoigianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoangthoigianDataGridViewTextBoxColumn.Name = "khoangthoigianDataGridViewTextBoxColumn";
            this.khoangthoigianDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDnguoidungDataGridViewTextBoxColumn
            // 
            this.iDnguoidungDataGridViewTextBoxColumn.DataPropertyName = "ID_nguoidung";
            this.iDnguoidungDataGridViewTextBoxColumn.HeaderText = "ID_nguoidung";
            this.iDnguoidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDnguoidungDataGridViewTextBoxColumn.Name = "iDnguoidungDataGridViewTextBoxColumn";
            this.iDnguoidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // nganSachBindingSource
            // 
            this.nganSachBindingSource.DataMember = "Ngan_Sach";
            this.nganSachBindingSource.DataSource = this.qLCTGDDataSet1;
            // 
            // qLCTGDDataSet1
            // 
            this.qLCTGDDataSet1.DataSetName = "QLCTGDDataSet1";
            this.qLCTGDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý ngân sách";
            // 
            // ngan_SachTableAdapter
            // 
            this.ngan_SachTableAdapter.ClearBeforeFill = true;
            // 
            // frmQLNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLNS";
            this.Text = "Quản lý ngân sách";
            this.Load += new System.EventHandler(this.frmQLNS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCTGDDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLCTGDDataSet1 qLCTGDDataSet1;
        private System.Windows.Forms.BindingSource nganSachBindingSource;
        private QLCTGDDataSet1TableAdapters.Ngan_SachTableAdapter ngan_SachTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDngansachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenngansachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioihanchitieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoangthoigianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnguoidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}