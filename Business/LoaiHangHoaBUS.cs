using System.Collections.Generic;
using DataTransferObject;
using DataAccess;

namespace Business
{
    public class LoaiHangHoaBUS
    {
        private readonly DataAccess.Model.Oracle db = new DataAccess.Model.Oracle();
        private readonly LoaiHangHoaDAL _loaiHang = new LoaiHangHoaDAL();
        public List<LoaiHangHoa> ViewLoaiHang()
        {
            return _loaiHang.ViewLoaiHang();
        }

        public void ThemLoaiHang(LoaiHangHoa loaiHangHoa)
        {
            _loaiHang.ThemloaiHangHoa(loaiHangHoa);
        }
        public void SuaLoaiHang(LoaiHangHoa loaiHangHoa)
        {
            _loaiHang.SualoaiHangHoa(loaiHangHoa);
        }
        public void XoaLoaiHang(decimal maloaiHangHoa)
        {
            _loaiHang.XoaLoaiHangHoa(maloaiHangHoa);
        }
    }


}
