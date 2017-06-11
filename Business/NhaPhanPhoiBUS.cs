using System.Collections.Generic;
using DataTransferObject;
using DataAccess;

namespace Business
{
   public class NhaPhanPhoiBUS
    {
        private readonly DataAccess.Model.Oracle db = new DataAccess.Model.Oracle();
        private readonly NhaPhanPhoiDAL _npp = new NhaPhanPhoiDAL();
        public List<NhaPhanPhoi> ViewNhaPhanPhoi()
        {
            return _npp.ViewNhaPhanPhoi();
        }

        public void ThemNPP(NhaPhanPhoi nhaPhanPhoi)
        {
            _npp.ThemNPP(nhaPhanPhoi);
        }
        public void SuaNPP(NhaPhanPhoi nhaPhanPhoi)
        {
            _npp.SuaNPP(nhaPhanPhoi);
        }
        public void XoaNPP(decimal maNhaPhanPhoi)
        {
            _npp.XoaNPP(maNhaPhanPhoi);
        }
    }
}
