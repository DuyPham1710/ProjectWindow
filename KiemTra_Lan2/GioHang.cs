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
    
    public partial class GioHang
    {
        public int IDNguoiMua { get; set; }
        public string MSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
