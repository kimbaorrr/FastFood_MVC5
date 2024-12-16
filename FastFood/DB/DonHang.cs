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
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.ThanhToans = new HashSet<ThanhToan>();
        }
    
        public int MaDonHang { get; set; }
        public int NguoiMua { get; set; }
        public Nullable<int> NguoiBan { get; set; }
        public System.DateTime NgayDat { get; set; }
        public string GhiChu { get; set; }
        public int TrangThaiDon { get; set; }
        public Nullable<int> NguoiGiao { get; set; }
        public Nullable<System.DateTime> ThoiGianGiaoHangDuKien { get; set; }
        public string PhuongThucVanChuyen { get; set; }
        public int PhiVanChuyen { get; set; }
        public int TongTienSanPham { get; set; }
        public string DonViVanChuyen { get; set; }
        public string MaVanDon { get; set; }
        public Nullable<System.DateTime> ThoiGianGiaoHangThucTe { get; set; }
        public Nullable<int> MaKhuyenMai { get; set; }
        public Nullable<int> TongThanhToan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual TrangThaiDonHang TrangThaiDonHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
        public virtual MaKhuyenMai MaKhuyenMai1 { get; set; }
    }
}
