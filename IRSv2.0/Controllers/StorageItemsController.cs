using Microsoft.AspNetCore.Mvc;
using IRSv2._0.Models;
using IRSv2._0.Data.Contexts;
using System.Linq;
using System.Collections.Generic;

namespace IRSv2._0.Controllers
{
    public class StorageItemsController : Controller
    {
        private readonly StorageItemContext _context;

        public StorageItemsController(StorageItemContext context)
        {
            _context = context;
        }

        // GET: StorageItems
        public IActionResult StorageItems()
        {
            var items = _context.StorageItems.ToList();
            return View(items);
        }

        // GET: StorageItems/Details/{id}
        public IActionResult Details(string id)
        {
            var item = _context.StorageItems.FirstOrDefault(i => i.ID == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: StorageItems/AddItem
        [HttpPost]
        public IActionResult AddItem(StorageItemsModel item)
        {
            StorageItemsModel storageItem = new StorageItemsModel(item.ID, item.Name, item.Count);

            _context.StorageItems.Add(storageItem);
            _context.SaveChanges();

            StorageItems();

            return RedirectToAction("StorageItems");
        }

        // POST: StorageItems/EditItem
        [HttpPost]
        public IActionResult EditItem(StorageItemsModel updatedItem)
        {
            var existingItem = _context.StorageItems.FirstOrDefault(i => i.ID == updatedItem.ID);
            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.Name = updatedItem.Name;
            existingItem.Count = updatedItem.Count;

            _context.SaveChanges();

            StorageItems();

            return RedirectToAction("StorageItems");
        }

        // POST: StorageItems/DeleteItem/{id}
        [HttpPost]
        public IActionResult DeleteItem(string id)
        {
            var item = _context.StorageItems.FirstOrDefault(i => i.ID == id);
            if (item == null)
            {
                return NotFound();
            }

            _context.StorageItems.Remove(item);
            _context.SaveChanges();

            StorageItems();

            return RedirectToAction("StorageItems");
        }
    }
}
