using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class DangNhap
    {
        public IQueryable kiemTraTenDangNhap(string tendangnhap)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_NguoiDungs.Where(p => p.TenDangNhap.CompareTo(tendangnhap) == 0)
                    select new 
                    {
                        a.TenDangNhap,
                        a.MatKhau,
                        a.MaNhom
                    });
            
        }
        public int Check_config()
        {
            if (Properties.Settings.Default.bbb == string.Empty)
                return 1;
            SqlConnection _SqlConn = new SqlConnection(Properties.Settings.Default.bbb);
            try
            {
                if (_SqlConn.State == System.Data.ConnectionState.Closed)
                    _SqlConn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap ='" + pUser + "' and MatKhau ='" + pPass + "'", Properties.Settings.Default.bbb);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 99;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 100;// Không hoạt động
            }
            return 101;// Đăng nhập thành công
        }
        public bool kiemTra(string tendangnhap)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            QL_NguoiDung nd = qltv.QL_NguoiDungs.Where(t => t.TenDangNhap == tendangnhap).FirstOrDefault();
            if (nd != null)
            {
                return true;
            }
            return false;
        }
      

    
     
    }
}
