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
using System.Data.SqlClient;
using System.IO;

namespace DA_QLTV
{
    public partial class frmTaiLieu2 : Form
    {
        string matailieu;
        string themhaysua = "";


        public frmTaiLieu2(string matailieu)
        {
            InitializeComponent();
            load();
            this.matailieu = matailieu;
            loadDataG();
            customdataG();
            loadcbb();
            //  load ten danh muc 
            TaiLieu tl = new TaiLieu();
            label17.Text = tl.loadTenDanhMuc(matailieu);
            TaiLieuu tl2 = new TaiLieuu();

        }
        public frmTaiLieu2()
        {
            InitializeComponent();          

        }
        void customdataG()
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
        

        void load()
        {
            panel3.Visible = false;
            panel1.Height = 659;
            panel1.Width = 1159;

            // khoa cbb txt
            cbbMaChiTiet.Enabled = false;
            cbbMaTaiLieu.Enabled = false;
            cbbNhaCC.Enabled = false;
            cbbNhaXB.Enabled = false;
            cbbSoLuong.Enabled = false;
            cbbTacGia.Enabled = false;
            cbbTenChiTiet.Enabled = false;
            cbbViTri.Enabled = false;
            txtGiaBia.Enabled = false;
            txtGiaNhap.Enabled = false;
            txtLink.Enabled = false;
            txtNgayNhap.Enabled = false;
            txtNguoiNhap.Enabled = false;
            txtSoTrang.Enabled = false;
           
        }

        void loadDataG()
        {
            TaiLieu tl = new TaiLieu();
            dataGridView1.DataSource = tl.loadDataG(matailieu);
 
        }
        void loadcbb()
        {
            TaiLieu tl = new TaiLieu();
            cbbTenChiTiet.DataSource = tl.loadcbbtentheloai();
            cbbTacGia.DataSource = tl.loadcbbtacgia();
            cbbNhaXB.DataSource = tl.loadcbbnxb();
            cbbNhaCC.DataSource = tl.loadcbbncc();
            cbbViTri.DataSource = tl.loadcbbvitri();
            
        }



           private Image byteArrayToImage(byte[] byteArrayIn)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }


           private void listView1_MouseClick(object sender, MouseEventArgs e)
           {
               //string tentailieu = listView1.SelectedItems[0].SubItems[0].Text;
               //frmChiTietTaiLieu frm = new frmChiTietTaiLieu(tentailieu);
               //frm.Show();
               //this.Hide();
           }
    
           private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               panel3.Visible = true;
               panel1.Width = 803;
               panel1.Height = 659;
               cbbMaChiTiet.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               cbbMaTaiLieu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               cbbTenChiTiet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               cbbNhaCC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               cbbNhaXB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               cbbTacGia.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               cbbViTri.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               cbbSoLuong.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
               txtLink.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               txtSoTrang.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
               txtGiaBia.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
               txtGiaNhap.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
               txtNgayNhap.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
               txtNguoiNhap.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

               TaiLieu tl = new TaiLieu();
               pictureBox2.Image = byteArrayToImage(tl.loadAnhQR(cbbTenChiTiet.Text).ToArray());
               pictureBox1.Image = byteArrayToImage(tl.loadAnhTaiLieu(cbbTenChiTiet.Text).ToArray());
               
      

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

