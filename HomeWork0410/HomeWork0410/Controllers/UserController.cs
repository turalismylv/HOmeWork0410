using Microsoft.AspNetCore.Mvc;

namespace HomeWork0410.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "TURAL";
            ViewBag.Surname = "Ismayilov";
            ViewBag.Age = 21;
            ViewBag.Country = "GEDEBEY";
            ViewBag.PhoneNumber = "+994998596919";
            return View();
        }
    }
}
