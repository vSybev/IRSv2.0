using Microsoft.AspNetCore.Mvc;
using IRSv2._0.Models;
using IRSv2._0.Data.Contexts;
using System.Linq;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using IRSv2._0.Models.Enums;

namespace IRSv2._0.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Products()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // GET: Products/Details/{id}
        public IActionResult Details(string id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/AddProduct
        [HttpPost]
        public IActionResult AddProduct(ProductsModel product)
        {
            // Create a new Product instance
            ProductsModel productItem = new ProductsModel
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Description,
                Type = product.Type,
                Price = product.Price,
                Availability = product.Availability,
                Items = product.Items
            };

            _context.Products.Add(productItem);
            _context.SaveChanges();

            Products();

            return RedirectToAction("Products");
        }

        // POST: Products/EditProduct
        [HttpPost]
        public IActionResult EditProduct(ProductsModel updatedProduct)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.ID == updatedProduct.ID);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.Type = updatedProduct.Type;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Availability = updatedProduct.Availability;
            existingProduct.Items = updatedProduct.Items;

            _context.SaveChanges();

            Products();

            return RedirectToAction("Products");
        }

        // POST: Products/DeleteProduct/{id}
        [HttpPost]
        public IActionResult DeleteProduct(string id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            Products();

            return RedirectToAction("Products");
        }
    }
}