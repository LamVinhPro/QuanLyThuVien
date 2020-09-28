using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class TaiLieuu
    {
        public bool tinhTongSoLuongTL(string matailieu)
        {  
            QLTVDataContext qltv = new QLTVDataContext();
            string tongsoluong = (qltv.QL_ChiTietTaiLieus.Where(a=>a.MaTaiLieu == matailieu ).Sum(d=>d.SoLuong)).ToString();
            QL_TaiLieu edit = qltv.QL_TaiLieus.Where(d => d.MaTaiLieu.Equals(matailieu)).SingleOrDefault();
            edit.TongSoLuong = tongsoluong;
            qltv.SubmitChanges();
            return true;    
 
        }
        public bool tinhTongGiaNhap(string matailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string tongiatien = (qltv.QL_ChiTietTaiLieus.Where(a => a.MaTaiLieu == matailieu).Sum(d => d.GiaNhap)).ToString();
            QL_TaiLieu edit = qltv.QL_TaiLieus.Where(d => d.MaTaiLieu.Equals(matailieu)).SingleOrDefault();
            edit.TongGiaTien = tongiatien;
            qltv.SubmitChanges();
            return true;   
 
        }
        public IQueryable timkiemtheotheloai(string tentheloai)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    where a.TenTaiLieu.Contains(tentheloai)
                    select new
                    {
                        a.MaTaiLieu,
                        a.TenTaiLieu,
                        a.TongSoLuong,
                        a.NguoiNhap,
                        a.NgayNhap,
                        a.TongGiaTien

                    });

        }
        public IQueryable timkiemtheomatailieu(string matailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    where a.MaTaiLieu.Contains(matailieu)
                    select new
                    {
                        a.MaTaiLieu,
                        a.TenTaiLieu,
                        a.TongSoLuong,
                        a.NguoiNhap,
                        a.NgayNhap,
                        a.TongGiaTien

                    });

        }
        public bool xoatailieu(string matailieu)
        {
            try
            {
                QLTVDataContext qltv = new QLTVDataContext();
                QL_TaiLieu delete = qltv.QL_TaiLieus.Where(p => p.MaTaiLieu.Equals(matailieu)).SingleOrDefault();
                qltv.QL_TaiLieus.DeleteOnSubmit(delete);
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool suatailieu(string matailieu, string tentheloai)
        {         
            QLTVDataContext qltv = new QLTVDataContext();

            try
            {
                QL_TaiLieu edit = qltv.QL_TaiLieus.Where(p => p.MaTaiLieu.Equals(matailieu)).SingleOrDefault();

                edit.TenTaiLieu =  tentheloai;
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool themtailieu(string matailieu, string tentheloai, string tongsoluong, string nguoinhap, string ngaynhap, string tonggiatien)
        {
            try
            {
                QLTVDataContext qltv = new QLTVDataContext();
                QL_TaiLieu insert = new QL_TaiLieu();

                insert.MaTaiLieu = matailieu;
                insert.TenTaiLieu = tentheloai;
                insert.TongSoLuong = tongsoluong;
                insert.TongGiaTien = tonggiatien;
                insert.NgayNhap = DateTime.Parse(ngaynhap);
                insert.NguoiNhap = nguoinhap;
                insert.TongGiaTien = tonggiatien;
                qltv.QL_TaiLieus.InsertOnSubmit(insert);
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IQueryable loadcbbmatailieu()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    select a.MaTaiLieu);
        }
        public IQueryable loadcbbtentheloai()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    select a.TenTaiLieu);
        }
        
        public IQueryable loadDataG()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    select new
                    {
                        a.MaTaiLieu,
                        a.TenTaiLieu,
                        a.TongSoLuong,
                        a.NguoiNhap,
                        a.NgayNhap,
                        a.TongGiaTien
                    });
        }
        public IQueryable loadcbbtailieu()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                        select a.TenTaiLieu);
        }
        public string laymatailieu(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    where a.TenTaiLieu == tentailieu
                    select a.MaTaiLieu).FirstOrDefault();
        }
    }
}
