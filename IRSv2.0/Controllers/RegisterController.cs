using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

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
        public IActionResult Register(RegisterModel model) {
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
