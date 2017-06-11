using DataTransferObject;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class SanPhamDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<HangHoa> ViewHangHoa()
        {
            return db.VIEWHANGHOA.Select(item => new HangHoa
            {
                MAHANGHOA = item.MAHANGHOA,
                TENHANGHOA = item.TENHANGHOA,
                MOTA = item.MOTA,
                GIANHAP = item.GIANHAP,
                SOLUONGTON = item.SOLUONGTON,
                TENLOAIHANG = item.TENLOAIHANG,
                TENNSX = item.TENNSX
            }).ToList();
        }        
        public bool ThemHangHoa(HangHoa hangHoa)
        {
            var item = db.THEMHANGHOA(hangHoa.TENHANGHOA, hangHoa.MOTA, hangHoa.SOLUONGTON, hangHoa.GIANHAP, hangHoa.MANSX, hangHoa.MALOAIHANG);
            return true;
        }
        public bool SuaHangHoa(HangHoa hangHoa)
        {
            var item = db.SUAHANGHOA(hangHoa.MAHANGHOA, hangHoa.TENHANGHOA, hangHoa.MOTA, hangHoa.SOLUONGTON, hangHoa.GIANHAP, hangHoa.MANSX, hangHoa.MALOAIHANG);
            return true;
        }
        public bool XoaHangHoa(decimal maHangHoa)
        {
            var item = db.XOAHANGHOA(maHangHoa);
            return true;
        }
    }
}
