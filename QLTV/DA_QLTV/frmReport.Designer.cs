namespace DA_QLTV
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.QL_ChiTietTaiLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new DA_QLTV.DataSet1();
            this.QL_ChiTietTaiLieuTableAdapter = new DA_QLTV.DataSet1TableAdapters.QL_ChiTietTaiLieuTableAdapter();
            this.rbtntatca = new System.Windows.Forms.RadioButton();
            this.rbtntheloai = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.QL_ChiTietTaiLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.QL_ChiTietTaiLieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_QLTV.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1256, 590);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xuất theo thể loại";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả"});
            this.comboBox1.Location = new System.Drawing.Point(437, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // QL_ChiTietTaiLieuBindingSource
            // 
            this.QL_ChiTietTaiLieuBindingSource.DataMember = "QL_ChiTietTaiLieu";
            this.QL_ChiTietTaiLieuBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QL_ChiTietTaiLieuTableAdapter
            // 
            this.QL_ChiTietTaiLieuTableAdapter.ClearBeforeFill = true;
            // 
            // rbtntatca
            // 
            this.rbtntatca.AutoSize = true;
            this.rbtntatca.Location = new System.Drawing.Point(214, 25);
            this.rbtntatca.Name = "rbtntatca";
            this.rbtntatca.Size = new System.Drawing.Size(78, 24);
            this.rbtntatca.TabIndex = 4;
            this.rbtntatca.TabStop = true;
            this.rbtntatca.Text = "Tất cả";
            this.rbtntatca.UseVisualStyleBackColor = true;
            this.rbtntatca.CheckedChanged += new System.EventHandler(this.rbtntatca_CheckedChanged);
            // 
            // rbtntheloai
            // 
            this.rbtntheloai.AutoSize = true;
            this.rbtntheloai.Location = new System.Drawing.Point(342, 25);
            this.rbtntheloai.Name = "rbtntheloai";
            this.rbtntheloai.Size = new System.Drawing.Size(89, 24);
            this.rbtntheloai.TabIndex = 5;
            this.rbtntheloai.TabStop = true;
            this.rbtntheloai.Text = "Thể loại";
            this.rbtntheloai.UseVisualStyleBackColor = true;
            this.rbtntheloai.CheckedChanged += new System.EventHandler(this.rbtntheloai_CheckedChanged);
            // 
            // frmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 667);
            this.Controls.Add(this.rbtntheloai);
            this.Controls.Add(this.rbtntatca);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_ChiTietTaiLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource QL_ChiTietTaiLieuBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.QL_ChiTietTaiLieuTableAdapter QL_ChiTietTaiLieuTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbtntatca;
        private System.Windows.Forms.RadioButton rbtntheloai;

    }
}