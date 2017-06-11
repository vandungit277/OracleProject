using System.Collections.Generic;
using DataTransferObject;
using DataAccess;

namespace Business
{
   public class KhachHangBUS
    {
        private readonly DataAccess.Model.Oracle db = new DataAccess.Model.Oracle();
        private readonly KhachHangDAL _khachHang = new KhachHangDAL();
        public List<KhachHang> ViewKhachHang()
        {
            return _khachHang.ViewKhachHang();
        }

        public void ThemKhachHang(KhachHang nhaPhanPhoi)
        {
            _khachHang.ThemKhachHang(nhaPhanPhoi);
        }
        public void SuaKhachHang(KhachHang nhaPhanPhoi)
        {
            _khachHang.SuaKhachHang(nhaPhanPhoi);
        }
        public void XoaKhachHang(decimal maKhachHang)
        {
            _khachHang.XoaKhachHang(maKhachHang);
        }
    }
}
