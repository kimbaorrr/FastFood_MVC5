//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFood.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrangThaiDonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrangThaiDonHang()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public int MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
        public string MoTa { get; set; }
        public string MauSac { get; set; }
        public Nullable<int> Progress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
