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
            // Проверка дали Id е празно или null
            if (string.IsNullOrWhiteSpace(model.Id))
            {
                ModelState.AddModelError("Id", "ID cannot be empty.");
                return View(model);
            }

            // Проверка дали дължината на Id е поне 2 символа
            if (model.Id.Length < 2)
            {
                ModelState.AddModelError("Id", "ID must be at least 2 characters long.");
                return View(model);
            }

            // Проверка дали първият символ е буква
            if (!char.IsLetter(model.Id[0]))
            {
                ModelState.AddModelError("Id", "The first character of the ID must be a letter.");
                return View(model);
            }

            // Опит за извличане на числото след първия символ
            if (!int.TryParse(model.Id.Substring(1), out int idNumber))
            {
                ModelState.AddModelError("Id", "The part of the ID after the first letter must be a number.");
                return View(model);
            }

            // Преобразуване на първата буква до главна
            char positionLetter = char.ToUpper(model.Id[0]);

            // Проверка дали ModelState е валиден (допълнителна валидация)
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Обработка на валиден вход според буквата
            switch (positionLetter)
            {
                case 'M':
                case 'S':
                case 'C':
                case 'H':
                case 'D':
                case 'W':
                    return RedirectToAction("Orders", "Orders");
                default:
                    ModelState.AddModelError("Id", "Invalid ID. The first letter must be W, M, S, C, H, or D.");
                    return View(model);
            }

            // Демонстрационно съобщение за успешно логване
            ViewBag.Message = "User loged successfully!";
            return View();
        }
    }
}