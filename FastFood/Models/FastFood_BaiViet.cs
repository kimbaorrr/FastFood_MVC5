﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FastFood.DB;

namespace FastFood.Models
{
    /// <summary>
    /// Lớp FastFood_BaiViet quản lý các bài viết trong hệ thống cửa hàng thức ăn nhanh.
    /// </summary>
    public static class FastFood_BaiViet
    {
        /// <summary>
        /// Khởi tạo một đối tượng mới của FastFoodEntities để truy xuất dữ liệu.
        /// </summary>
        private static FastFoodEntities context => new FastFoodEntities();

        /// <summary>
        /// Tập hợp các bài viết trong cơ sở dữ liệu.
        /// </summary>
        private static IQueryable<BaiViet> baiViets => context.BaiViets;

        /// <summary>
        /// Lấy tất cả các bài viết trong cơ sở dữ liệu.
        /// </summary>
        /// <returns>Một tập hợp các bài viết.</returns>
        public static IQueryable<BaiViet> GetBaiViet()
        {
            return baiViets;
        }

        /// <summary>
        /// Lấy các bài viết đã được duyệt.
        /// </summary>
        /// <returns>Một tập hợp các bài viết đã duyệt.</returns>
        public static IEnumerable<BaiViet> GetBaiVietDaDuyet()
        {
            return GetBaiViet().Where(x => x.DaDuyet);
        }

        /// <summary>
        /// Lấy các bài viết chưa được duyệt.
        /// </summary>
        /// <returns>Một tập hợp các bài viết chưa duyệt.</returns>
        public static IEnumerable<BaiViet> GetBaiVietChuaDuyet()
        {
            return GetBaiViet().Where(x => !x.DaDuyet);
        }
    }

    public class FastFood_BaiViet_ThemBaiViet
    {
        [Display(Name = "Tiêu đề")]
        [DataType(DataType.Text)]
        public string TieuDe { get; set; } = string.Empty;
        [Display(Name = "Mô tả ngắn")]
        [DataType(DataType.Text)]
        public string MoTaNgan { get; set; } = string.Empty;
        [Display(Name = "Nội dung")]
        [DataType(DataType.MultilineText)]
        public string NoiDung { get; set; } = string.Empty;
        [Display(Name = "Ảnh đại diện")]
        [DataType(DataType.Text)]
        public HttpPostedFileBase HinhAnh { get; set; } = null;
        public FastFood_BaiViet_ThemBaiViet() { }
        public FastFood_BaiViet_ThemBaiViet(FastFood_BaiViet_ThemBaiViet a)
        {
            TieuDe = a.TieuDe;
            NoiDung = a.NoiDung;
            MoTaNgan = a.MoTaNgan;
            HinhAnh = a.HinhAnh;
        }
    }
}