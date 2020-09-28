namespace DA_QLTV
{
    partial class frmNguoiDung
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
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new JTextBox.JText_Box();
            this.txtMatKhau = new JTextBox.JText_Box();
            this.txtMaNhom = new JTextBox.JText_Box();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttennhom2 = new JTextBox.JText_Box();
            this.txtmanhom2 = new JTextBox.JText_Box();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.btnxoa2 = new System.Windows.Forms.Button();
            this.btnsua2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnluuw2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.column3});
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(30, 31);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.RowHeadersWidth = 62;
            this.dataGridViewNguoiDung.RowTemplate.Height = 28;
            this.dataGridViewNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(559, 220);
            this.dataGridViewNguoiDung.TabIndex = 2;
            this.dataGridViewNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoiDung_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NgườiDùng";
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MatKhau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            // 
            // column3
            // 
            this.column3.DataPropertyName = "MaNhom";
            this.column3.HeaderText = "Mã nhóm";
            this.column3.Name = "column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên ĐN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhóm";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.BorderThickness = 1;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(168, 272);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenDangNhap.MaxLength = 32767;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.onFocusBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.RoundedBorder = 0;
            this.txtTenDangNhap.Size = new System.Drawing.Size(210, 41);
            this.txtTenDangNhap.TabIndex = 14;
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenDangNhap.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDangNhap.TextInput = "";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txtMatKhau.BorderThickness = 1;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.Location = new System.Drawing.Point(168, 345);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.onFocusBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.RoundedBorder = 0;
            this.txtMatKhau.Size = new System.Drawing.Size(210, 41);
            this.txtMatKhau.TabIndex = 15;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.TextInput = "";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.BorderColor = System.Drawing.Color.Black;
            this.txtMaNhom.BorderThickness = 1;
            this.txtMaNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhom.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNhom.Location = new System.Drawing.Point(168, 487);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNhom.MaxLength = 32767;
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.onFocusBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaNhom.PasswordChar = '\0';
            this.txtMaNhom.RoundedBorder = 0;
            this.txtMaNhom.Size = new System.Drawing.Size(210, 41);
            this.txtMaNhom.TabIndex = 17;
            this.txtMaNhom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNhom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNhom.TextInput = "";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(441, 272);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(148, 59);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(441, 421);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(148, 59);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(441, 345);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(148, 59);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(441, 497);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(148, 59);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 120;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(168, 421);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 31);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewNguoiDung);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMaNhom);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 559);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txttennhom2
            // 
            this.txttennhom2.BorderColor = System.Drawing.Color.Black;
            this.txttennhom2.BorderThickness = 1;
            this.txttennhom2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhom2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhom2.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhom2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttennhom2.Location = new System.Drawing.Point(168, 345);
            this.txttennhom2.Margin = new System.Windows.Forms.Padding(5);
            this.txttennhom2.MaxLength = 32767;
            this.txttennhom2.Name = "txttennhom2";
            this.txttennhom2.onFocusBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txttennhom2.PasswordChar = '\0';
            this.txttennhom2.RoundedBorder = 0;
            this.txttennhom2.Size = new System.Drawing.Size(210, 41);
            this.txttennhom2.TabIndex = 15;
            this.txttennhom2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttennhom2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttennhom2.TextInput = "";
            // 
            // txtmanhom2
            // 
            this.txtmanhom2.BorderColor = System.Drawing.Color.Black;
            this.txtmanhom2.BorderThickness = 1;
            this.txtmanhom2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhom2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhom2.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhom2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmanhom2.Location = new System.Drawing.Point(168, 272);
            this.txtmanhom2.Margin = new System.Windows.Forms.Padding(5);
            this.txtmanhom2.MaxLength = 32767;
            this.txtmanhom2.Name = "txtmanhom2";
            this.txtmanhom2.onFocusBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtmanhom2.PasswordChar = '\0';
            this.txtmanhom2.RoundedBorder = 0;
            this.txtmanhom2.Size = new System.Drawing.Size(210, 41);
            this.txtmanhom2.TabIndex = 14;
            this.txtmanhom2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmanhom2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmanhom2.TextInput = "";
            // 
            // btnthem2
            // 
            this.btnthem2.Location = new System.Drawing.Point(441, 272);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(148, 59);
            this.btnthem2.TabIndex = 18;
            this.btnthem2.Text = "Thêm";
            this.btnthem2.UseVisualStyleBackColor = true;
            this.btnthem2.Click += new System.EventHandler(this.btnthem2_Click);
            // 
            // btnxoa2
            // 
            this.btnxoa2.Location = new System.Drawing.Point(441, 421);
            this.btnxoa2.Name = "btnxoa2";
            this.btnxoa2.Size = new System.Drawing.Size(148, 59);
            this.btnxoa2.TabIndex = 19;
            this.btnxoa2.Text = "Xóa";
            this.btnxoa2.UseVisualStyleBackColor = true;
            this.btnxoa2.Click += new System.EventHandler(this.btnxoa2_Click);
            // 
            // btnsua2
            // 
            this.btnsua2.Location = new System.Drawing.Point(441, 345);
            this.btnsua2.Name = "btnsua2";
            this.btnsua2.Size = new System.Drawing.Size(148, 59);
            this.btnsua2.TabIndex = 20;
            this.btnsua2.Text = "Sửa";
            this.btnsua2.UseVisualStyleBackColor = true;
            this.btnsua2.Click += new System.EventHandler(this.btnsua2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhóm";
            // 
            // btnluuw2
            // 
            this.btnluuw2.Location = new System.Drawing.Point(441, 497);
            this.btnluuw2.Name = "btnluuw2";
            this.btnluuw2.Size = new System.Drawing.Size(148, 59);
            this.btnluuw2.TabIndex = 21;
            this.btnluuw2.Text = "Lưu";
            this.btnluuw2.UseVisualStyleBackColor = true;
            this.btnluuw2.Click += new System.EventHandler(this.btnluuw2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã nhóm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(30, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(559, 220);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnluuw2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnsua2);
            this.groupBox2.Controls.Add(this.btnxoa2);
            this.groupBox2.Controls.Add(this.btnthem2);
            this.groupBox2.Controls.Add(this.txtmanhom2);
            this.groupBox2.Controls.Add(this.txttennhom2);
            this.groupBox2.Location = new System.Drawing.Point(652, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 559);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhóm người dùng";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1280, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNguoiDung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private JTextBox.JText_Box txtTenDangNhap;
        private JTextBox.JText_Box txtMatKhau;
        private JTextBox.JText_Box txtMaNhom;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private JTextBox.JText_Box txttennhom2;
        private JTextBox.JText_Box txtmanhom2;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Button btnxoa2;
        private System.Windows.Forms.Button btnsua2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnluuw2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}