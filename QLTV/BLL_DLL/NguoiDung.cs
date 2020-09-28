using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class NguoiDung
    {

        QLTVDataContext qltv = new QLTVDataContext();

    
        public IQueryable loadDataGNhomNguoiDung()
        {
            return (from a in qltv.QL_NhomCuaNguoiDungs
                    select new
                    {
                        MaNhom = a.MaNhom,
                        TenNhom = a.TenNhom,
                  
                    });
        }

        public bool xoa(string tendangnhap)
        {
            try
            {
                QL_NguoiDung delete = qltv.QL_NguoiDungs.Where(p => p.TenDangNhap.Equals(tendangnhap)).SingleOrDefault();
                qltv.QL_NguoiDungs.DeleteOnSubmit(delete);
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool them(string tendangnhap, string matkhau, string manhom)
        {
            try
            {
                QL_NguoiDung insert = new QL_NguoiDung();
                insert.TenDangNhap = tendangnhap;
                insert.MatKhau = matkhau;
                insert.MaNhom = manhom;
                qltv.QL_NguoiDungs.InsertOnSubmit(insert);
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
     
 
        }
        public bool sua(string tendangnhap,string matkhau, string manhom)
        {
             try
            {
                QL_NguoiDung edit = qltv.QL_NguoiDungs.Where(p=>p.TenDangNhap.Equals(tendangnhap)).SingleOrDefault();
  
                edit.MatKhau = matkhau;
                edit.MaNhom = manhom;      
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }   
        }

        public IQueryable getListNguoiDung()
        {
            var list = from a in qltv.QL_NguoiDungs
                       from b in qltv.QL_NhomCuaNguoiDungs
                       where a.MaNhom == b.MaNhom
                       select new
                       {
                           NgườiDùng = a.TenDangNhap,
                           MatKhau = a.MatKhau,
                           MaNhom = b.TenNhom
                       };

            return list;
        }
        public IQueryable getCbb()
        {
            var list = from a in qltv.QL_NhomCuaNguoiDungs
                       select a.TenNhom;
            return list;
        }
        public string selecttxtMaNhom(string tennhom)
        {
            var list = (from a in qltv.QL_NhomCuaNguoiDungs
                       where a.TenNhom == tennhom
                       select a.MaNhom).FirstOrDefault();
            return list;
                      
        }
        public bool themnhom(string manhom, string tennhom)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            QL_NhomCuaNguoiDung insert = new QL_NhomCuaNguoiDung();
            insert.MaNhom = manhom;
            insert.TenNhom = tennhom;
            qltv.QL_NhomCuaNguoiDungs.InsertOnSubmit(insert);
            qltv.SubmitChanges();
            return true;
        }
        public bool suanhom(string manhom, string tennhom)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            QL_NhomCuaNguoiDung edit = qltv.QL_NhomCuaNguoiDungs.Where(d => d.MaNhom.Equals(manhom)).SingleOrDefault();
            edit.TenNhom = tennhom;
            qltv.SubmitChanges();
            return true;
        }
        public bool xoanhom(string manhom, string tennhom)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            QL_NhomCuaNguoiDung delete = qltv.QL_NhomCuaNguoiDungs.Where(d => d.MaNhom.Equals(manhom)).SingleOrDefault();
            qltv.QL_NhomCuaNguoiDungs.DeleteOnSubmit(delete);
            qltv.SubmitChanges();
            return true;
        }
    }
}
