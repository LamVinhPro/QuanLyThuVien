using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DLL
{
    public class ChiTietHoaDon
    {
        QLTVDataContext qltv = new QLTVDataContext();

        // cap nhat trang thai hoa don khi tra thanh cong

        public bool capNhatTrangThaiHoaDon(int mahoadon)
        {
            QL_HoaDon edit = qltv.QL_HoaDons.Where(d => d.MaHD == mahoadon).SingleOrDefault();
            edit.TrangThai = "Đã trả";
            qltv.SubmitChanges();
            return true;

        }


        // thuc hien tra sach

        public bool thucHienTraSach(string machitiet, string mahoadon)
        {
            // lay so luong muon

            string soluongmuon = (from a in qltv.QL_ChiTietHoaDons
                                  where a.MaCTHD == int.Parse(machitiet)
                                  select a.SoLuong).FirstOrDefault().ToString();
            string matailieu = (from b in qltv.QL_ChiTietHoaDons
                                where b.MaCTHD == int.Parse(machitiet)
                                select b.MaTaiLieu).FirstOrDefault().ToString();
            string soluongtailieu = (from c in qltv.QL_ChiTietTaiLieus
                                     where c.MaCTTL == int.Parse(matailieu)
                                     select c.SoLuong).FirstOrDefault().ToString();
            int soluongmoi = int.Parse(soluongmuon) + int.Parse(soluongtailieu);


            QL_ChiTietTaiLieu edit = qltv.QL_ChiTietTaiLieus.Where(d => d.MaCTTL.Equals(matailieu)).SingleOrDefault();
            edit.SoLuong = soluongmoi;
            QL_HoaDon edit2 = qltv.QL_HoaDons.Where(d => d.MaHD.Equals(mahoadon)).SingleOrDefault();
            edit2.TrangThai = "Đã trả";
            qltv.SubmitChanges();
            return true;


        }
        // cap nhat hoa don 
        public bool thayDoitongSoSach(int mahoadon)
        {
            string tongsoluong = (qltv.QL_ChiTietHoaDons.Where(a => a.MaHD == mahoadon).Sum(d => d.SoLuong)).ToString();
            QL_HoaDon edit = qltv.QL_HoaDons.Where(d => d.MaHD.Equals(mahoadon)).SingleOrDefault();
            edit.TongSoLuong = int.Parse(tongsoluong);
            qltv.SubmitChanges();
            return true;
        }
        // thay doi so luong sach khi muon
        public bool thayDoiSoLuongSach(string matailieu, int soluong)
        {
            
                string soluongtailieu = (from tl in qltv.QL_ChiTietTaiLieus
                                         where tl.MaCTTL == int.Parse(matailieu)   
                                         select tl.SoLuong).FirstOrDefault().ToString();


                QL_ChiTietTaiLieu edit = qltv.QL_ChiTietTaiLieus.Where(d => d.MaCTTL.Equals(matailieu)).SingleOrDefault();
                int soluongmoi = int.Parse(soluongtailieu) - soluong;

                edit.SoLuong = soluongmoi;
                qltv.SubmitChanges();
                return true;     

        }

        public bool themChiTietHoaDon(int macthd, int mahoadon, string matailieu, int soluong)
        {
  
    
                QL_ChiTietHoaDon insert = new QL_ChiTietHoaDon();
                insert.MaCTHD = macthd;
                insert.MaHD = mahoadon;
                insert.MaTaiLieu = int.Parse(matailieu);
                insert.SoLuong = soluong;
                qltv.QL_ChiTietHoaDons.InsertOnSubmit(insert);
                qltv.SubmitChanges();
                return true;
           
       

        }

        public IQueryable loadDataG(int mahoadon)
        {
            return (from a in qltv.QL_ChiTietHoaDons
                    from b in qltv.QL_ChiTietTaiLieus
                    where a.MaHD == mahoadon && a.MaTaiLieu == b.MaCTTL
                    select new
                    {
                        a.MaCTHD,
                        a.MaTaiLieu,
                        b.TenChiTiet,
                        a.SoLuong,
                    });
        }
        public IQueryable loadDataGTaiLieu()
        {
            return (from a in qltv.QL_ChiTietTaiLieus
                    select new
                    {
                        a.MaCTTL,
                        a.MaTaiLieu,
                        a.TenChiTiet,
                        a.SoLuong,

                    });
        }

        public string taoMaTuDong()
        {
            QLTVDataContext qltv = new QLTVDataContext();
            var item = qltv.QL_ChiTietHoaDons.Max(d => d.MaCTHD);
            if (item == null)
                item = 0;
            return item.ToString();
        }
    }
}
