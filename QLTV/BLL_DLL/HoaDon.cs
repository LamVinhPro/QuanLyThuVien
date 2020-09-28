using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class HoaDon
    {
        QLTVDataContext qltv = new QLTVDataContext();

        public bool themHoaDon(int mahoadon, string nguoilap, string madocgia, string ngaymuon, string ngaytra, int tongsoluong, string trangthai)
        {
            try
            {

                QL_HoaDon insert = new QL_HoaDon();

                insert.MaHD = mahoadon;
                insert.NguoiLap = nguoilap;
                insert.MaDocGia = madocgia;
                insert.NgayMuon = DateTime.Parse(ngaymuon);
                insert.NgayHenTra = DateTime.Parse(ngaytra);
                insert.TongSoLuong = tongsoluong;
                insert.TrangThai = trangthai;           
                qltv.QL_HoaDons.InsertOnSubmit(insert);
                qltv.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
 
        }
        public IQueryable loadDataG()
        {
            return (from a in qltv.QL_HoaDons
                    from b in qltv.QL_DocGias
                    where a.MaDocGia == b.MaDocGia
                    select new 
                    {
                        a.MaHD,
                        a.NguoiLap,
                        a.MaDocGia,
                        b.TenDocGia,
                        a.NgayMuon,
                        a.NgayHenTra,
                        a.TongSoLuong,
                        a.TrangThai,
                        a.GhiChu
                    });
        }
        public string taoMaTuDong()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            var item = qltv.QL_HoaDons.Max(d => d.MaHD);
            if (item == null)
                item = 0;
            return item.ToString();

        }

        public string layMaDG(string sdt)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string ma = (from a in qltv.QL_DocGias
                         where a.SoDienThoai == sdt
                         select a.MaDocGia).FirstOrDefault();
            return ma;
        }
        public string laytenloaidg(string sdt)
        {
            QLTVDataContext qltv = new QLTVDataContext();
            string maloaidg = (from a in qltv.QL_DocGias
                         where a.SoDienThoai == sdt
                         select a.LoaiDocGia).FirstOrDefault();
            string tenloaidg = (from b in qltv.QL_LoaiDocGias
                                where b.MaLoaiDocGia == maloaidg
                                select b.TenLoaiDocGia).FirstOrDefault();
            return tenloaidg;
        }

        public string kiemTraMaDocGia(string sdt)
        {
            try
            {
                QLTVDataContext qltv = new QLTVDataContext();
                string tendocgia = (from a in qltv.QL_DocGias
                                    where a.SoDienThoai.Equals(sdt)
                                    select a.TenDocGia).FirstOrDefault();

                return tendocgia;
            }
            catch (Exception ex)
            {
                return "";
            }                              
        }
        public IQueryable timkiemtheoma(string mahd)
        {
            return (from a in qltv.QL_HoaDons
                    from b in qltv.QL_DocGias
                    where a.MaDocGia == b.MaDocGia && a.MaHD.Equals(mahd)
                    select new
                    {
                        a.MaHD,
                        a.NguoiLap,
                        a.MaDocGia,
                        b.TenDocGia,
                        a.NgayMuon,
                        a.NgayHenTra,
                        a.TongSoLuong,
                        a.TrangThai,
                        a.GhiChu
                    });
        }
        public IQueryable timkiemtheoten(string tendocgia)
        {
            return (from a in qltv.QL_HoaDons
                    from b in qltv.QL_DocGias
                    where a.MaDocGia == b.MaDocGia && b.TenDocGia.Contains(tendocgia)
                    select new 
                    {
                        a.MaHD,
                        a.NguoiLap,
                        a.MaDocGia,
                        b.TenDocGia,
                        a.NgayMuon,
                        a.NgayHenTra,
                        a.TongSoLuong,
                        a.TrangThai,
                        a.GhiChu
                    });
        }
    }
}
