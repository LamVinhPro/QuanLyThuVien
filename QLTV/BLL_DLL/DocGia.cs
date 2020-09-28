using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class DocGia
    {
        QLTVDataContext qltv = new QLTVDataContext();

        public string taoMaTuDong()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            var item = qltv.QL_DocGias.Max(d => d.MaDocGia);
            if (item == null)
                item = "0";
            return item.ToString();

        }
        public IQueryable loadcbbtenloaidocgia()
        {
            return (from a in qltv.QL_LoaiDocGias
                        select a.TenLoaiDocGia);
        }

        public byte[] loadAnhQR(string madocgia)
        {

            QLTVDataContext qltv = new QLTVDataContext();
            var abc = (from tl in qltv.QL_DocGias
                       where tl.MaDocGia == madocgia
                       select tl.Anh).FirstOrDefault();
            byte[] anhQR = abc.ToArray();
            return anhQR;

        }

        public byte[] loadAnhDocGia(string madocgia)
        {

            QLTVDataContext qltv = new QLTVDataContext();
            var abc = (from tl in qltv.QL_DocGias
                       where tl.MaDocGia == madocgia
                       select tl.AnhDocGia).FirstOrDefault();
            byte[] anhDocGia = abc.ToArray();
            return anhDocGia;

        }
        public bool xoadocgia(string madocgia)
        {
            QL_DocGia delete = qltv.QL_DocGias.Where(p => p.MaDocGia.Equals(madocgia)).SingleOrDefault();
            qltv.QL_DocGias.DeleteOnSubmit(delete);
            qltv.SubmitChanges();
            return true;
        }

        public bool suadocgia(string madocgia, string tendocgia, string gioitinh, string ngaysinh, string diachi, string sodienthoai, byte[] anhqr, string ngaytao, string email, string tenloaidocgia, byte[] anhdocgia)
        {
            try
            {
                string maloaidocgia = (from a in qltv.QL_LoaiDocGias
                                       where a.TenLoaiDocGia == tenloaidocgia
                                       select a.MaLoaiDocGia).FirstOrDefault();
                QL_DocGia edit = qltv.QL_DocGias.Where(d=>d.MaDocGia.Equals(madocgia)).SingleOrDefault();

                edit.TenDocGia = tendocgia;
                edit.LoaiDocGia = maloaidocgia;
                edit.GioiTinh = gioitinh;
                edit.NgaySinh = DateTime.Parse(ngaysinh);
                edit.DiaChi = diachi;
                edit.SoDienThoai = sodienthoai;
                edit.Anh = anhqr;
                edit.NgayTao = DateTime.Parse(ngaytao);
                edit.Emai = email;
                edit.AnhDocGia = anhdocgia;
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool themdocgia(string madocgia, string tendocgia, string gioitinh, string ngaysinh, string diachi, string sodienthoai, byte[] anhqr, string ngaytao, string email, string tenloaidocgia, byte[] anhdocgia)
        {

          
                string maloaidocgia = (from a in qltv.QL_LoaiDocGias
                                       where a.TenLoaiDocGia == tenloaidocgia
                                       select a.MaLoaiDocGia).FirstOrDefault();
                QL_DocGia insert = new QL_DocGia();

                insert.MaDocGia = madocgia;
                insert.TenDocGia = tendocgia;
                insert.LoaiDocGia = maloaidocgia;
                insert.GioiTinh = gioitinh;
                insert.NgaySinh = DateTime.Parse(ngaysinh);
                insert.DiaChi = diachi;
                insert.SoDienThoai = sodienthoai;
                insert.Anh = anhqr;
                insert.NgayTao = DateTime.Parse(ngaytao);
                insert.Emai = email;
                insert.AnhDocGia = anhdocgia;
                qltv.QL_DocGias.InsertOnSubmit(insert);
                qltv.SubmitChanges();
                return true;
          

 
        }

        public string loademail(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    where a.MaDocGia == madocgia
                    select a.Emai).FirstOrDefault().ToString();
        }

        public string loadngaytao(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    where a.MaDocGia == madocgia
                    select a.NgayTao).FirstOrDefault().ToString();
        }

        public string loadsodienthoai(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    where a.MaDocGia == madocgia
                    select a.SoDienThoai).FirstOrDefault().ToString();
        }

        public string loaddiachi(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    where a.MaDocGia == madocgia
                    select a.DiaChi).FirstOrDefault().ToString();
        }

        public string loadngaysinh(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    where a.MaDocGia == madocgia
                   select a.NgaySinh).FirstOrDefault().ToString();
        }
        public string loadloaidocgia(string madocgia)
        {
            string maloaidocgia = (from a in qltv.QL_DocGias
                                      where a.MaDocGia == madocgia
                                       select a.LoaiDocGia).FirstOrDefault();
            string tenloaidocgia = (from b in qltv.QL_LoaiDocGias
                                        where b.MaLoaiDocGia == maloaidocgia
                                        select b.TenLoaiDocGia).FirstOrDefault();
            return tenloaidocgia;
        }
        public string loadtendocgia(string madocgia)
        {
           return (from a in qltv.QL_DocGias
                       where a.MaDocGia == madocgia
                       select a.TenDocGia).FirstOrDefault();
        }
        public string loadgioitinh(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    where a.MaDocGia == madocgia
                    select a.GioiTinh).FirstOrDefault(); ;
        }
        public IQueryable timKiem(string tendocgia)
        {
           return(from a in qltv.QL_DocGias
                      where a.TenDocGia.StartsWith(tendocgia)
                   select new
                   {
                       a.MaDocGia,
                       a.TenDocGia
                   });
        }

        public IQueryable loadDataG()
        {
            return (from a in qltv.QL_DocGias
                    from b in qltv.QL_LoaiDocGias
                    where a.LoaiDocGia == b.MaLoaiDocGia
                    select new
                    {
                        a.MaDocGia,
                        a.TenDocGia,
                        a.GioiTinh,
                        a.NgaySinh,
                        a.DiaChi,
                        a.SoDienThoai,
                        a.NgayTao,
                        a.Emai,
                        b.TenLoaiDocGia

                    });
        }
        public IQueryable timtheoma(string madocgia)
        {
            return (from a in qltv.QL_DocGias
                    from b in qltv.QL_LoaiDocGias
                    where a.LoaiDocGia == b.MaLoaiDocGia && a.MaDocGia.Equals(madocgia)
                    select new
                    {
                        a.MaDocGia,
                        a.TenDocGia,
                        a.GioiTinh,
                        a.NgaySinh,
                        a.DiaChi,
                        a.SoDienThoai,
                        a.NgayTao,
                        a.Emai,
                        b.TenLoaiDocGia

                    });
        }
        public IQueryable timkiemtheoten(string tendocgia)
        {
            return (from a in qltv.QL_DocGias
                    from b in qltv.QL_LoaiDocGias
                    where a.LoaiDocGia == b.MaLoaiDocGia && a.TenDocGia.Contains(tendocgia)
                    select new
                    {
                        a.MaDocGia,
                        a.TenDocGia,
                        a.GioiTinh,
                        a.NgaySinh,
                        a.DiaChi,
                        a.SoDienThoai,
                        a.NgayTao,
                        a.Emai,
                        b.TenLoaiDocGia

                    });
        }
    }
}
