using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using BLL_DLL;

namespace DA_QLTV
{
    public partial class frmNguoiDung : Form
    {
       

        public frmNguoiDung()
        {
            InitializeComponent();
            loadDataG();
            customDataG();
            loadatagridnhomnguoidung();
            loadcbb();
            comboBox1.Height = 100;
            comboBox1.Width = 100;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserMouse, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Selectable, true);
            txttennhom2.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            txtmanhom2.Enabled = false;
            txtMaNhom.Enabled = false;
            comboBox1.Enabled = false;
       
        }
        void loadatagridnhomnguoidung()
        {
            NguoiDung nd = new NguoiDung();
            dataGridView1.DataSource =  nd.loadDataGNhomNguoiDung();
        }
        void loadcbb()
        {
            NguoiDung nd = new NguoiDung();
            comboBox1.DataSource = nd.getCbb();
        }

        string themhaysua = "";
        string themhaysua2 = "";


        void customDataG()
        {
            dataGridViewNguoiDung.BorderStyle = BorderStyle.None;
            dataGridViewNguoiDung.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewNguoiDung.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNguoiDung.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewNguoiDung.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewNguoiDung.BackgroundColor = Color.White;
            dataGridViewNguoiDung.EnableHeadersVisualStyles = false;
            dataGridViewNguoiDung.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewNguoiDung.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void loadDataG()
        {
            NguoiDung nd = new NguoiDung();
            dataGridViewNguoiDung.DataSource = nd.getListNguoiDung();
        }

        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDangNhap.TextInput = dataGridViewNguoiDung.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.TextInput = dataGridViewNguoiDung.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridViewNguoiDung.CurrentRow.Cells[2].Value.ToString();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            txtMaNhom.TextInput = nd.selecttxtMaNhom(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themhaysua = "them";
            txtTenDangNhap.Focus();
            txtTenDangNhap.TextInput = "";
            txtMatKhau.TextInput = "";
            txtMaNhom.TextInput = "";
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            themhaysua = "sua";
            txtMatKhau.Enabled = true;
            txtMatKhau.Focus();
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            if (nd.xoa(txtTenDangNhap.TextInput) == true)
            {
                MessageBox.Show("Xóa thành công!");
                loadDataG();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themhaysua == "them")
            {
                NguoiDung nd = new NguoiDung();
                if (nd.them(txtTenDangNhap.TextInput, txtMatKhau.TextInput, txtMaNhom.TextInput) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    loadDataG();
                    txttennhom2.Enabled = false;
                    txtTenDangNhap.Enabled = false;
                    txtMatKhau.Enabled = false;
                    txtmanhom2.Enabled = false;
                    txtMaNhom.Enabled = false;
                    comboBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else if (themhaysua == "sua")
            {
                NguoiDung nd = new NguoiDung();
                if (nd.sua(txtTenDangNhap.TextInput, txtMatKhau.TextInput, txtMaNhom.TextInput) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    loadDataG();
                    txtTenDangNhap.Enabled = false;
                    txttennhom2.Enabled = false;
                    txtMatKhau.Enabled = false;
                    txtmanhom2.Enabled = false;
                    txtMaNhom.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            txtMaNhom.TextInput = "";
            txttennhom2.TextInput = "";
            txtmanhom2.Focus();
            themhaysua2 = "them";
            txtmanhom2.Enabled = true;
            txttennhom2.Enabled = true;
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {
            themhaysua2 = "sua";
            txttennhom2.Focus();
            txtmanhom2.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanhom2.TextInput = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttennhom2.TextInput = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            if (nd.xoanhom(txtmanhom2.TextInput, txttennhom2.TextInput) == true)
            {
                MessageBox.Show("Xóa thành công!");
                loadatagridnhomnguoidung();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnluuw2_Click(object sender, EventArgs e)
        {
            if (themhaysua2 == "them")
            {
                NguoiDung nd = new NguoiDung();
                nd.themnhom(txtmanhom2.TextInput, txttennhom2.TextInput);
                MessageBox.Show("Thêm thành công!");
                loadatagridnhomnguoidung();
                
            }
            else if (themhaysua2 == "sua")
            {
                NguoiDung nd = new NguoiDung();
                nd.suanhom(txtmanhom2.TextInput, txttennhom2.TextInput);
                MessageBox.Show("Sửa thành công!");
                loadatagridnhomnguoidung();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
        }

       
    }
}
