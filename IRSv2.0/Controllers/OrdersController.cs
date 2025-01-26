using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;
using IRSv2._0.Data.Contexts;
using System.Linq;
using System.Collections.Generic;
using IRSv2._0.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IRSv2._0.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IRSDbContext _context;
        OrdersModel order1 = new OrdersModel
        {
            ID = "Order1",
            TableID = "1",
            WaiterID = "1",
            Cooks = new List<CooksModel>
    {
        new CooksModel { ID = "C1", Name = "Cook1" },

    },
            Price = 10,
            Products = new List<ProductsModel>
    {
        new ProductsModel { ID = "P1", Name = "Product1" },
        new ProductsModel { ID = "P2", Name = "Product2" }
    }
        };
        /*public OrdersController()
        {
            _context = new IRSDbContext();
        }*/

        // GET: Orders
        public IActionResult Orders()
        {
            //var orders = _context.Orders.ToList();
            _context.Orders.Add(order1);
            ////test za izpiswane na poruchki w kozolata
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order.ID);
            //}
            return View();
            //return View();
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
                OrdersModel orderToAdd = new OrdersModel
                {
                    ID = order.ID,            
                    Price = order.Price,
                    WaiterID = order.WaiterID,
                    TableID = order.TableID,
                    Products = order.Products,
                    Cooks = order.Cooks
                };

                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction("Orders");
            }

            Orders();
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

            Orders();

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

            Orders();

            return RedirectToAction("Orders");
        }
    }
}
