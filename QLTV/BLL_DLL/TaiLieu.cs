using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class TaiLieu
    {
        public string taoMaTuDong()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            var item = qltv.QL_ChiTietTaiLieus.Max(d => d.MaCTTL);
            if (item == null)
                item = 0;
            return item.ToString();
           
        }
        public IQueryable loaddata2()
        {
            QLTVDataContext qltv = new QLTVDataContext();

            return (from ct in qltv.QL_ChiTietTaiLieus
                    from ncc in qltv.QL_NhaCungCaps
                    from nxb in qltv.QL_NhaXuatBans
                    from tg in qltv.QL_TacGias
                    from vt in qltv.QL_ViTris
                    from tl in qltv.QL_TaiLieus
                    where ct.MaTaiLieu == tl.MaTaiLieu && ct.MaNCC == ncc.MaNCC && ct.MaNXB == nxb.MaNXB && ct.MaTG == tg.MaTacGia && ct.MaViTri == vt.MaViTri
                    select new
                    {
                        ct.MaCTTL,
                        tl.MaTaiLieu,
                        ct.TenChiTiet,
                        ncc.TenNCC,
                        nxb.TenNXB,
                        tg.TenTacGia,
                        vt.TenViTri,
                        ct.SoLuong  

                    }).OrderBy(d=>d.SoLuong);
 
        }

        public IQueryable timtheoma(string matailieu, string machitiet)
        {
            QLTVDataContext qltv = new QLTVDataContext();


            string tentheloai = (from c in qltv.QL_TaiLieus
                                 where c.MaTaiLieu == matailieu
                                 select c.TenTaiLieu).FirstOrDefault();


            return (from ct in qltv.QL_ChiTietTaiLieus
                    from ncc in qltv.QL_NhaCungCaps
                    from nxb in qltv.QL_NhaXuatBans
                    from tg in qltv.QL_TacGias
                    from vt in qltv.QL_ViTris
                    from tl in qltv.QL_TaiLieus
                    where ct.MaCTTL.Equals(machitiet) && ct.MaTaiLieu == tl.MaTaiLieu && tl.MaTaiLieu == matailieu && ct.MaNCC == ncc.MaNCC && ct.MaNXB == nxb.MaNXB && ct.MaTG == tg.MaTacGia && ct.MaViTri == vt.MaViTri
                    select new
                    {
                        ct.MaCTTL,
                        tl.MaTaiLieu,
                        ct.TenChiTiet,
                        ncc.TenNCC,
                        nxb.TenNXB,
                        tg.TenTacGia,
                        vt.TenViTri,
                        ct.SoLuong,
                        ct.Link,
                        ct.SoTrang,
                        ct.GiaBia,
                        ct.GiaNhap,
                        ct.NgayNhap,
                        ct.NguoiNhap,
                        ct.AnhTaiLieu

                    });
        }

        public IQueryable timtheoten(string matailieu, string tenchitiet)
        {
            QLTVDataContext qltv = new QLTVDataContext();


            string tentheloai = (from c in qltv.QL_TaiLieus
                                 where c.MaTaiLieu == matailieu
                                 select c.TenTaiLieu).FirstOrDefault();


            return (from ct in qltv.QL_ChiTietTaiLieus
                    from ncc in qltv.QL_NhaCungCaps
                    from nxb in qltv.QL_NhaXuatBans
                    from tg in qltv.QL_TacGias
                    from vt in qltv.QL_ViTris
                    from tl in qltv.QL_TaiLieus
                    where ct.MaTaiLieu == tl.MaTaiLieu && ct.TenChiTiet.Contains(tenchitiet) && tl.MaTaiLieu == matailieu && ct.MaNCC == ncc.MaNCC && ct.MaNXB == nxb.MaNXB && ct.MaTG == tg.MaTacGia && ct.MaViTri == vt.MaViTri
                    select new
                    {
                        ct.MaCTTL,
                        tl.MaTaiLieu,
                        ct.TenChiTiet,
                        ncc.TenNCC,
                        nxb.TenNXB,
                        tg.TenTacGia,
                        vt.TenViTri,
                        ct.SoLuong,
                        ct.Link,
                        ct.SoTrang,
                        ct.GiaBia,
                        ct.GiaNhap,
                        ct.NgayNhap,
                        ct.NguoiNhap,
                        ct.AnhTaiLieu

                    });
        }
        public IQueryable loadDataG(string matailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();


            string tentheloai = (from c in qltv.QL_TaiLieus
                                 where c.MaTaiLieu == matailieu
                                 select c.TenTaiLieu).FirstOrDefault(); 
            
        
            return (from ct in qltv.QL_ChiTietTaiLieus
                    from ncc in qltv.QL_NhaCungCaps
                    from nxb in qltv.QL_NhaXuatBans
                    from tg in qltv.QL_TacGias
                    from vt in qltv.QL_ViTris
                    from tl in qltv.QL_TaiLieus
                    where ct.MaTaiLieu == tl.MaTaiLieu && tl.MaTaiLieu == matailieu && ct.MaNCC == ncc.MaNCC && ct.MaNXB == nxb.MaNXB && ct.MaTG == tg.MaTacGia && ct.MaViTri == vt.MaViTri
                    select new 
                    {
                        ct.MaCTTL,
                        tl.MaTaiLieu,
                        ct.TenChiTiet,
                        ncc.TenNCC,
                        nxb.TenNXB,
                        tg.TenTacGia,
                        vt.TenViTri,
                        ct.SoLuong,
                        ct.Link,
                        ct.SoTrang,
                        ct.GiaBia,
                        ct.GiaNhap,
                        ct.NgayNhap,
                        ct.NguoiNhap,
                        ct.AnhTaiLieu
                                             
                    });
        }
        public string loadTenDanhMuc(string matailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TaiLieus
                    where a.MaTaiLieu == matailieu
                    select a.TenTaiLieu).FirstOrDefault();
        }
        public IQueryable loadcbbncc()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_NhaCungCaps
                    select a.TenNCC);
        }

        public IQueryable loadcbbvitri()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_ViTris
                    select a.TenViTri);
        }
        public IQueryable loadcbbtacgia()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_TacGias
                    select a.TenTacGia);
        }
        public IQueryable loadcbbnxb()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_NhaXuatBans
                    select a.TenNXB);
        }
        public IQueryable loadcbbtentheloai()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from a in qltv.QL_ChiTietTaiLieus
                    select a.TenChiTiet);
        }
        public bool xoaTaiLieu(string machitiet)
        {
           
                QLTVDataContext qltv = new QLTVDataContext();
                QL_ChiTietTaiLieu delete = qltv.QL_ChiTietTaiLieus.Where(p => p.MaCTTL.Equals(machitiet)).SingleOrDefault();
                qltv.QL_ChiTietTaiLieus.DeleteOnSubmit(delete);
                qltv.SubmitChanges();
                return true;
            
        }
        public string loadMaChiTietTaiLieu(string tentailieu)
        {
            string matailieu;
            QLTVDataContext qltv = new QLTVDataContext();
            return matailieu = (from a in qltv.QL_ChiTietTaiLieus
                                where a.TenChiTiet == tentailieu
                                select a.MaCTTL).FirstOrDefault().ToString();
        }
        public string loadtennxb(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string manxb = (from nxb in qltv.QL_ChiTietTaiLieus
                            where nxb.TenChiTiet == tentailieu
                            select nxb.MaNXB).FirstOrDefault();

            string tennxb;
            return tennxb = (from b in qltv.QL_NhaXuatBans
                             where b.MaNXB == manxb
                             select b.TenNXB).FirstOrDefault();
        }
        public byte[] loadAnhQR(string tentailieu)
        {
            
            QLTVDataContext qltv = new QLTVDataContext();
            var abc =  (from tl in qltv.QL_ChiTietTaiLieus
                                where tl.TenChiTiet == tentailieu
                                select tl.AnhQR).FirstOrDefault();
            byte[] anh = abc.ToArray();
            return anh;

        }

        public byte[] loadAnhTaiLieu(string tentailieu)
        {

            QLTVDataContext qltv = new QLTVDataContext();
            var abc = (from tl in qltv.QL_ChiTietTaiLieus
                       where tl.TenChiTiet == tentailieu
                       select tl.AnhTaiLieu).FirstOrDefault();
            byte[] anh = abc.ToArray();
            return anh;

        }

        public string loadtheloai(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string matheloai = (from tl in qltv.QL_ChiTietTaiLieus
                                where tl.TenChiTiet == tentailieu
                                select tl.MaTaiLieu).FirstOrDefault();

            string tentheloai;
            return tentheloai = (from f in qltv.QL_TaiLieus
                                 where f.MaTaiLieu == matheloai
                                 select f.TenTaiLieu).FirstOrDefault();
        }

        public string loadtacgia(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string matacgia = (from tl in qltv.QL_ChiTietTaiLieus
                               where tl.TenChiTiet == tentailieu
                               select tl.MaTG).FirstOrDefault();

            string tentacgia;
            return tentacgia = (from f in qltv.QL_TacGias
                                where f.MaTacGia == matacgia
                                select f.TenTacGia).FirstOrDefault();
        }

        public string loadvitri(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string mavitri = (from tl in qltv.QL_ChiTietTaiLieus
                              where tl.TenChiTiet == tentailieu
                              select tl.MaViTri).FirstOrDefault();

            string tenvitri;
            return tenvitri = (from f in qltv.QL_ViTris
                               where f.MaViTri == mavitri
                               select f.TenViTri).FirstOrDefault();
        }
        public string loadncc(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string mancc = (from tl in qltv.QL_ChiTietTaiLieus
                              where tl.TenChiTiet == tentailieu
                              select tl.MaNCC).FirstOrDefault();

            string tenvitri;
            return tenvitri = (from f in qltv.QL_NhaCungCaps
                               where f.MaNCC == mancc
                               select f.TenNCC).FirstOrDefault();
        }
        public string loadgiabia(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();

            string giabia;
            return giabia = (from f in qltv.QL_ChiTietTaiLieus
                               where f.TenChiTiet == tentailieu
                               select f.GiaBia).FirstOrDefault().ToString();
        }     


        public string loadsoluongtailieu(string tentailieu)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            return (from r in qltv.QL_ChiTietTaiLieus
                    where r.TenChiTiet == tentailieu
                    select r.SoLuong).FirstOrDefault().ToString();
        }


 
  
        public bool themTaiLieu(string machitiet, string matailieu,string ncc, string nxb, string tacgia, string vitri, string soluong, string link, string sotrang, byte[] anh, byte[] anhQR, string giabia, string gianhap, string ngaynhap, string nguoinhap, string tenchitiet)
        {

         
                QLTVDataContext qltv = new QLTVDataContext();

                string mancc = (from e in qltv.QL_NhaCungCaps
                                where e.TenNCC == ncc
                                select e.MaNCC).FirstOrDefault();

                string manxb = (from a in qltv.QL_NhaXuatBans
                                where a.TenNXB == nxb
                                select a.MaNXB).FirstOrDefault();
                string matg = (from b in qltv.QL_TacGias
                               where b.TenTacGia == tacgia
                               select b.MaTacGia).FirstOrDefault();
                string mavitri = (from c in qltv.QL_ViTris
                                  where c.TenViTri == vitri
                                  select c.MaViTri).FirstOrDefault();

                QL_ChiTietTaiLieu insert = new QL_ChiTietTaiLieu();

                insert.MaCTTL = int.Parse(machitiet);
                insert.MaTaiLieu = matailieu;
                insert.MaNCC = mancc;
                insert.MaNXB = manxb;
                insert.MaTG = matg;
                insert.MaViTri = mavitri;
                insert.SoLuong = int.Parse(soluong);
                insert.Link = link;
                insert.SoTrang = sotrang;
                insert.AnhTaiLieu = anh;
                insert.AnhQR = anhQR;
                insert.GiaBia = decimal.Parse(giabia);
                insert.GiaNhap = decimal.Parse(gianhap);
                insert.NgayNhap = DateTime.Parse(ngaynhap);
                insert.NguoiNhap = nguoinhap;
                insert.TenChiTiet = tenchitiet;


                qltv.QL_ChiTietTaiLieus.InsertOnSubmit(insert);
                qltv.SubmitChanges();
                return true;
            

        }

        public bool SuaTaiLieu(string machitiet, string tenchitiet, string ncc, string nxb, string tacgia, string vitri, string soluong, string link, string sotrang, byte[] anhQR, byte[] anhTaiLieu, string giabia, string gianhap)
        {

                QLTVDataContext qltv = new QLTVDataContext();

                string manxb = (from a in qltv.QL_NhaXuatBans
                                where a.TenNXB == nxb
                                select a.MaNXB).FirstOrDefault();
                string matg = (from b in qltv.QL_TacGias
                               where b.TenTacGia == tacgia
                               select b.MaTacGia).FirstOrDefault();
                string mavitri = (from c in qltv.QL_ViTris
                                  where c.TenViTri == vitri
                                  select c.MaViTri).FirstOrDefault();
                string mancc = (from d in qltv.QL_NhaCungCaps
                                    where d.TenNCC == ncc
                                    select d.MaNCC).FirstOrDefault();
                QL_ChiTietTaiLieu edit = qltv.QL_ChiTietTaiLieus.Where(p => p.MaCTTL.Equals(machitiet)).SingleOrDefault();

                edit.TenChiTiet = tenchitiet;
                edit.MaNCC = mancc;
                edit.MaNXB = manxb;
                edit.MaTG = matg;
                edit.MaViTri = mavitri;
                edit.SoLuong = int.Parse(soluong);
                edit.Link = link;
                edit.SoTrang = sotrang;
                edit.AnhTaiLieu = anhTaiLieu;
                edit.AnhQR = anhQR;
                edit.GiaBia = decimal.Parse(giabia);
                edit.GiaNhap = decimal.Parse(gianhap);            
                qltv.SubmitChanges();
                return true;

        }

        //public IQueryable timkiemtheoten(string tentailieu)
        //{


        //}
        //public IQueryable timkiemtheoma(string matailieu)
        //{


        //}


    }
}
