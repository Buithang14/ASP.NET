using Microsoft.AspNetCore.Mvc;

namespace Day2_Bui_Ngoc_Thang_KTPMK22A.ViewComponents
{
    public class ServerInfoViewModel
    {
        public DateTime CurrentTime { get; set; }
        public string FrameworkVersion { get; set; } = string.Empty;
        public string OsDescription { get; set; } = string.Empty;
        public string MachineName { get; set; } = string.Empty;
    }

    public class ServerInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title = "Thông tin hệ thống Server")
        {
            ViewBag.ComponentTitle = title;

            // ViewComponent tự query logic độc lập, không phụ thuộc Controller truyền vào
            var model = new ServerInfoViewModel
            {
                CurrentTime = DateTime.Now,
                FrameworkVersion = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
                OsDescription = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                MachineName = Environment.MachineName
            };

            return View(model);
        }
    }
}
