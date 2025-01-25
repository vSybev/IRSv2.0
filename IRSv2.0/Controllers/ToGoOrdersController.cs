using Microsoft.AspNetCore.Mvc;
using IRSv2._0.Models;
using IRSv2._0.Data.Contexts;
using System.Linq;
using System.Collections.Generic;

namespace IRSv2._0.Controllers
{
    public class ToGoOrdersController : Controller
    {
        private readonly ToGoOrderContext _context;

        public ToGoOrdersController(ToGoOrderContext context)
        {
            _context = context;
        }

        // GET: ToGoOrders
        public IActionResult ToGoOrders()
        {
            //var orders = _context.ToGoOrders.ToList();
            //return View(orders);
            return View();
        }

        // GET: ToGoOrders/Details/{id}
        public IActionResult Details(string id)
        {
            var order = _context.ToGoOrders.FirstOrDefault(o => o.ID == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: ToGoOrders/AddToGoOrder
        [HttpPost]
        public IActionResult AddToGoOrder(ToGoOrdersModel order)
        {
            if (ModelState.IsValid)
            {
                _context.ToGoOrders.Add(order);
                _context.SaveChanges();
                return RedirectToAction("ToGoOrders");
            }

            ToGoOrders();

            return View(order);
        }

        // POST: ToGoOrders/EditToGoOrder
        [HttpPost]
        public IActionResult EditToGoOrder(ToGoOrdersModel updatedOrder)
        {
            var existingOrder = _context.ToGoOrders.FirstOrDefault(o => o.ID == updatedOrder.ID);
            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.Price = updatedOrder.Price;
            existingOrder.ReceiverName = updatedOrder.ReceiverName;
            existingOrder.ReceiverAddress = updatedOrder.ReceiverAddress;
            existingOrder.ReceiverPhoneNumber = updatedOrder.ReceiverPhoneNumber;
            existingOrder.Cooks = updatedOrder.Cooks;
            existingOrder.Products = updatedOrder.Products;

            _context.SaveChanges();

            ToGoOrders();
            return RedirectToAction("ToGoOrders");
        }

        // POST: ToGoOrders/DeleteToGoOrder/{id}
        [HttpPost]
        public IActionResult DeleteToGoOrder(string id)
        {
            var order = _context.ToGoOrders.FirstOrDefault(o => o.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            _context.ToGoOrders.Remove(order);
            _context.SaveChanges();

            ToGoOrders();

            return RedirectToAction("ToGoOrders");
        }
    }
}
