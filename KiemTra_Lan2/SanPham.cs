//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiemTra_Lan2
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.DaMuas = new HashSet<DaMua>();
            this.DanhGias = new HashSet<DanhGia>();
            this.GioHangs = new HashSet<GioHang>();
            this.SanPhamHuys = new HashSet<SanPhamHuy>();
            this.YeuThiches = new HashSet<YeuThich>();
        }
    
        public string MSP { get; set; }
        public Nullable<int> IDChuSP { get; set; }
        public string TenSP { get; set; }
        public string DanhMuc { get; set; }
        public string GiaTienLucMoiMua { get; set; }
        public string GiaTienBayGio { get; set; }
        public Nullable<System.DateTime> NgayMuaSP { get; set; }
        public string SoLuong { get; set; }
        public string XuatXu { get; set; }
        public string BaoHanh { get; set; }
        public string TinhTrang { get; set; }
        public string MotaTinhTrang { get; set; }
        public string MotaSP { get; set; }
        public string AnhLucMoiMua { get; set; }
        public string AnhBayGio { get; set; }
        public Nullable<int> BanDuoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaMua> DaMuas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGia> DanhGias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamHuy> SanPhamHuys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YeuThich> YeuThiches { get; set; }
    }
}