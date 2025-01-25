using IRSv2._0.Data;
using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace IRSv2._0.Controllers
{
    public class LoginController : Controller
    {
        private readonly IRSDbContext _context;

        public LoginController()
        {
            _context = new IRSDbContext();
        }

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
            var isValidUser = false;
            switch (positionLetter)
            {
                case 'M':
                    return doesManagerExists();                   
                case 'C':
                    return doesCookExists();
                case 'H':
                    return doesHostExists();
                case 'D':
                    return doesDelivererExists();
                case 'W':
                    return doesWaiterExists();
                default:
                    ModelState.AddModelError("Id", "Invalid ID. The first letter must be W, M, C, H, or D.");
                    return View(model);
            }

            IActionResult doesManagerExists()
             {
                isValidUser = _context.Managers.Any(m => m.ID == model.Id);
                if (isValidUser)
                {
                    return RedirectToAction("Orders", "Orders");
                }
                ModelState.AddModelError("Id", "This user does not exists");
                return View();
             }

            IActionResult doesCookExists()
             {
                isValidUser = _context.Cooks.Any(c => c.ID == model.Id);
                if (isValidUser)
                {
                    return RedirectToAction("Orders", "Orders");
                }
                ModelState.AddModelError("Id", "This user does not exists");
                return View();
             }

            IActionResult doesHostExists()
            {
                isValidUser = _context.Hosts.Any(h => h.ID == model.Id);
                if (isValidUser)
                {
                    return RedirectToAction("Orders", "Orders");
                }
                ModelState.AddModelError("Id", "This user does not exists");
                return View();
            }

            IActionResult doesDelivererExists()
            {
                isValidUser = _context.Deliverers.Any(d => d.ID == model.Id);
                if (isValidUser)
                {
                    return RedirectToAction("Orders", "Orders");
                }
                ModelState.AddModelError("Id", "This user does not exists");
                return View();
            }

            IActionResult doesWaiterExists()
            {
                isValidUser = _context.Waiters.Any(w => w.ID == model.Id);
                if (isValidUser)
                {
                    return RedirectToAction("Orders", "Orders");
                }
                ModelState.AddModelError("Id", "This user does not exists");
                return View();
            }
        }
    }
}