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
    public partial class frmManHinh : Form
    {
        public frmManHinh()
        {
            InitializeComponent();
            loadcbb();
        //    customDataG();
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

        void loadcbb()
        {
            ManHinh mh = new ManHinh();
            cbbtenmanhinh.DataSource = mh.loadcbbtenmanhinh();
            cbbtennhom.DataSource = mh.loadcbbtennhom();
        }

        private void cbbtenmanhinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManHinh mh = new ManHinh();
            dataGridView1.DataSource = mh.loaddataG(cbbtenmanhinh.Text);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string manhom = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ManHinh mh = new ManHinh();
            mh.xoa(manhom, cbbtenmanhinh.Text);
            dataGridView1.DataSource = mh.loaddataG(cbbtenmanhinh.Text);
            MessageBox.Show("Thao tác thành công!");
           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ManHinh mh = new ManHinh();
            mh.them(cbbtennhom.Text.Trim().ToString(), cbbtenmanhinh.Text.Trim().ToString());
            dataGridView1.DataSource = mh.loaddataG(cbbtenmanhinh.Text);
            MessageBox.Show("Thao tác thành công!");
        }
    }
}
