﻿using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.DB;
using FastFood.Models;

namespace FastFood.Controllers
{
    [RoutePrefix("khach-hang")]
    public class AccountController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("dang-nhap")]
        public ActionResult Login(FastFood_NhanVienDangNhap a)
        {
            if (!ModelState.IsValid)
                return JsonMessage(false, "Thông tin không hợp lệ!");

            KhachHangDangNhap queryData = FastFood_KhachHang.getKhachHangDangNhap().FirstOrDefault(x => x.TenDangNhap.Equals(a.TenDangNhap));

            if (queryData == null || !FastFood_Tools.CheckPassword(a.MatKhau, queryData.MatKhau))
                return JsonMessage(false, "Tên đăng nhập hoặc mật khẩu không đúng !");

            FastFood_KhachHang khachHang = new FastFood_KhachHang
            {
                MaKhachHang = queryData.MaKhachHang,
                AnhDD = queryData.KhachHang.AnhDD ?? string.Empty
            };

            Session["CustomerId"] = khachHang.MaKhachHang.ToString();
            Session["CustomerImg"] = khachHang.AnhDD.ToString();

            if (a.GhiNhoDangNhap)
            {
                HttpCookie cookie = new HttpCookie("KhachHangLoginCookie")
                {
                    Values = { ["CustomerId"] = queryData.MaKhachHang.ToString(), ["CustomerImg"] = khachHang.AnhDD.ToString() },
                    Expires = DateTime.Now.AddDays(14),
                    Secure = true
                };
                Response.Cookies.Add(cookie);
            }

            FastFood_NhanVien.lichSuTruyCap(khachHang.MaKhachHang.ToString(), queryData.TenDangNhap, "Đăng nhập");

            return JsonMessage(true, "Đăng nhập thành công!");
        }

        [HttpGet]
        [Route("dang-xuat")]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("dang-ki")]
        public ActionResult Register(FastFood_KhachHangDangNhap_DangKiMoi a)
        {
            if (!ModelState.IsValid)
                return JsonMessage(false, "Thông tin không hợp lệ!");

            using (FastFoodEntities e = new FastFoodEntities())
            {
                KhachHangDangNhap existingUser = e.KhachHangDangNhaps.FirstOrDefault(x => x.TenDangNhap.Equals(a.TenDangNhap));
                if (existingUser != null)
                    return JsonMessage(false, "Tên đăng nhập đã tồn tại!");

                KhachHang khachHang = new KhachHang
                {
                    HoDem = a.HoDem,
                    TenKhachHang = a.TenKhachHang,
                    SoDienThoai = a.SoDienThoai,
                    Email = a.Email,
                    NgayTao = DateTime.Now
                };
                e.KhachHangs.Add(khachHang);

                KhachHangDangNhap khachHangDangNhap = new KhachHangDangNhap
                {
                    MaKhachHang = khachHang.MaKhachHang,
                    TenDangNhap = a.TenDangNhap,
                    MatKhau = FastFood_Tools.HashPassword(a.MatKhau),
                    NgayTao = DateTime.Now
                };
                e.KhachHangDangNhaps.Add(khachHangDangNhap);
                e.SaveChanges();

                return JsonMessage(true, "Đăng ký thành công!");
            }
        }
        /// <summary>
        /// Thông báo dạng JSON
        /// </summary>
        /// <param name="success">Trạng thái thực thi</param>
        /// <param name="message">Nội dung thông báo</param>
        /// <returns></returns>
        private JsonResult JsonMessage(bool success, string message)
        {
            return success
                ? Json(new { success = success, type = "var(--bs-success)", message = message }, JsonRequestBehavior.AllowGet)
                : Json(new { success = success, type = "var(--bs-danger)", message = message }, JsonRequestBehavior.AllowGet);
        }

    }
}