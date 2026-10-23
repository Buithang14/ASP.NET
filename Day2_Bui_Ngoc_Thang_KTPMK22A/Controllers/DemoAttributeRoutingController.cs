using Microsoft.AspNetCore.Mvc;

namespace Day2_Bui_Ngoc_Thang_KTPMK22A.Controllers
{
    // [Route] trên cấp Class: Tiền tố URL cho mọi action bên trong
    [Route("hoc-attribute-routing")]
    public class DemoAttributeRoutingController : Controller
    {
        // GET: /hoc-attribute-routing hoặc /hoc-attribute-routing/trang-chu
        [HttpGet("")]
        [HttpGet("trang-chu")]
        public IActionResult Index()
        {
            ViewBag.CurrentUrl = "/hoc-attribute-routing/trang-chu";
            ViewBag.Explanation = "Action này được truy cập bằng Attribute [Route(\"hoc-attribute-routing\")] kết hợp [HttpGet(\"trang-chu\")]. URL không cần tên Controller hay Action!";
            return View();
        }

        // GET: /hoc-attribute-routing/chi-tiet-mon-hoc/{id}
        // Có ràng buộc tham số id phải là kiểu int (:int)
        [HttpGet("chi-tiet-mon-hoc/{id:int}")]
        public IActionResult Detail(int id, string? name)
        {
            ViewBag.Id = id;
            ViewBag.SubjectName = name ?? "Lập trình Web nâng cao ASP.NET Core MVC";
            ViewBag.CurrentUrl = $"/hoc-attribute-routing/chi-tiet-mon-hoc/{id}?name={ViewBag.SubjectName}";
            return View();
        }
    }
}
