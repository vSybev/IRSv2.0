using IRSv2._0.Data;
using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;
using IRSv2._0.Models;
using IRSv2._0.Data.Contexts;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Net;


namespace IRSv2._0.Controllers
{
    public class TablesController : Controller
    {
        private readonly TableContext _context;

        public TablesController(TableContext context)
        {
            _context = context;
        }

        // GET: Tables
        public IActionResult Tables()
        {
            //var tables = _context.Tables.ToList();
            //return View(tables);
            return View();
        }

        // GET: Tables/Details/{id}
        public IActionResult Details(string id)
        {
            var table = _context.Tables.FirstOrDefault(t => t.ID == id);
            if (table == null)
            {
                return NotFound();
            }
            return View(table);
        }

        // POST: Tables/AddTable
        [HttpPost]
        public IActionResult AddTable(TablesModel table)
        {
            if (ModelState.IsValid)
            {
                _context.Tables.Add(table);
                _context.SaveChanges();
                return RedirectToAction("Tables");
            }
            return View(table);
        }

        // POST: Tables/EditTable
        [HttpPost]
        public IActionResult EditTable(TablesModel updatedTable)
        {
            var existingTable = _context.Tables.FirstOrDefault(t => t.ID == updatedTable.ID);
            if (existingTable == null)
            {
                return NotFound();
            }

            existingTable.Status = updatedTable.Status;
            existingTable.OrderId = updatedTable.OrderId;

            _context.SaveChanges();
            return RedirectToAction("Tables");
        }

        // POST: Tables/DeleteTable/{id}
        [HttpPost]
        public IActionResult DeleteTable(string id)
        {
            var table = _context.Tables.FirstOrDefault(t => t.ID == id);
            if (table == null)
            {
                return NotFound();
            }

            _context.Tables.Remove(table);
            _context.SaveChanges();
            return RedirectToAction("Tables");
        }
    }
}