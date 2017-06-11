using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccess;

namespace Business
{
   public class NhanVienBUS
    {
        readonly NhanVienDAL _nhanVien = new NhanVienDAL();
        public List<NhanVien> ViewNhanVien()
        {
            return _nhanVien.ViewNhanVien();
        }
        public void ThemNhanVien(NhanVien nhanVien)
        {
            _nhanVien.ThemNhanVien(nhanVien);
        }
        public void SuaNhanVien(NhanVien nhanVien)
        {
            _nhanVien.SuaNhanVien(nhanVien);
        }
        public void XoaNhanVien(decimal maNhanVien)
        {
            _nhanVien.XoaNhanVien(maNhanVien);
        }
    }
}
