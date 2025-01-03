using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Tables()
        {
            return View();
        }
    }
}
