using System.Net;
using demoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoMvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string str = ps.PersonID + "-" + ps.Fullname;
            ViewBag.Thongbao = str ;
            return View();
        }

    }

}
