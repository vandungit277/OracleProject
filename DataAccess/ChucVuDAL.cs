using DataTransferObject;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
   public class ChucVuDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<ChucVu> ViewChucVu()
        {
            return db.VIEWCHUCVU.Select(item => new ChucVu
            {
                MACHUCVU = item.MACHUCVU,
                TENCHUCVU = item.TENCHUCVU,
                MOTA = item.MOTA           
            }).ToList();
        }
        public bool ThemChucVu(ChucVu chucVu)
        {
            var item = db.THEMCHUCVU(chucVu.TENCHUCVU,chucVu.MOTA);
            return true;
        }
        public bool SuaChucVu(ChucVu chucVu)
        {
            var item = db.SUACHUCVU(chucVu.MACHUCVU, chucVu.TENCHUCVU, chucVu.MOTA);
            return true;
        }
        public bool XoaChucVu(decimal maChucVu)
        {
            var item = db.XOACHUCVU(maChucVu);
            return true;
        }
    }
}
