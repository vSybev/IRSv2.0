/*using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            RedirectToAction("Orders", "Orders");
            char positionLetter = char.ToUpper(model.Id.ToString()[0]);
            int idNumber = int.Parse(model.Id.Substring(1));

             if (!ModelState.IsValid)
             {
                 // Ако моделът не е валиден, върни същото View с грешки
                 return View(model);
             }

             switch (positionLetter)
             {
                 case 'M':
                     RedirectToAction("Orders", "Orders");
                     break;
                 case 'S':
                     RedirectToAction("Orders", "Orders");
                     break;
                 case 'C':
                     RedirectToAction("Orders", "Orders");
                     break;
                 case 'H':
                     RedirectToAction("Orders", "Orders");
                     break;
                 case 'D':
                     RedirectToAction("Orders", "Orders");
                     break;
             }
            
             // За демонстрация - съобщение за успешна регистрация
             Console.WriteLine( "User {0} logged successfully!", model.Id);

            return View();
        }
    }
}
*/
using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            char positionLetter = char.ToUpper(model.Id.ToString()[0]);
            int idNumber = int.Parse(model.Id.Substring(1));

            if (!ModelState.IsValid)
            {
                // Ако моделът не е валиден, върни същото View с грешки
                return View(model);
            }

            switch (positionLetter)
            {
                case 'M':
                    RedirectToAction("Orders", "Orders");
                    break;
                case 'S':
                    RedirectToAction("Orders", "Orders");
                    break;
                case 'C':
                    RedirectToAction("Orders", "Orders");
                    break;
                case 'H':
                    RedirectToAction("Orders", "Orders");
                    break;
                case 'D':
                    RedirectToAction("Orders", "Orders");
                    break;
            }

            // За демонстрация - съобщение за успешна регистрация
            ViewBag.Message = "User registered successfully!";
            return View();
        }
    }
}