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
    public partial class frmTaiLieuu : Form
    {
        string nguoidung;
        public frmTaiLieuu(string nguoidung)
        {
            InitializeComponent();
            this.nguoidung = nguoidung;
            load();
            loadDataG();
            customDataG();
            ancbbtxt();
            loadcbb();
            
            //rbtnMaTaiLieu.Checked = true;
           
        }
       
         //tao bien de nhan biet them hay sua
        string themhaysua = "";
       
        void loadcbb()
        {
            //TaiLieuu tl = new TaiLieuu();
            //cbbMaTaiLieu.DataSource = tl.loadcbbmatailieu();
            //cbbTenTheLoai.DataSource = tl.loadcbbtentheloai();
            
            
        }

        void xoacbbtxt()
        {
            txtTheLoai.Text = "";
            txtNgayNhap.Text = "";
            txtNguoiNhap.Text = "";
            txtSoLuong.Text = "";
            txtTongGia.Text = "";
        }
        void hientxtcbb()
        {
            txtMaTaiLieu.Enabled = true;
            txtTheLoai.Enabled = true;
            txtTongGia.Enabled = true;
            txtSoLuong.Enabled = true;
            txtNguoiNhap.Enabled = true;
            txtNgayNhap.Enabled = true;
 
        }

        void ancbbtxt()
        {
            txtMaTaiLieu.Enabled = false;
            txtTheLoai.Enabled = false;
            txtTongGia.Enabled = false;
            txtSoLuong.Enabled = false;
            txtNguoiNhap.Enabled = false;
            txtNgayNhap.Enabled = false;
        }
        void customDataG()
        {
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
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserMouse, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Selectable, true);
        }
        void loadDataG()
        {
            TaiLieuu tl = new TaiLieuu();
            dataGridView1.DataSource = tl.loadDataG();
 
        }

        void load()
        {

            panel2.Height = 659;
            panel2.Width = 1162;
        }             

        private void txtTimKiem_TextChange(object sender, EventArgs e)
        {
            //if (rbtnMaTaiLieu.Checked)
            //{
            //    try
            //    {
            //        TaiLieuu tl = new TaiLieuu();
            //        dataGridView1.DataSource = tl.timkiemtheomatailieu(txtTimKiem.Text);
            //    }
            //    catch (Exception                                                                                                            
                    
            //        )
            //    {

            //    }
            //}
            //if (rbtntentailieu.Checked)
            //{
            //    try
            //    {
            //        TaiLieuu tl = new TaiLieuu();
            //        dataGridView1.DataSource = tl.timkiemtheotheloai(txtTimKiem.Text);
            //    }
            //    catch (Exception ex)
            //    {

            //    }

            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Height = 659;
            panel2.Width = 810;
            txtMaTaiLieu.TextName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTheLoai.TextName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.TextName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNguoiNhap.TextName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNgayNhap.TextName = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTongGia.TextName = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.ForestGreen;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.DarkSeaGreen;
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.FromArgb(192, 64, 0);
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Silver;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Crimson;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.Silver;
        }

        private void btnLuu_MouseHover(object sender, EventArgs e)
        {
            btnLuu.BackColor = Color.Green;
        }

        private void btnLuu_MouseLeave(object sender, EventArgs e)
        {
            btnLuu.BackColor = Color.Silver;
        }

        private void btnXemChiTiet_MouseHover(object sender, EventArgs e)
        {
            btnXemChiTiet.BackColor = Color.Teal;
        }

        private void btnXemChiTiet_MouseLeave(object sender, EventArgs e)
        {
            btnXemChiTiet.BackColor = Color.Silver;
        }

        private void jImageButton6_Click(object sender, EventArgs e)
        {
            panel2.Height = 659;
            panel2.Width = 1162;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            panel2.Height = 659;
            panel2.Width = 810;
            hientxtcbb();
            txtMaTaiLieu.Enabled = false;
            // tao ma tu dong cho txt ma tai lieu
            txtMaTaiLieu.TextName = (dataGridView1.Rows.Count + 1).ToString();
            xoacbbtxt();
            txtTheLoai.Focus();
            themhaysua = "them";
            txtNgayNhap.TextName = DateTime.Now.ToString();
            txtTongGia.TextName = "0";
            txtNguoiNhap.TextName = nguoidung;
            txtSoLuong.TextName = "0";

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            txtTheLoai.Enabled = true;
            txtNgayNhap.Enabled = false;
            txtNguoiNhap.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTongGia.Enabled = false;
            txtTheLoai.Focus();
            themhaysua = "sua";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TaiLieuu tl = new TaiLieuu();
                if (tl.xoatailieu(txtMaTaiLieu.TextName) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadDataG();

                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (themhaysua == "them")
            {

                TaiLieuu tl = new TaiLieuu();
                if (tl.themtailieu(txtMaTaiLieu.TextName, txtTheLoai.TextName, txtSoLuong.Text, txtNguoiNhap.TextName, txtNgayNhap.TextName, txtTongGia.TextName) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    ancbbtxt();
                    loadDataG();
                }

                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            if (themhaysua == "sua")
            {
                TaiLieuu tl = new TaiLieuu();
                if (tl.suatailieu(txtMaTaiLieu.TextName, txtTheLoai.TextName) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    loadDataG();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu để lưu!");
            }
        }

        private void btnXemChiTiet_Click_1(object sender, EventArgs e)
        {
            string matailieu = txtMaTaiLieu.TextName;
            frmTaiLieu2 frm = new frmTaiLieu2(matailieu);
            frm.ShowDialog();
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog();
        }
    }
}
