using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;


namespace BLL
{
    public class QLNguoiDungBLL
    {
        NghiepVu nv = new NghiepVu();

        public IEnumerable<QL_NguoiDung> getList()
        {
            return nv.getListNguoiDUng();
        }
  

    }
}
