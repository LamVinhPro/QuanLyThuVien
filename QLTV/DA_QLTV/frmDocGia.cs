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
using System.IO;

namespace DA_QLTV
{
    public partial class frmDocGia : Form
    {
  
        public frmDocGia()
        {
         
            InitializeComponent();
            loadDataG();
            customDataG();
            loadcbb();

            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtNgayTao.Enabled = false;
            txtSDT.Enabled = false;
            cbbLoaiDG.Enabled = false;
            cbbMaDocGia.Enabled = false;
            cbbTenDocGia.Enabled = false;
            panel3.Visible = false;
            panel1.Height = 659;
            panel1.Width = 1159;

        }
        void loadcbb()
        {
            DocGia dg = new DocGia();
            cbbLoaiDG.DataSource = dg.loadcbbtenloaidocgia();
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
            DocGia dg = new DocGia();
            dataGridView1.DataSource = dg.loadDataG();
 
        }


        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        byte[] luuAnhtoSql(Image img)
        {
            //  luu anh den co so du lieu       

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();

            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //DocGia dg = new DocGia();
            //dataGridViewDocGia.DataSource = dg.timKiem(txtTimKiem.Text); 
        }
        string themhaysua = "";
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Width = 810;
            panel1.Height = 659;
            DocGia dg = new DocGia();
            themhaysua = "them";
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtNgayTao.Text = DateTime.Now.ToString();
            txtSDT.Enabled = true;
            cbbLoaiDG.Enabled = true;
            cbbMaDocGia.Text = (int.Parse(dg.taoMaTuDong()) + 1).ToString();
            cbbTenDocGia.Enabled = true;

            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            cbbLoaiDG.Text = "";
            cbbTenDocGia.Text = "";
            cbbTenDocGia.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void jImageButton6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Height = 659;
            panel1.Width = 1159;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "" || txtNgaySinh.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || cbbTenDocGia.Text == "" || cbbLoaiDG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (themhaysua == "them")
                {
                    DocGia dg = new DocGia();
                    string gioitinh = "";
                    if (rbtnNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    if (rbtnNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }
                    dg.themdocgia(cbbMaDocGia.Text, cbbTenDocGia.Text, gioitinh, txtNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, luuAnhtoSql(pictureBox2.Image), txtNgayTao.Text, txtEmail.Text, cbbLoaiDG.Text, luuAnhtoSql(pictureBox1.Image));
                   
                        MessageBox.Show("Thêm thành công!");
                        themhaysua = "";
                        loadDataG();
                    



                }
                else if (themhaysua == "sua")
                {
                    DocGia dg = new DocGia();
                    string gioitinh = "";
                    if (rbtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (rbtnNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }
                    if (dg.suadocgia(cbbMaDocGia.Text, cbbTenDocGia.Text, gioitinh, txtNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, luuAnhtoSql(pictureBox2.Image), txtNgayTao.Text, txtEmail.Text, cbbLoaiDG.Text, luuAnhtoSql(pictureBox1.Image)) == true)
                    {
                        MessageBox.Show("Sửa thành công!");
                        themhaysua = "";
                        loadDataG();
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
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            themhaysua = "sua";
            cbbTenDocGia.Enabled = true;
            cbbTenDocGia.Focus();
            txtNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DocGia dg = new DocGia();
                if (dg.xoadocgia(cbbMaDocGia.Text) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadDataG();
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnUpAnh_Click(object sender, EventArgs e)
        {
            String imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pictureBox1.ImageLocation = imagelocation;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnTaoMaQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var data = qr.CreateQrCode(cbbMaDocGia.Text + " " + cbbTenDocGia.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(data);
            pictureBox2.Image = code.GetGraphic(2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            panel1.Width = 810;
            panel1.Height = 659;
            string madocgia = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DocGia dg = new DocGia();
            string gioitinh = dg.loadgioitinh(madocgia);
            if (gioitinh == "Nam")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            cbbTenDocGia.Text = dg.loadtendocgia(madocgia);
            cbbMaDocGia.Text = madocgia;
            cbbLoaiDG.Text = dg.loadloaidocgia(madocgia);
            txtNgaySinh.Text = dg.loadngaysinh(madocgia);
            txtDiaChi.Text = dg.loaddiachi(madocgia);
            txtSDT.Text = dg.loadsodienthoai(madocgia);
            txtNgayTao.Text = dg.loadngaytao(madocgia);
            txtEmail.Text = dg.loademail(madocgia);
            pictureBox2.Image = byteArrayToImage(dg.loadAnhQR(cbbMaDocGia.Text));
            pictureBox1.Image = byteArrayToImage(dg.loadAnhDocGia(cbbMaDocGia.Text));
        }

        private void btntaothe_Click(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DocGia dg = new DocGia();
                dataGridView1.DataSource = dg.timtheoma(txttimkiem.Text);
            }
            else if (radioButton2.Checked)
            {
                DocGia dg = new DocGia();
                dataGridView1.DataSource = dg.timkiemtheoten(txttimkiem.Text);
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            
            {
                loadDataG();
            }
        }
    }
}
