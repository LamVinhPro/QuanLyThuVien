using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DLL;

namespace DA_QLTV
{
    public partial class frmMain : Form
    {
        string tendangnhap,  matkhau, manhom;
        public frmMain(string tendangnhap, string matkhau, string manhom)
        {
            InitializeComponent();
            load();
            loadListView();
            customDataG();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.manhom = manhom;
            label14.Text = tendangnhap;

            btnNguoiDung.Enabled = false;
            btnDocGia.Enabled = false;
            btnTaiLieu.Enabled = false;
            btnMuonTra.Enabled = false;
            btnThongKe.Enabled = false;
            btnManHinh.Enabled = false;
            dataGridView2.Visible = false;
            load2();
   
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string mamanhinh = dataGridView2.Rows[i].Cells[1].Value.ToString();
                if (mamanhinh == "1")
                {
                    btnNguoiDung.Enabled = true;
                }
                if (mamanhinh == "2")
                {
                    btnDocGia.Enabled = true;
                }
                if (mamanhinh == "3")
                {
                    btnTaiLieu.Enabled = true;
                }
                if (mamanhinh == "4")
                {
                    btnMuonTra.Enabled = true;
                }
                if (mamanhinh == "5")
                {
                    btnThongKe.Enabled = true;
                }
                if (mamanhinh == "6")
                {
                    btnManHinh.Enabled = true;
                }

            }

            cbbtimkiemtheotheloai.Enabled = false;
 
            
        }
        public frmMain()
        {
            InitializeComponent();
            load();
            loadListView();
        }

