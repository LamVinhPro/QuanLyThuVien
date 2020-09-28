using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NghiepVu
    {
        QLTVDataContext qltv = new QLTVDataContext();

        public IQueryable getListNguoiDUng()
        {
            var list = from a in qltv.QL_NguoiDungs
                   from b in qltv.QL_NhomCuaNguoiDungs
                    where a.MaNhom == b.MaNhom
                    select new
                    {
                     NgườiDùng = a.TenDangNhap,
                     Mậtkhẩu = a.MatKhau,
                     TênNhóm = b.TenNhom
                    };

            return list;
        }
        
    }
}
