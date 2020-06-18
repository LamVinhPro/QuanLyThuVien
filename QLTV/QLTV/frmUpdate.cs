using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmUpdate : Form
    {
        QL_DangNhap CauHinh = new QL_DangNhap();

        public frmUpdate()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text);
            this.Close();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = CauHinh.GetServerName();
            comboBox1.DisplayMember = "ServerName";
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.DataSource = CauHinh.GetDBName(comboBox1.Text, textBox1.Text, textBox2.Text);
            comboBox2.DisplayMember = "name";
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
