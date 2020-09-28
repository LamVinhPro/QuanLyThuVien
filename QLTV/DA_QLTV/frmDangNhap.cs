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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            if (string.IsNullOrEmpty(txtTenDangNhap.TextName.Trim()))
            {
                MessageBox.Show("Không được bỏ trống ");
                this.txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.TextName.Trim()))
            {
                MessageBox.Show("không được bỏ trống ");
                this.txtMatKhau.Focus();
                return;
            }
            int kq = dn.Check_config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập


            }
        }

        public void ProcessLogin()
        {
            DangNhap dn = new DangNhap();
            int result;
            result = dn.Check_User(txtTenDangNhap.TextName, txtMatKhau.TextName);
            if (result == 99)
            {
                MessageBox.Show("Sai ");
                return;
            }
            else if (result == 100)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            this.Visible = false;



            // xu li luu tai khoan mat khau, khi check vao checkbox
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.user = txtTenDangNhap.TextName;
                Properties.Settings.Default.pass = txtMatKhau.TextName;
                Properties.Settings.Default.checkbox = 1;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.checkbox = 0;
                Properties.Settings.Default.Save();
            }
            // xu li truyen du lieu ma nhom qua frm main
        
            dataGridView1.DataSource = dn.kiemTraTenDangNhap(txtTenDangNhap.TextName);
            string manhom = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            frmMain frmmain = new frmMain(txtTenDangNhap.TextName, txtMatKhau.TextName, manhom);
            this.Hide();
            frmmain.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //DangNhap dn = new DangNhap();
            //if (dn.kiemTra(txtTenDangNhap.TextName) == true)
            //{
            //    MessageBox.Show("ok");
            //}
            //else
            //{
            //    MessageBox.Show("cc");
            //}
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            txtTenDangNhap.Focus();
            txtTenDangNhap.TextName = Properties.Settings.Default.user;
            txtMatKhau.TextName = Properties.Settings.Default.pass;
            if (Properties.Settings.Default.checkbox == 1)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
