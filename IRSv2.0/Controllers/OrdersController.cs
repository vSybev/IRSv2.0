using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Orders()
        {
            return View();
        }
    }
}
