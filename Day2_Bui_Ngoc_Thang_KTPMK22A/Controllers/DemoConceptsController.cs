using Microsoft.AspNetCore.Mvc;
using Day2_Bui_Ngoc_Thang_KTPMK22A.Models;

namespace Day2_Bui_Ngoc_Thang_KTPMK22A.Controllers
{
    public class DemoConceptsController : Controller
    {
        // 1. Trang Tổng quan so sánh & hướng dẫn 4 khái niệm
        public IActionResult Index()
        {
            return View();
        }

        // 2. Demo Partial View (truyền danh sách Sinh viên vào để View render lặp)
        public IActionResult PartialViewDemo()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, FullName = "Bùi Ngọc Thắng", StudentCode = "KTPMK22A01", ClassName = "KTPMK22A", Gpa = 3.85, Major = "Kỹ thuật phần mềm" },
                new Student { Id = 2, FullName = "Trần Thị Thu Hà", StudentCode = "KTPMK22A02", ClassName = "KTPMK22A", Gpa = 3.65, Major = "Kỹ thuật phần mềm" },
                new Student { Id = 3, FullName = "Nguyễn Hoàng Nam", StudentCode = "KTPMK22A03", ClassName = "KTPMK22A", Gpa = 3.40, Major = "Hệ thống thông tin" }
            };

            return View(students);
        }

        // 3. Demo View Component (Controller này không cần chuẩn bị dữ liệu cho ViewComponent)
        public IActionResult ViewComponentDemo()
        {
            return View();
        }

        // 4. Demo Conventional Routing (Được gọi qua cấu hình MapControllerRoute)
        public IActionResult ConventionalExample(int? id)
        {
            ViewBag.RoutePattern = "{controller=Home}/{action=Index}/{id?} và custom: demo-quy-uoc/{action=Index}/{id?}";
            ViewBag.Id = id ?? 100;
            return View();
        }
    }
}
