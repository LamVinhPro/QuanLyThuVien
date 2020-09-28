using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DLL;

namespace DA_QLTV
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            loadcbb();
            load();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
           
        }
        void load()
        {
            TaiLieuu tl = new TaiLieuu();
            string matailieu = tl.laymatailieu(comboBox1.Text);
            // TODO: This line of code loads data into the 'DataSet1.QL_ChiTietTaiLieu' table. You can move, or remove it, as needed.
          //  this.QL_ChiTietTaiLieuTableAdapter.Fill(this.DataSet1.QL_ChiTietTaiLieu, matailieu);
            this.QL_ChiTietTaiLieuTableAdapter.FillBy(this.DataSet1.QL_ChiTietTaiLieu);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            comboBox1.Enabled = false;
        }
        void loadcbb()
        {
            TaiLieuu tl = new TaiLieuu();
            comboBox1.DataSource = tl.loadcbbtailieu();
          
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiLieuu tl = new TaiLieuu();
            string matailieu = tl.laymatailieu(comboBox1.Text);
            // TODO: This line of code loads data into the 'DataSet1.QL_ChiTietTaiLieu' table. You can move, or remove it, as needed.
            this.QL_ChiTietTaiLieuTableAdapter.Fill(this.DataSet1.QL_ChiTietTaiLieu, matailieu);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void rbtntheloai_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void rbtntatca_CheckedChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
