using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace IRSv2._0.Controllers
{
    public class LoginController : Controller
    {
        public string Message { get; private set; }

        public void OnPost(string submitForm)
        {
            Console.WriteLine("sdasdas");
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
