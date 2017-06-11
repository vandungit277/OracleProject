using DataAccess;
using DataTransferObject;
using System.Collections.Generic;

namespace Business
{
    public class SanPhamBUS
    {
        readonly SanPhamDAL _hangHoa = new SanPhamDAL();
        public List<HangHoa> ViewHangHoa()
        {
            return _hangHoa.ViewHangHoa();
        }
        public void ThemHangHoa(HangHoa hangHoa)
        {
            _hangHoa.ThemHangHoa(hangHoa);
        }
        public void SuaHangHoa(HangHoa hangHoa)
        {
            _hangHoa.SuaHangHoa(hangHoa);
        }
        public void XoaHangHoa(decimal maHangHoa)
        {
            _hangHoa.XoaHangHoa(maHangHoa);
        }
    }
}
