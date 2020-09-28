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

    public partial class frmChiTietHoaDon : Form
    {
        string mahoadon;
        string trangthai;

        public frmChiTietHoaDon(string mahoadon, string trangthai)
        {
            InitializeComponent();
            this.mahoadon = mahoadon;
            this.trangthai = trangthai;

            loadDataGrid();
            //txtMaCTHD.Enabled = false;
            //txtMaTaiLieu.Enabled = false;
            //txtSoLuongMuon.Enabled = false;
            //txtTenTaiLieu.Enabled = false;
            //textBox1.Enabled = false;
           
            //if (trangthai == "Đã trả")
            //{
            //    btnTraSach.Enabled = false;
            //}
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string themhaysua = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            //themhaysua = "them";
            //ChiTietHoaDon cthd = new ChiTietHoaDon();
            //txtMaCTHD.Text = (int.Parse(cthd.taoMaTuDong()) + 1).ToString();
            //txtSoLuongMuon.Enabled = true;
        }

        void loadDataGrid()
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            dataGridView1.DataSource = cthd.loadDataG(int.Parse(mahoadon));
            //dataGridView2.DataSource = cthd.loadDataGTaiLieu();
            //textBox1.Text = mahoadon;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            //textBox1.Enabled = false;

            ChiTietHoaDon ct = new ChiTietHoaDon();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaTaiLieu.Text = dataGridView2.SelectedCells[0].OwningRow.Cells["MaTaiLieu"].Value.ToString();
            //txtTenTaiLieu.Text = dataGridView2.SelectedCells[1].OwningRow.Cells["TenTaiLieu"].Value.ToString();
            //txtSoLuongMuon.Text = dataGridView2.SelectedCells[2].OwningRow.Cells["SoLuong"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (themhaysua == "them")
            //{
            //    ChiTietHoaDon cthd = new ChiTietHoaDon();
            //    if (cthd.themChiTietHoaDon(txtMaCTHD.Text, mahoadon, txtMaTaiLieu.Text, int.Parse(txtSoLuongMuon.Text)) == true)
            //    {
            //        // thay doi so luong sach
            //        cthd.thayDoiSoLuongSach(txtMaTaiLieu.Text, int.Parse(txtSoLuongMuon.Text));
            //        // thay doi tong so luong hoa don
            //        cthd.thayDoitongSoSach(mahoadon);
            //        loadDataGrid();
            //        MessageBox.Show("Thêm thành công!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm thất bại!");
            //    }
            //}
            //else if (themhaysua == "sua")
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Chưa có dữ liệu!");
            //}
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaTaiLieu.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //txtTenTaiLieu.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaChiTiet.TextName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenTL.TextName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.TextName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTrangThai.TextName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                string machitiet = dataGridView1.Rows[i].Cells[0].Value.ToString();
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.thucHienTraSach(machitiet, mahoadon);
            }
            MessageBox.Show("Trả thành công!");
            loadDataGrid();
        }

        private void btnxuatphieumuon_Click(object sender, EventArgs e)
        {

        }


      
     
    }
}
