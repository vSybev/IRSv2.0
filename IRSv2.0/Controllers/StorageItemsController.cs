using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class StorageItemsController : Controller
    {
        public IActionResult StorageItems()
        {
            return View();
        }
    }
}
