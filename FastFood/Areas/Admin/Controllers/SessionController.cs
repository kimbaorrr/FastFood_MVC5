using System.Web;
using System.Web.Mvc;

namespace FastFood.Areas.Admin.Controllers
{

    public class SessionController : Controller
    {
        protected string EmployeeId { get; set; }
        protected string EmployeeImg { get; set; }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.EmployeeId = Session["EmployeeId"] as string ?? string.Empty;
            this.EmployeeImg = Session["EmployeeImg"] as string ?? string.Empty;
            if (string.IsNullOrEmpty(this.EmployeeId) || string.IsNullOrEmpty(this.EmployeeImg))
            {
                HttpCookie loginCookie = Request.Cookies["LoginCookie"];

                if (loginCookie != null)
                {
                    this.EmployeeId = loginCookie.Values["MaNhanVien"];
                    this.EmployeeImg = loginCookie.Values["AnhDD"];

                    if (!string.IsNullOrEmpty(this.EmployeeId) && !string.IsNullOrEmpty(this.EmployeeImg))
                    {
                        Session["EmployeeId"] = this.EmployeeId;
                        Session["EmployeeImg"] = this.EmployeeImg;
                    }
                }
                filterContext.Result = RedirectToAction("Login", "Account", new { area = "Admin" });
            }
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