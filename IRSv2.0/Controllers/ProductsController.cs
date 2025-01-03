using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
