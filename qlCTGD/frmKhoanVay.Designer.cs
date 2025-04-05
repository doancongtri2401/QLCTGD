namespace qlCTGD
{
    partial class frmKhoanVay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDkhoanvayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienvayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguonvayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laisuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnguoidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoanVayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCTGDDataSet4 = new qlCTGD.QLCTGDDataSet4();
            this.khoan_VayTableAdapter = new qlCTGD.QLCTGDDataSet4TableAdapters.Khoan_VayTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoanVayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCTGDDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoản vay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID khoản vay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tiền vay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nguồn vay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lãi suất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày vay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày thanh toán";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID người dùng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(252, 22);
            this.textBox4.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 246);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 228);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng khoản vay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkhoanvayDataGridViewTextBoxColumn,
            this.sotienvayDataGridViewTextBoxColumn,
            this.nguonvayDataGridViewTextBoxColumn,
            this.laisuatDataGridViewTextBoxColumn,
            this.ngayvayDataGridViewTextBoxColumn,
            this.ngaythanhtoanDataGridViewTextBoxColumn,
            this.iDnguoidungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khoanVayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-48, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDkhoanvayDataGridViewTextBoxColumn
            // 
            this.iDkhoanvayDataGridViewTextBoxColumn.DataPropertyName = "ID_khoanvay";
            this.iDkhoanvayDataGridViewTextBoxColumn.HeaderText = "ID_khoanvay";
            this.iDkhoanvayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDkhoanvayDataGridViewTextBoxColumn.Name = "iDkhoanvayDataGridViewTextBoxColumn";
            this.iDkhoanvayDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotienvayDataGridViewTextBoxColumn
            // 
            this.sotienvayDataGridViewTextBoxColumn.DataPropertyName = "So_tienvay";
            this.sotienvayDataGridViewTextBoxColumn.HeaderText = "So_tienvay";
            this.sotienvayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sotienvayDataGridViewTextBoxColumn.Name = "sotienvayDataGridViewTextBoxColumn";
            this.sotienvayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nguonvayDataGridViewTextBoxColumn
            // 
            this.nguonvayDataGridViewTextBoxColumn.DataPropertyName = "Nguon_vay";
            this.nguonvayDataGridViewTextBoxColumn.HeaderText = "Nguon_vay";
            this.nguonvayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguonvayDataGridViewTextBoxColumn.Name = "nguonvayDataGridViewTextBoxColumn";
            this.nguonvayDataGridViewTextBoxColumn.Width = 125;
            // 
            // laisuatDataGridViewTextBoxColumn
            // 
            this.laisuatDataGridViewTextBoxColumn.DataPropertyName = "Lai_suat";
            this.laisuatDataGridViewTextBoxColumn.HeaderText = "Lai_suat";
            this.laisuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laisuatDataGridViewTextBoxColumn.Name = "laisuatDataGridViewTextBoxColumn";
            this.laisuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayvayDataGridViewTextBoxColumn
            // 
            this.ngayvayDataGridViewTextBoxColumn.DataPropertyName = "Ngay_vay";
            this.ngayvayDataGridViewTextBoxColumn.HeaderText = "Ngay_vay";
            this.ngayvayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayvayDataGridViewTextBoxColumn.Name = "ngayvayDataGridViewTextBoxColumn";
            this.ngayvayDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaythanhtoanDataGridViewTextBoxColumn
            // 
            this.ngaythanhtoanDataGridViewTextBoxColumn.DataPropertyName = "Ngay_thanhtoan";
            this.ngaythanhtoanDataGridViewTextBoxColumn.HeaderText = "Ngay_thanhtoan";
            this.ngaythanhtoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaythanhtoanDataGridViewTextBoxColumn.Name = "ngaythanhtoanDataGridViewTextBoxColumn";
            this.ngaythanhtoanDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDnguoidungDataGridViewTextBoxColumn
            // 
            this.iDnguoidungDataGridViewTextBoxColumn.DataPropertyName = "ID_nguoidung";
            this.iDnguoidungDataGridViewTextBoxColumn.HeaderText = "ID_nguoidung";
            this.iDnguoidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDnguoidungDataGridViewTextBoxColumn.Name = "iDnguoidungDataGridViewTextBoxColumn";
            this.iDnguoidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // khoanVayBindingSource
            // 
            this.khoanVayBindingSource.DataMember = "Khoan_Vay";
            this.khoanVayBindingSource.DataSource = this.qLCTGDDataSet4;
            // 
            // qLCTGDDataSet4
            // 
            this.qLCTGDDataSet4.DataSetName = "QLCTGDDataSet4";
            this.qLCTGDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoan_VayTableAdapter
            // 
            this.khoan_VayTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhoanVay";
            this.Text = "frmKhoanVay";
            this.Load += new System.EventHandler(this.frmKhoanVay_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoanVayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCTGDDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLCTGDDataSet4 qLCTGDDataSet4;
        private System.Windows.Forms.BindingSource khoanVayBindingSource;
        private QLCTGDDataSet4TableAdapters.Khoan_VayTableAdapter khoan_VayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkhoanvayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienvayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguonvayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laisuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnguoidungDataGridViewTextBoxColumn;
    }
}