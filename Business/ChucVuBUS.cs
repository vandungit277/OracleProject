using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataTransferObject;

namespace Business
{
   public class ChucVuBUS
    {
        readonly ChucVuDAL _chucVu = new ChucVuDAL();
        public List<ChucVu> ViewChucVu()
        {
            return _chucVu.ViewChucVu();
        }
        public void ThemChucVu(ChucVu chucVu)
        {
            _chucVu.ThemChucVu(chucVu);
        }
        public void SuaChucVu(ChucVu chucVu)
        {
            _chucVu.SuaChucVu(chucVu);
        }
        public void XoaChucVu(decimal maChucVu)
        {
            _chucVu.XoaChucVu(maChucVu);
        }
    }
}
