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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            loadata();
            load();
            loaddata2();
            loadchart2();
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
        }
        void loaddata2()
        {
            TaiLieu tl = new TaiLieu();
            dataGridView2.DataSource = tl.loaddata2();
        }
        void loadata()
        { 
            TaiLieuu tl = new TaiLieuu();
            dataGridView1.DataSource = tl.loadDataG();
        }

        void load()
        {
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Titles.Add("Thống kê số lượng sách hiện có");
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string tentailieu = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string soluong = dataGridView1.Rows[i].Cells[2].Value.ToString();
                chart1.Series["Series1"].Points.AddXY(tentailieu, soluong);
            }
           
        }
        void loadchart2()
        {
            chart2.Series["Series1"].IsValueShownAsLabel = true;
            chart2.Titles.Add("Thống kê sách được mượn nhiều nhất");
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string tentailieu = dataGridView2.Rows[i].Cells[2].Value.ToString();
                chart2.Series["Series1"].Points.AddXY(tentailieu, "15");
            }
            
 
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