        public void load2()
        {
            ManHinh mh = new ManHinh();
            dataGridView2.DataSource = mh.load(manhom);
            TaiLieuu tl = new TaiLieuu();
            cbbtimkiemtheotheloai.DataSource = tl.loadcbbtentheloai();
        }
        public void customDataG()
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
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        void loadListView()
        {

            string conn = @"Data Source=LAPTOP-VA3QE2VM\SQLEXPRESS;Initial Catalog=LTWNC;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from QL_ChiTietTaiLieu", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            int imageindex = 0;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                imageList1.Images.Add(byteArrayToImage((byte[])dt.Rows[i][8]));
                var viewitem = new ListViewItem(dt.Rows[i][12].ToString());

                { };
                viewitem.ImageIndex = imageindex;
                listView1.Items.Add(viewitem);
                imageindex++;
            }

        }

        void load()
        {
            panelnhapsl.Visible = false;
            btnMenu2.Visible = false;
            panel6.Visible = false;
            txtCTTL.Enabled = false;
            txtGiaBia.Enabled = false;
            txtNCC.Enabled = false;
            txtNXB.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTacGia.Enabled = false;
            txtTenTL.Enabled = false;
            txtTheLoai.Enabled = false;
            txtViTri.Enabled = false;
            panel7.Visible = false;

 
        }
        private void btnMenuChiTiet_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel5.Width = 1053;         
        }
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = true;
            }
        }
 
        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnNguoiDung.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnNguoiDung.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void jImageButton6_Click(object sender, EventArgs e)
        {
            btnMenu2.Visible = true;
            panel1.Width = 58;
            panel1.Height = 559;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu2_Click_1(object sender, EventArgs e)
        {
            panel1.Width = 284;
            panel1.Height = 559;
            btnMenu2.Visible = false;
        }

        private void btnDocGia_MouseHover(object sender, EventArgs e)
        {
            btnDocGia.BackColor = Color.White;
        }

        private void btnDocGia_MouseLeave(object sender, EventArgs e)
        {
            btnDocGia.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnTaiLieu_MouseHover(object sender, EventArgs e)
        {
            btnTaiLieu.BackColor = Color.White;
        }

        private void btnTaiLieu_MouseLeave(object sender, EventArgs e)
        {
            btnTaiLieu.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnMuonTra_MouseHover(object sender, EventArgs e)
        {
            btnMuonTra.BackColor = Color.White;
        }

        private void btnMuonTra_MouseLeave(object sender, EventArgs e)
        {
            btnMuonTra.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnThongKe_MouseHover(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.White;
        }

        private void btnThongKe_MouseLeave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void jImageButton6_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel5.Width = 1053;
            lblSoLuongGioHang.Visible = true;
            btnGioHang.Visible = true;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            lblSoLuongGioHang.Visible = false;
            btnGioHang.Visible = false;
            panel6.Visible = true;                   
            string tentailieu = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            TaiLieu tl = new TaiLieu();
            txtCTTL.TextName = tl.loadMaChiTietTaiLieu(tentailieu);
            txtTenTL.TextName = tentailieu;
            txtNXB.TextName = tl.loadtennxb(tentailieu);
            txtTacGia.TextName = tl.loadtacgia(tentailieu);
            txtViTri.TextName = tl.loadvitri(tentailieu);
            txtTheLoai.TextName = tl.loadtheloai(tentailieu);
            txtSoLuong.TextName = tl.loadsoluongtailieu(tentailieu);
            txtGiaBia.TextName = tl.loadgiabia(tentailieu);;
            txtNCC.TextName = tl.loadncc(tentailieu);
            anhQR.Image = byteArrayToImage(tl.loadAnhQR(tentailieu));         
            
        }

        private void btnChoMuon_MouseHover(object sender, EventArgs e)
        {
            btnChoMuon.BackColor = Color.SeaGreen;
            btnChoMuon.ForeColor = Color.White;
        }

        private void btnChoMuon_MouseLeave(object sender, EventArgs e)
        {
            btnChoMuon.ForeColor = Color.SlateGray;
            btnChoMuon.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnTaiLieu_Click_1(object sender, EventArgs e)
        {
            frmTaiLieuu frm = new frmTaiLieuu(label14.Text);
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
           
            txtSoLuongMuon.Focus();
            txtSoLuongMuon.Value = 1;
            if (dataGridView1.RowCount == 1)
            {
                panelnhapsl.Visible = true;
            }
            if (dataGridView1.RowCount > 1)
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string ten = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    if (txtTenTL.TextName.Equals(ten))
                    {
                        MessageBox.Show("Tài liệu đã có trong giỏ hàng!");
                        panelnhapsl.Visible = false; 
                        return;
                    }
                    else
                    {
                        panelnhapsl.Visible = true; 
                    }
                }
            }
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            //frmHoaDon hd = new frmHoaDon(label14.Text);
            //hd.ShowDialog();
            List<getTaiLieu> list = new List<getTaiLieu>();
            frmHoaDon frm = new frmHoaDon(list, label14.Text, lbltongso.Text);
            frm.ShowDialog();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.ShowDialog();
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel7.Visible = true;
            }
            else
            {
                panel7.Visible = false;
            }
            //frmGioHang frm = new frmGioHang();
            //frm.ShowDialog();
        }

        private void jImageButton8_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Properties.Settings.Default.soluong).ToString());
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            panelnhapsl.Visible = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoLuongMuon.Value.ToString()) < 1)
            {
                MessageBox.Show("Số lượng không lợp lệ!");
            }
            else
            {
                int i = (dataGridView1.RowCount - 1) + 1;
                dataGridView1.Rows.Add(i.ToString(), txtCTTL.TextName, txtTenTL.TextName, txtSoLuongMuon.Value);
                int sl = 0;
                for (int i2 = 0; i2 < dataGridView1.RowCount - 1; i2++)
                {
                    sl = sl + int.Parse(dataGridView1.Rows[i2].Cells[3].Value.ToString());
                    lblSoLuongGioHang.Text = sl.ToString();
                    lbltongso.Text = sl.ToString();

                }
                panelnhapsl.Visible = false;
            }

        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            List<getTaiLieu> list = new List<getTaiLieu>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string matl = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string sl = dataGridView1.Rows[i].Cells[3].Value.ToString();
                
                getTaiLieu tl = new getTaiLieu(matl,sl);
                list.Add(tl);
            }
            frmHoaDon frm = new frmHoaDon(list, label14.Text,lbltongso.Text);
            frm.ShowDialog();         
         
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            frm.ShowDialog();
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            lblSoLuongGioHang.Text = "0";
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            frmManHinh frm = new frmManHinh();
            frm.ShowDialog();
        }

        private void rbtntheloai_CheckedChanged(object sender, EventArgs e)
        {
            cbbtimkiemtheotheloai.Enabled = true;
            //listView1.Clear();
            //TaiLieuu tl = new TaiLieuu();
            //string matailieu = tl.laymatailieu(cbbtimkiemtheotheloai.Text);
            //string conn = @"Data Source=LAPTOP-VA3QE2VM\SQLEXPRESS;Initial Catalog=LTWNC;Integrated Security=True";
            //SqlConnection con = new SqlConnection(conn);
            //con.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = new SqlCommand("select * from QL_ChiTietTaiLieu where MaTaiLieu = '" + matailieu + "' ", con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            ////dataGridView1.DataSource = dt;
            //int imageindex = 0;


            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    imageList1.Images.Add(byteArrayToImage((byte[])dt.Rows[i][8]));
            //    var viewitem = new ListViewItem(dt.Rows[i][12].ToString());

            //    { };
            //    viewitem.ImageIndex = imageindex;
            //    listView1.Items.Add(viewitem);
            //    imageindex++;
            //}
        }

        private void cbbtimkiemtheotheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtntatca_CheckedChanged(object sender, EventArgs e)
        {
            //loadListView();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                listView1.Clear();
                loadListView();
            }
        }

        private void rbtntatca_Click(object sender, EventArgs e)
        {
            //loadListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            TaiLieuu tl = new TaiLieuu();
            string matailieu = tl.laymatailieu(cbbtimkiemtheotheloai.Text);
            string conn = @"Data Source=LAPTOP-VA3QE2VM\SQLEXPRESS;Initial Catalog=LTWNC;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from QL_ChiTietTaiLieu where TenChiTiet LIKE N'%" + txttimkiem.Text + "%'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            int imageindex = 0;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                imageList1.Images.Add(byteArrayToImage((byte[])dt.Rows[i][8]));
                var viewitem = new ListViewItem(dt.Rows[i][12].ToString());

                { };
                viewitem.ImageIndex = imageindex;
                listView1.Items.Add(viewitem);
                imageindex++;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            if (rbtntheloai.Checked)
            {
                cbbtimkiemtheotheloai.Enabled = true;
                listView1.Clear();
                TaiLieuu tl = new TaiLieuu();
                string matailieu = tl.laymatailieu(cbbtimkiemtheotheloai.Text);
                string conn = @"Data Source=LAPTOP-VA3QE2VM\SQLEXPRESS;Initial Catalog=LTWNC;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select * from QL_ChiTietTaiLieu where MaTaiLieu = '" + matailieu + "' ", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //dataGridView1.DataSource = dt;
                int imageindex = 0;


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    imageList1.Images.Add(byteArrayToImage((byte[])dt.Rows[i][8]));
                    var viewitem = new ListViewItem(dt.Rows[i][12].ToString());

                    { };
                    viewitem.ImageIndex = imageindex;
                    listView1.Items.Add(viewitem);
                    imageindex++;
                }
            }
            else if (rbtntatca.Checked)
            {
                listView1.Clear();
                loadListView();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
        }

       

   
        

     
        

       

        



    }
}
