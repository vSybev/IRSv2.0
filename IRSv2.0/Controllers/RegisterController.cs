using IRSv2._0.Data;
using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRSDbContext _context;

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

            switch (model.Position.ToLower())
            {
                case "manager": 
                    Console.WriteLine("Manager");
                    RedirectToAction("Orders", "Orders");
                    break;
                case "waiter": 
                    Console.WriteLine("waiter");
                    RedirectToAction("Orders", "Orders");
                    break;
                case "host": 
                    Console.WriteLine("host");
                    RedirectToAction("Orders", "Orders");
                    break;
                case "cook": 
                    Console.WriteLine("cook");
                    RedirectToAction("Orders", "Orders");
                    break;
                case "deliverer": 
                    Console.WriteLine("deliverer");
                    RedirectToAction("Orders", "Orders");
                    break;
            } 

            // За демонстрация - съобщение за успешна регистрация
            ViewBag.Message = "User registered successfully!";
            return View();
        }
    }
}