           private void btnUpAnh_Click(object sender, EventArgs e)
           {
               String imagelocation = "";
               try
               {
                   OpenFileDialog dialog = new OpenFileDialog();
                   dialog.Filter = "jpg file(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                   if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                   {
                       imagelocation = dialog.FileName;
                       pictureBox1.ImageLocation = imagelocation;
                   }
               }
               catch(Exception ex)
               {
                   MessageBox.Show("Lỗi!");
               }
           }

           private void btnTaoMaQR_Click(object sender, EventArgs e)
           {
               if (txtLink.Text == "")
               {
                   MessageBox.Show("Vui lòng dán dường dẫn vào trước!");
               }
               else
               {
                   QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                   var data = qr.CreateQrCode(txtLink.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                   var code = new QRCoder.QRCode(data);
                   pictureBox2.Image = code.GetGraphic(2);
               }
           }

           private void btnThem_Click(object sender, EventArgs e)
           {
               TaiLieu tl = new TaiLieu();
               panel3.Visible = true;
               panel1.Width = 803;
               panel1.Height = 659;
               pictureBox1.Image = null;
               pictureBox2.Image = null;
               txtNgayNhap.Text = (DateTime.Now).ToString();
               cbbMaChiTiet.Enabled = false;
               cbbMaChiTiet.Text = (int.Parse(tl.taoMaTuDong()) + 1).ToString();
               cbbMaTaiLieu.Enabled = false;
               cbbMaTaiLieu.Text = matailieu;
               cbbNhaCC.Enabled = true;
               cbbNhaXB.Enabled = true;
               cbbSoLuong.Enabled = true;
               cbbTacGia.Enabled = true;
               cbbTenChiTiet.Enabled = true;
               cbbViTri.Enabled = true;
               txtGiaBia.Enabled = true;
               txtGiaNhap.Enabled = true;
               txtLink.Enabled = true;
               txtNguoiNhap.Enabled = true;
               txtSoTrang.Enabled = true;
               // xoa trang 
               cbbNhaCC.Text = "";
               cbbNhaXB.Text = "";
               cbbSoLuong.Text = "";
               cbbTacGia.Text = "";
               cbbTenChiTiet.Text = "";
               cbbViTri.Text = "";
               txtGiaBia.Text = "";
               txtGiaNhap.Text = "";
               txtLink.Text = "";
               txtNguoiNhap.Text = "";
               txtSoTrang.Text = "";
               cbbTenChiTiet.Focus();
               themhaysua = "them";
           }

           private void btnSua_Click_1(object sender, EventArgs e)
           {
               themhaysua = "sua";
               cbbTenChiTiet.Focus();
               cbbNhaCC.Enabled = true;
               cbbNhaXB.Enabled = true;
               cbbSoLuong.Enabled = true;
               cbbTacGia.Enabled = true;
               cbbTenChiTiet.Enabled = true;
               cbbViTri.Enabled = true;
               txtGiaBia.Enabled = true;
               txtGiaNhap.Enabled = true;
               txtLink.Enabled = true;
               txtSoTrang.Enabled = true;
           }

           private void btnXoa_Click_1(object sender, EventArgs e)
           {
               DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo);
               if (dialog == DialogResult.Yes)
               {
                   TaiLieu tl = new TaiLieu();
                   tl.xoaTaiLieu(cbbMaChiTiet.Text);
                   MessageBox.Show("Xóa thành công!");
                   loadDataG();
               }
               else if (dialog == DialogResult.No)
               {

               }
           }

           private void btnLuu_Click_1(object sender, EventArgs e)
           {
               if (themhaysua == "them")
               {
                   TaiLieu tl = new TaiLieu();
                   if (cbbTenChiTiet.Text == "" || cbbTacGia.Text == "" || cbbSoLuong.Text == "" || cbbNhaXB.Text == "" || cbbNhaCC.Text == "" || txtGiaBia.Text == "" || txtGiaNhap.Text == "" || txtLink.Text == "" || txtNgayNhap.Text == "" || txtNguoiNhap.Text == "" || txtSoTrang.Text == "" || pictureBox1.Image == null || pictureBox2.Image == null)
                   {
                       MessageBox.Show("Vui lòng điền đầy đủ thông tin!");

                   }
                   else
                   {

                       if (tl.themTaiLieu(cbbMaChiTiet.Text, cbbMaTaiLieu.Text, cbbNhaCC.Text, cbbNhaXB.Text, cbbTacGia.Text, cbbViTri.Text, cbbSoLuong.Text, txtLink.Text, txtSoTrang.Text, luuAnhtoSql(pictureBox1.Image), luuAnhtoSql(pictureBox2.Image), txtGiaBia.Text, txtGiaNhap.Text, txtNgayNhap.Text, txtNguoiNhap.Text, cbbTenChiTiet.Text) == true)
                       {
                           MessageBox.Show("Thêm thành công!");
                           // cap nhat so luong tai lieu
                           TaiLieuu tl2 = new TaiLieuu();
                           tl2.tinhTongSoLuongTL(matailieu);
                           tl2.tinhTongGiaNhap(matailieu);

                           loadDataG();

                       }
                       else
                       {
                           MessageBox.Show("Thêm thất bại!");
                       }
                   }
               }
               if (themhaysua == "sua")
               {
                   TaiLieu tl = new TaiLieu();
                   if (tl.SuaTaiLieu(cbbMaChiTiet.Text, cbbTenChiTiet.Text, cbbNhaCC.Text, cbbNhaXB.Text, cbbTacGia.Text, cbbViTri.Text, cbbSoLuong.Text, txtLink.Text, txtSoTrang.Text, luuAnhtoSql(pictureBox2.Image), luuAnhtoSql(pictureBox1.Image), txtGiaBia.Text, txtGiaNhap.Text) == true)
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
                   MessageBox.Show("Chưa có dữ liệu!");
               }
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

           private void txttimkiem_TextChanged(object sender, EventArgs e)
           {
              // dataGridView1.DataSource = ;
               if (txttimkiem.Text =="")
               {
                   loadDataG();
               }
           }

           private void btntim_Click(object sender, EventArgs e)
           {
               if (radioButton1.Checked)
               {
                   TaiLieu tl = new TaiLieu();
                   dataGridView1.DataSource = tl.timtheoma(matailieu, txttimkiem.Text);
               }
               else if (radioButton2.Checked)
               {
                   TaiLieu tl = new TaiLieu();
                   dataGridView1.DataSource = tl.timtheoten(matailieu, txttimkiem.Text);
               }
               else
               {
                   MessageBox.Show("Chưa có dữ liệu!");
               }
           }
           

        }
    }

