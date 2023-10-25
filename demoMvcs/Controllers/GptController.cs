using Microsoft.AspNetCore.Mvc;

namespace demoMvc.Controllers;
using demoMvc.Models;
public class GptController : Controller

{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult  Solve(Abc tuyen)
    {
        if (tuyen.A == 0)
        {
            ViewBag.D = "A phai khac 0. ";
            return View("Index", tuyen);
        }

        tuyen.Delta = tuyen.B * tuyen.B - 4 * tuyen.A * tuyen.C;
        ViewBag.A= "delta= " +tuyen.Delta;
        if (tuyen.Delta < 0)
        {
            ViewBag.B= "Phuong trinh khong vo nghiem.";
        }
        else if (tuyen.Delta == 0)
        {
            tuyen.X1 = -tuyen.B / (2 * tuyen.A);
            ViewBag.C = "Phuong trinh co nghiem kep: X1=X2=" + tuyen.X1;
        }
        else
        {
            tuyen.X1 = (-tuyen.B + Math.Sqrt(tuyen.Delta)) / (2 * tuyen.A);
            tuyen.X2 = (-tuyen.B - Math.Sqrt(tuyen.Delta)) / (2 * tuyen.A);
            ViewBag.D ="Phuong trinh co 2 nghiem: " + " X1= " + tuyen.X1 + " ; "+ "X2 = " + tuyen.X2;
        }


        return View("Index", tuyen);
    }
}