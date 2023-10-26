using demoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoMvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee el)
        {
            string strel = "Hello" + "-" + el.PersonID + "-" + el.Fullname + "-" + el.Salary;
            ViewBag.Thongbao = strel ;
            return View();
        }

    }

}
