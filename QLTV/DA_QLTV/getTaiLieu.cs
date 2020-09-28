using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_QLTV
{
    public class getTaiLieu
    {
        public getTaiLieu(string matailieu, string soluong)
        {
            this.matailieu = matailieu;
            this.soluong = soluong;
        }
        public getTaiLieu()
        {
 
        }
        string matailieu;

        public string Matailieu
        {
            get { return matailieu; }
            set { matailieu = value; }
        }
        string soluong;

        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}
