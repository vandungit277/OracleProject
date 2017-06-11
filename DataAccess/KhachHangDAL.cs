using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccess
{
   public class KhachHangDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<KhachHang> ViewKhachHang()
        {
            return db.VIEWKHACHHANG.Select(item => new KhachHang
            {
                MAKHACHHANG = item.MAKHACHHANG,
                TENKHACHHANG = item.TENKHACHHANG,
                SODIENTHOAI = item.SODIENTHOAI,
                DIACHI = item.DIACHI,
                EMAIL = item.EMAIL
            }).ToList();
        }
        public bool ThemKhachHang(KhachHang khachHang)
        {
            var item = db.THEMKHACHHANG(khachHang.TENKHACHHANG, khachHang.SODIENTHOAI, khachHang.DIACHI,khachHang.EMAIL);
            return true;
        }
        public bool SuaKhachHang(KhachHang khachHang)
        {
            var item = db.SUAKHACHHANG(khachHang.MAKHACHHANG, khachHang.TENKHACHHANG, khachHang.SODIENTHOAI, khachHang.DIACHI, khachHang.EMAIL);
            return true;
        }
        public bool XoaKhachHang(decimal maKhachHang)
        {
            var item = db.XOAKHACHHANG(maKhachHang);
            return true;
        }
    }
}
