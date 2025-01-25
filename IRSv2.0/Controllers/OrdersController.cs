using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;
using IRSv2._0.Data.Contexts;
using System.Linq;
using System.Collections.Generic;

namespace IRSv2._0.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrderContext _context;

        public OrdersController(OrderContext context)
        {
            _context = context;
        }

        // GET: Orders
        public IActionResult Orders()
        {
            //var orders = _context.Orders.ToList();
            //return View(orders);
            return View();
        }

        // GET: Orders/Details/{id}
        public IActionResult Details(string id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.ID == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/AddOrder
        [HttpPost]
        public IActionResult AddOrder(OrdersModel order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction("Orders");
            }
            return View(order);
        }

        // POST: Orders/EditOrder
        [HttpPost]
        public IActionResult EditOrder(OrdersModel updatedOrder)
        {
            var existingOrder = _context.Orders.FirstOrDefault(o => o.ID == updatedOrder.ID);
            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.Price = updatedOrder.Price;
            existingOrder.WaiterID = updatedOrder.WaiterID;
            existingOrder.TableID = updatedOrder.TableID;
            existingOrder.Products = updatedOrder.Products;
            existingOrder.Cooks = updatedOrder.Cooks;

            _context.SaveChanges();
            return RedirectToAction("Orders");
        }

        // POST: Orders/DeleteOrder/{id}
        [HttpPost]
        public IActionResult DeleteOrder(string id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();
            return RedirectToAction("Orders");
        }
    }
}
