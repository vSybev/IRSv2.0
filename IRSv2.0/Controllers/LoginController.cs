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
            if (!ModelState.IsValid)
            {
                // Връща изгледа със съобщения за грешки, ако моделът не е валиден
                return View(model);
            }

            // Логика за проверка на потребителя
            if (model.Id == "aa")
            {
                return RedirectToAction("Orders", "Orders");
            }
            else if (model.Id == "bb")
            {
                return RedirectToAction("ToGoOrders", "ToGoOrders");
            }

            // Ако ID-то е грешно, върнете съобщение за грешка
            ViewBag.ErrorMessage = "Invalid ID. Please try again.";
            return View();
        }
    }
}
