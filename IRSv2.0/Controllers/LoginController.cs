using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

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
        public IActionResult Login(LoginModel model) {
            if(model.Id == "aa")
            {
            return RedirectToAction("Orders", "Orders");

            }
            else if(model.Id == "bb")
            {
                return RedirectToAction("ToGoOrders", "ToGoOrders");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
