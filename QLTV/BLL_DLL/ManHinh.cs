using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class ManHinh
    {
        QLTVDataContext qltv = new QLTVDataContext();

        public IQueryable loadcbbtenmanhinh()
        {
            return (from a in qltv.QL_ManHinhs
                        select a.TenManHinh);
        }
        public IQueryable loadcbbtennhom()
        {
            return (from a in qltv.QL_NhomCuaNguoiDungs
                        select a.TenNhom);
        }
        public IQueryable loaddataG(string tenmanhinh)
        {

            string mamanhinh = (from a in qltv.QL_ManHinhs
                                where a.TenManHinh == tenmanhinh
                                select a.MaManHinh).FirstOrDefault();

            return (from b in qltv.QL_ChiTietManHinhs
                    from a in qltv.QL_NhomCuaNguoiDungs
                    where b.MaManHinh == mamanhinh && a.MaNhom == b.MaNhom
                    select new
                    {
                        b.MaNhom,
                        a.TenNhom
                    });

        }

        public bool xoa(string manhom, string tenmanhinh)
        {
            string mamanhinh = (from a in qltv.QL_ManHinhs
                                where a.TenManHinh == tenmanhinh
                                select a.MaManHinh).FirstOrDefault();
        
                QL_ChiTietManHinh delete = qltv.QL_ChiTietManHinhs.Where(p => p.MaNhom.Equals(manhom) && p.MaManHinh.Equals(mamanhinh)).SingleOrDefault();
                qltv.QL_ChiTietManHinhs.DeleteOnSubmit(delete);
                qltv.SubmitChanges();
                return true;
          
        }
        public bool them(string tennhom, string tenmanhinh)     
        {
            string manhom = (from b in qltv.QL_NhomCuaNguoiDungs
                             where b.TenNhom == tennhom
                             select b.MaNhom).FirstOrDefault();
            string mamanhinh = (from a in qltv.QL_ManHinhs
                                where a.TenManHinh == tenmanhinh
                                select a.MaManHinh).FirstOrDefault();


            QL_ChiTietManHinh insert = new QL_ChiTietManHinh();
            insert.MaNhom = manhom;
            insert.MaManHinh = mamanhinh;
            qltv.QL_ChiTietManHinhs.InsertOnSubmit(insert);
            qltv.SubmitChanges();
            return true;        
        }

        public IQueryable load(string manhom)
        {
            return (from a in qltv.QL_ChiTietManHinhs
                    from b in qltv.QL_NhomCuaNguoiDungs
                    from c in qltv.QL_ManHinhs
                    where a.MaNhom == b.MaNhom && a.MaManHinh == c.MaManHinh && a.MaNhom == manhom
                    select new 
                    {
                        a.MaNhom,
                        a.MaManHinh
                    }); 
               
        }
    }


}
