using Day2_Bui_Ngoc_Thang_KTPMK22A.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day2_Bui_Ngoc_Thang_KTPMK22A.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
