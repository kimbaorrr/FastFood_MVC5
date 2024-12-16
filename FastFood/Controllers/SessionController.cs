using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class SessionController : Controller
    {
        protected FastFood_GioHang Cart { get; set; }
        protected FastFood_ThanhToan_TomTatThanhToan CheckoutSummary { get; set; }
        protected string CustomerId { get; set; }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["GioHang"] == null)
                Session["GioHang"] = new FastFood_GioHang();
            this.Cart = Session["GioHang"] as FastFood_GioHang;
            this.CheckoutSummary = Session["CheckoutSummary"] as FastFood_ThanhToan_TomTatThanhToan;
            this.CustomerId = Session["CustomerId"] as string;
        }

        /// <summary>
        /// Thông báo dạng JSON
        /// </summary>
        /// <param name="success">Trạng thái thực thi</param>
        /// <param name="message">Nội dung thông báo</param>
        /// <returns></returns>
        public JsonResult JsonMessage(bool success, string message)
        {
            return success
                ? Json(new { success = success, type = "var(--bs-success)", message = message }, JsonRequestBehavior.AllowGet)
                : Json(new { success = success, type = "var(--bs-danger)", message = message }, JsonRequestBehavior.AllowGet);
        }


    }
}