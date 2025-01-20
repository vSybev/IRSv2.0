using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                // Ако моделът не е валиден, върни същото View с грешки
                return View(model);
            }

            // Логика за обработка на регистрацията
            if (model.Id == "aa")
            {
                return RedirectToAction("Orders", "Orders");
            }
            else if (model.Id == "bb")
            {
                return RedirectToAction("ToGoOrders", "ToGoOrders");
            }

            // За демонстрация - съобщение за успешна регистрация
            ViewBag.Message = "User registered successfully!";
            return View();
        }
    }
}
