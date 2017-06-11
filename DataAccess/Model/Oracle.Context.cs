﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Oracle : DbContext
    {
        public Oracle()
            : base("name=Oracle")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<VIEW_HANG_HOA> VIEW_HANG_HOA { get; set; }
        public DbSet<VIEW_LOAI_HANG> VIEW_LOAI_HANG { get; set; }
        public DbSet<VIEW_NHA_SAN_XUAT> VIEW_NHA_SAN_XUAT { get; set; }
        public DbSet<VIEW_TEN_HANG_HOA> VIEW_TEN_HANG_HOA { get; set; }
    
        public virtual int SUA_HANG_HOA(Nullable<decimal> p_MAHANGHOA, string p_TENHANGHOA, string p_MOTA, Nullable<decimal> p_SOLUONGTON, Nullable<decimal> p_GIANHAP, Nullable<decimal> p_MANSX, Nullable<decimal> p_MALOAIHANG)
        {
            var p_MAHANGHOAParameter = p_MAHANGHOA.HasValue ?
                new ObjectParameter("P_MAHANGHOA", p_MAHANGHOA) :
                new ObjectParameter("P_MAHANGHOA", typeof(decimal));
    
            var p_TENHANGHOAParameter = p_TENHANGHOA != null ?
                new ObjectParameter("P_TENHANGHOA", p_TENHANGHOA) :
                new ObjectParameter("P_TENHANGHOA", typeof(string));
    
            var p_MOTAParameter = p_MOTA != null ?
                new ObjectParameter("P_MOTA", p_MOTA) :
                new ObjectParameter("P_MOTA", typeof(string));
    
            var p_SOLUONGTONParameter = p_SOLUONGTON.HasValue ?
                new ObjectParameter("P_SOLUONGTON", p_SOLUONGTON) :
                new ObjectParameter("P_SOLUONGTON", typeof(decimal));
    
            var p_GIANHAPParameter = p_GIANHAP.HasValue ?
                new ObjectParameter("P_GIANHAP", p_GIANHAP) :
                new ObjectParameter("P_GIANHAP", typeof(decimal));
    
            var p_MANSXParameter = p_MANSX.HasValue ?
                new ObjectParameter("P_MANSX", p_MANSX) :
                new ObjectParameter("P_MANSX", typeof(decimal));
    
            var p_MALOAIHANGParameter = p_MALOAIHANG.HasValue ?
                new ObjectParameter("P_MALOAIHANG", p_MALOAIHANG) :
                new ObjectParameter("P_MALOAIHANG", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUA_HANG_HOA", p_MAHANGHOAParameter, p_TENHANGHOAParameter, p_MOTAParameter, p_SOLUONGTONParameter, p_GIANHAPParameter, p_MANSXParameter, p_MALOAIHANGParameter);
        }
    
        public virtual int THEM_CHI_TIET_PHIEU_XUAT(Nullable<decimal> p_MAHH, Nullable<decimal> p_SOLUONG, Nullable<decimal> p_TONGTIEN)
        {
            var p_MAHHParameter = p_MAHH.HasValue ?
                new ObjectParameter("P_MAHH", p_MAHH) :
                new ObjectParameter("P_MAHH", typeof(decimal));
    
            var p_SOLUONGParameter = p_SOLUONG.HasValue ?
                new ObjectParameter("P_SOLUONG", p_SOLUONG) :
                new ObjectParameter("P_SOLUONG", typeof(decimal));
    
            var p_TONGTIENParameter = p_TONGTIEN.HasValue ?
                new ObjectParameter("P_TONGTIEN", p_TONGTIEN) :
                new ObjectParameter("P_TONGTIEN", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEM_CHI_TIET_PHIEU_XUAT", p_MAHHParameter, p_SOLUONGParameter, p_TONGTIENParameter);
        }
    
        public virtual int THEM_HANG_HOA(string p_TENHANGHOA, string p_MOTA, Nullable<decimal> p_SOLUONGTON, Nullable<decimal> p_GIANHAP, Nullable<decimal> p_MANSX, Nullable<decimal> p_MALOAIHANG)
        {
            var p_TENHANGHOAParameter = p_TENHANGHOA != null ?
                new ObjectParameter("P_TENHANGHOA", p_TENHANGHOA) :
                new ObjectParameter("P_TENHANGHOA", typeof(string));
    
            var p_MOTAParameter = p_MOTA != null ?
                new ObjectParameter("P_MOTA", p_MOTA) :
                new ObjectParameter("P_MOTA", typeof(string));
    
            var p_SOLUONGTONParameter = p_SOLUONGTON.HasValue ?
                new ObjectParameter("P_SOLUONGTON", p_SOLUONGTON) :
                new ObjectParameter("P_SOLUONGTON", typeof(decimal));
    
            var p_GIANHAPParameter = p_GIANHAP.HasValue ?
                new ObjectParameter("P_GIANHAP", p_GIANHAP) :
                new ObjectParameter("P_GIANHAP", typeof(decimal));
    
            var p_MANSXParameter = p_MANSX.HasValue ?
                new ObjectParameter("P_MANSX", p_MANSX) :
                new ObjectParameter("P_MANSX", typeof(decimal));
    
            var p_MALOAIHANGParameter = p_MALOAIHANG.HasValue ?
                new ObjectParameter("P_MALOAIHANG", p_MALOAIHANG) :
                new ObjectParameter("P_MALOAIHANG", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEM_HANG_HOA", p_TENHANGHOAParameter, p_MOTAParameter, p_SOLUONGTONParameter, p_GIANHAPParameter, p_MANSXParameter, p_MALOAIHANGParameter);
        }
    
        public virtual int THEM_KHACH_HANG(string p_TEN, string p_SDT, string p_DC, string p_EMAIL)
        {
            var p_TENParameter = p_TEN != null ?
                new ObjectParameter("P_TEN", p_TEN) :
                new ObjectParameter("P_TEN", typeof(string));
    
            var p_SDTParameter = p_SDT != null ?
                new ObjectParameter("P_SDT", p_SDT) :
                new ObjectParameter("P_SDT", typeof(string));
    
            var p_DCParameter = p_DC != null ?
                new ObjectParameter("P_DC", p_DC) :
                new ObjectParameter("P_DC", typeof(string));
    
            var p_EMAILParameter = p_EMAIL != null ?
                new ObjectParameter("P_EMAIL", p_EMAIL) :
                new ObjectParameter("P_EMAIL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEM_KHACH_HANG", p_TENParameter, p_SDTParameter, p_DCParameter, p_EMAILParameter);
        }
    
        public virtual int THEM_PHIEU_XUAT(Nullable<decimal> p_MANV, string p_TEN, string p_SDT, string p_DC, string p_EMAIL)
        {
            var p_MANVParameter = p_MANV.HasValue ?
                new ObjectParameter("P_MANV", p_MANV) :
                new ObjectParameter("P_MANV", typeof(decimal));
    
            var p_TENParameter = p_TEN != null ?
                new ObjectParameter("P_TEN", p_TEN) :
                new ObjectParameter("P_TEN", typeof(string));
    
            var p_SDTParameter = p_SDT != null ?
                new ObjectParameter("P_SDT", p_SDT) :
                new ObjectParameter("P_SDT", typeof(string));
    
            var p_DCParameter = p_DC != null ?
                new ObjectParameter("P_DC", p_DC) :
                new ObjectParameter("P_DC", typeof(string));
    
            var p_EMAILParameter = p_EMAIL != null ?
                new ObjectParameter("P_EMAIL", p_EMAIL) :
                new ObjectParameter("P_EMAIL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEM_PHIEU_XUAT", p_MANVParameter, p_TENParameter, p_SDTParameter, p_DCParameter, p_EMAILParameter);
        }
    
        public virtual int XOA_HANG_HOA(Nullable<decimal> p_MAHANGHOA)
        {
            var p_MAHANGHOAParameter = p_MAHANGHOA.HasValue ?
                new ObjectParameter("P_MAHANGHOA", p_MAHANGHOA) :
                new ObjectParameter("P_MAHANGHOA", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XOA_HANG_HOA", p_MAHANGHOAParameter);
        }
    }
}
