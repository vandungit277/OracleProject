//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleManager.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.TAIKHOANs = new HashSet<TAIKHOAN>();
            this.PHIEUXUATs = new HashSet<PHIEUXUAT>();
            this.PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }
    
        public decimal MANHANVIEN { get; set; }
        public string TENNHANVIEN { get; set; }
        public Nullable<short> GIOITINH { get; set; }
        public Nullable<System.DateTime> NTNS { get; set; }
        public string SODIENTHOAI { get; set; }
        public string CMND { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public decimal MACHUCVU { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual ICollection<PHIEUXUAT> PHIEUXUATs { get; set; }
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
