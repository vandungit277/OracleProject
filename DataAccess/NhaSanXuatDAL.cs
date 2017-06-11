using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccess
{
    public class NhaSanXuatDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<NhaSanXuat> ViewNhaSanXuat()
        {
            return db.VIEWNHASANXUAT.Select(item => new NhaSanXuat
            {
                MANSX = item.MANSX,
                TENNSX = item.TENNSX
            }).ToList();
        }

        public bool ThemNSX(NhaSanXuat nhaSanXuat)
        {
            var item = db.THEMNSX(nhaSanXuat.TENNSX);
            return true;
        }
        public bool SuaNSX(NhaSanXuat nhaSanXuat)
        {
            var item = db.SUANSX(nhaSanXuat.MANSX, nhaSanXuat.TENNSX);
            return true;
        }
        public bool XoaNSX(decimal maNhaSanXuat)
        {
            var item = db.XOANSX(maNhaSanXuat);
            return true;
        }
    }
}
