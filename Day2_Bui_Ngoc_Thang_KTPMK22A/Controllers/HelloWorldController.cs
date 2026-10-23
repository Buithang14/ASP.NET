using Microsoft.AspNetCore.Mvc;

namespace Day2_Bui_Ngoc_Thang_KTPMK22A.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "Xin chao! Day la Controller dau tien.";
        //}

        public IActionResult Index()
        {
            return View();
        }

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return $"Hello {name}, NumTimes is: {numTimes}";
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }


    }
}
