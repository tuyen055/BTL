// Doãn Thị Tuyền
// 2021050039
using Microsoft.AspNetCore.Mvc;
namespace WebMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fullName , string Email)
        {
            string str = fullName + " - " + Email;
            ViewBag.Export = str;
            return View();
        }
    }
}