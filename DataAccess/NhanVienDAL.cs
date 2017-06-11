using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccess
{
   public class NhanVienDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<NhanVien> ViewNhanVien()
        {
            return db.VIEWNHANVIEN.Select(item => new NhanVien
            {
                MANHANVIEN = item.MANHANVIEN,
                TENNHANVIEN = item.TENCHUCVU,
                //nếu database giới tính ==0 thì là nam ngược lại là nữ.
                GIOITINH = item.GIOITINH == 0 ? "Nam" : "Nữ",
                NTNS = item.NTNS,
                SODIENTHOAI = item.SODIENTHOAI,
                CMND = item.CMND,
                DIACHI = item.DIACHI,
                EMAIL = item.EMAIL,
                TENCHUCVU = item.TENCHUCVU

            }).ToList();
        }
        public bool ThemNhanVien(NhanVien nhanVien)
        {
            var gt = nhanVien.GIOITINH == "Nam" ? 0 : 1;
            var item = db.THEMNHANVIEN( nhanVien.TENNHANVIEN, gt, nhanVien.NTNS, nhanVien.SODIENTHOAI, nhanVien.CMND, nhanVien.EMAIL, nhanVien.DIACHI, nhanVien.MACHUCVU);
            return true;
        }
        public bool SuaNhanVien(NhanVien nhanVien)
        {
            var gt = nhanVien.GIOITINH == "Nam" ? 0 : 1;
            var item = db.SUANHANVIEN(nhanVien.MANHANVIEN, nhanVien.TENNHANVIEN, gt, nhanVien.NTNS, nhanVien.SODIENTHOAI, nhanVien.CMND, nhanVien.EMAIL, nhanVien.DIACHI, nhanVien.MACHUCVU);
            return true;
        }
        public bool XoaNhanVien(decimal maNhanVien)
        {
            var item = db.XOANHANVIEN(maNhanVien);
            return true;
        }
    }
}
