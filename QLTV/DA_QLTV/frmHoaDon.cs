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
    public partial class frmHoaDon : Form
    {
        string machitiettl;
        string tennguoidung;
        string soluong;
        string tongso;
        List<getTaiLieu> list;
        public frmHoaDon(string tennguoidung, string machitiettl, string soluong )
        {
            InitializeComponent();
            loadDataG();
            load();
            this.tennguoidung = tennguoidung;
            this.machitiettl = machitiettl;
            this.soluong = soluong;
            customDataG();
        }
        public frmHoaDon(List<getTaiLieu> list, string tennguoidung, string tongso)
        {
            
            InitializeComponent();
            loadDataG();
            load();
            this.list = list;
            this.tennguoidung = tennguoidung;
            this.tongso = tongso;
            customDataG();
            txtNguoiLap.TextName = tennguoidung;
            txtNgayMuon.TextName = DateTime.Now.ToString();
            txtSoLuong.TextName = tongso;
            rbtn7ngay.Enabled = false;
            rbtn14ngay.Enabled = false;
        }
        public frmHoaDon()
        {
            InitializeComponent();
            loadDataG();
            load();
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
        void load()
        {
            txtMaDG.Enabled = false;
            txtMaHoaDon.Enabled = false;
            txtNgayMuon.Enabled = false;
            txtNguoiLap.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTrangThai.Enabled = false;
            panel4.Visible = false;
            panel3.Height = 659;
            panel3.Width = 1159;
        }
        void loadDataG()
        {
            HoaDon hd = new HoaDon();
            dataGridView1.DataSource = hd.loadDataG();
        }

        private void jImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        string themhaysua = "";     

        private void txtMaDG_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("123");
        }

        private void jImageButton6_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Height = 659;
            panel3.Width = 1159;
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Height = 659;
            panel3.Width = 810;
            panel4.Visible = true;
            HoaDon hd = new HoaDon();
            txtMaHoaDon.TextName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNguoiLap.TextName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMaDG.TextName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTenDG.TextName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNgayMuon.TextName = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.TextName = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTrangThai.TextName = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string tendocgia = txtTenDG.Text;
            txtSDT.TextName = hd.layMaDG(tendocgia);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frm = new frmChiTietHoaDon(txtMaHoaDon.TextName, txtTrangThai.TextName);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = 659;
            panel3.Width = 810;
            panel4.Visible = true;
            HoaDon hd = new HoaDon();
            themhaysua = "them";
            txtMaDG.Enabled = false;
            txtMaHoaDon.TextName = (int.Parse(hd.taoMaTuDong()) + 1).ToString();
            txtNgayMuon.TextName = DateTime.Now.ToString();
            txtNguoiLap.TextName = tennguoidung;
            txtTrangThai.TextName = "Đang cho mượn";
            txtSDT.Focus();
        }

        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            string tendocgia = hd.kiemTraMaDocGia(txtSDT.TextName);
            if (tendocgia == null)
            {
                MessageBox.Show("Độc giả không tồn tại!");
            }
            else
            {
                txtTenDG.TextName = tendocgia;
            }
           
            txtMaDG.TextName = hd.layMaDG(txtSDT.TextName);
            txtLoaiDG.TextName = hd.laytenloaidg(txtSDT.TextName);
            if (txtLoaiDG.TextName == "Giáo viên" || txtLoaiDG.TextName == "Nhân viên")
            {
                rbtn14ngay.Checked = true;
            }
            if (txtLoaiDG.TextName == "Sinh viên")
            {
                rbtn7ngay.Checked = true;
            }
           
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (themhaysua == "them")
            {
                string ngaytra = "";
                if (rbtn7ngay.Checked)
                {
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new System.TimeSpan(7, 0, 0, 0);
                    DateTime dtnew = dt.Add(ts);
                    ngaytra = dtnew.ToString();
                }
                if (rbtn14ngay.Checked)
                {
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new System.TimeSpan(14, 0, 0, 0);
                    DateTime dtnew = dt.Add(ts);
                    ngaytra = dtnew.ToString(); ;
                }
                HoaDon hd = new HoaDon();
                hd.themHoaDon(int.Parse(txtMaHoaDon.TextName), txtNguoiLap.TextName, txtMaDG.TextName, txtNgayMuon.TextName, ngaytra, int.Parse(txtSoLuong.TextName), txtTrangThai.TextName);
                loadDataG();
                for (int i = 0; i < list.Count; i++)
                {
                   
                    ChiTietHoaDon cthd = new ChiTietHoaDon();
                    int macthd = (int.Parse(cthd.taoMaTuDong()) + 1);
                    cthd.themChiTietHoaDon(macthd, int.Parse(txtMaHoaDon.TextName), list[i].Matailieu.ToString(), int.Parse(list[i].Soluong));
                    cthd.thayDoiSoLuongSach(list[i].Matailieu.ToString(), int.Parse(list[i].Soluong));
                    MessageBox.Show("Thêm thành công!");
                }
                    
                // them chi tiet phieu muon 
     
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                loadDataG();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                HoaDon hd = new HoaDon();

                dataGridView1.DataSource = hd.timkiemtheoma(txttimkiem.Text);

            }
            else if (radioButton2.Checked == true)
            {
                HoaDon hd = new HoaDon();
                dataGridView1.DataSource = hd.timkiemtheoten(txttimkiem.Text);
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!");
            }
        }
      

    }
}
