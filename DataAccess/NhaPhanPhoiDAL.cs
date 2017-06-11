using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccess
{
   public class NhaPhanPhoiDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<NhaPhanPhoi> ViewNhaPhanPhoi()
        {
            return db.VIEWNHAPHANPHOI.Select(item => new NhaPhanPhoi
            {
                MANPP = item.MANPP,
                TENNPP = item.TENNPP,
                SODIENTHOAI = item.SODIENTHOAI,
                DIACHI = item.DIACHI
            }).ToList();
        }
        public bool ThemNPP(NhaPhanPhoi nhaPhanPhoi)
        {
            var item = db.THEMNPP(nhaPhanPhoi.TENNPP,nhaPhanPhoi.SODIENTHOAI,nhaPhanPhoi.DIACHI);
            return true;
        }
        public bool SuaNPP(NhaPhanPhoi nhaPhanPhoi)
        {
            var item = db.SUANPP(nhaPhanPhoi.MANPP, nhaPhanPhoi.TENNPP, nhaPhanPhoi.SODIENTHOAI, nhaPhanPhoi.DIACHI);
            return true;
        }
        public bool XoaNPP(decimal maNhaPhanPhoi)
        {
            var item = db.XOANPP(maNhaPhanPhoi);
            return true;
        }
    }
}
