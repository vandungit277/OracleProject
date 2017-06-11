using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccess
{
    public class LoaiHangHoaDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<LoaiHangHoa> ViewLoaiHang()
        {
            return db.VIEWLOAIHANG.Select(item => new LoaiHangHoa
            {
                MALOAIHANG = item.MALOAIHANG,
                TENLOAIHANG = item.TENLOAIHANG
            }).ToList();
        }
        public bool ThemloaiHangHoa(LoaiHangHoa loaiHangHoa)
        {
            var item = db.THEMLOAIHANG(loaiHangHoa.TENLOAIHANG);
            return true;
        }
        public bool SualoaiHangHoa(LoaiHangHoa loaiHangHoa)
        {
            var item = db.SUALOAIHANGHOA(loaiHangHoa.MALOAIHANG, loaiHangHoa.TENLOAIHANG);
            return true;
        }
        public bool XoaLoaiHangHoa(decimal maloaiHangHoa)
        {
            var item = db.XOALOAIHANG(maloaiHangHoa);
            return true;
        }
    }
}
