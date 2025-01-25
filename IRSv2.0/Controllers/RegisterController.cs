using IRSv2._0.Data;
using IRSv2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace IRSv2._0.Controllers
{
    public class RegisterController : Controller
    {
        /*private readonly IRSDbContext _context;

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                switch (model.Position.ToLower())
                {
                    case "manager":
                        CreateManager(model);
                        break;
                    case "cook":
                        CreateCook(model);
                        break;
                    case "waiter":
                        CreateWaiter(model);
                        break;
                    case "deliverer":
                        CreateDeliverer(model);
                        break;
                    case "host":
                        CreateHost(model);
                        break;
                    default:
                        ModelState.AddModelError("Role", "Invalid role selected.");
                        return View(model);
                }

                // Assuming success redirects to a dashboard or home page
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
                return View(model);
            }
        }

        private void CreateManager(RegisterModel model)
        {
            // Create a new ManagersModel instance
            ManagersModel manager = new ManagersModel
            {
                ID = model.Id, // Generate a unique ID
                Name = model.Name,
                Waiters = new List<WaitersModel>(),
                Cooks = new List<CooksModel>(),
                Hosts = new List<HostsModel>(),
                Deliverers = new List<DeliverersModel>()
            };

            // Save manager to the database (pseudo-code, replace with actual ORM logic)
            using (var context = new IRSDbContext())
            {
                context.Managers.Add(manager);
                context.SaveChanges();
            }
        }

        private void CreateCook(RegisterModel model)
        {
            // Create a new CooksModel instance
            CooksModel cook = new CooksModel
            {
                ID = model.Id, // Generate a unique ID
                Name = model.Name,
                Orders = new List<OrdersModel>(),
                ToGoOrders = new List<ToGoOrdersModel>()
            };

            // Save cook to the database (pseudo-code, replace with actual ORM logic)
            using (var context = new IRSDbContext())
            {
                context.Cooks.Add(cook);
                context.SaveChanges();
            }
        }

        private void CreateWaiter(RegisterModel model)
        {
            // Create a new WaitersModel instance
            WaitersModel waiter = new WaitersModel
            {
                ID = model.Id, // Generate a unique ID
                Name = model.Name,
                OnWork = false, // Default to false when created
                Sector = new List<TablesModel>(),
                Orders = new List<OrdersModel>()
            };

            // Save waiter to the database (pseudo-code, replace with actual ORM logic)
            using (var context = new IRSDbContext())
            {
                context.Waiters.Add(waiter);
                context.SaveChanges();
            }
        }

        private void CreateDeliverer(RegisterModel model)
        {
            // Create a new DeliverersModel instance
            DeliverersModel deliverer = new DeliverersModel
            {
                ID = model.Id, // Generate a unique ID
                Name = model.Name,
                ToGoOrders = new List<ToGoOrdersModel>()
            };

            // Save deliverer to the database (pseudo-code, replace with actual ORM logic)
            using (var context = new IRSDbContext())
            {
                context.Deliverers.Add(deliverer);
                context.SaveChanges();
            }
        }

        private void CreateHost(RegisterModel model)
        {
            // Create a new HostsModel instance
            HostsModel host = new HostsModel
            {
                ID = model.Id, // Generate a unique ID
                Name = model.Name,
                Sector = new List<TablesModel>(),
                ToGoOrders = new List<ToGoOrdersModel>()
            };

            // Save host to the database (pseudo-code, replace with actual ORM logic)
            using (var context = new IRSDbContext())
            {
                context.Hosts.Add(host);
                context.SaveChanges();
            }
        }*/
            private readonly IRSDbContext _context;

            public RegisterController()
            {
                _context = new IRSDbContext();
            }

            public ActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Register(RegisterModel model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                try
                {
                    switch (model.Position.ToLower())
                    {
                        case "manager":
                            CreateManager(model);
                        Console.WriteLine("manager registered successfully");
                            break;
                        case "cook":
                            CreateCook(model);
                        Console.WriteLine("cook registered successfully");
                        break;
                        case "waiter":
                            CreateWaiter(model);
                        Console.WriteLine("waiter registered successfully");
                        break;
                        case "deliverer":
                            CreateDeliverer(model);
                        Console.WriteLine("deliverer registered successfully");
                        break;
                        case "host":
                            CreateHost(model);
                        Console.WriteLine("host registered successfully");
                        break;
                        default:
                            ModelState.AddModelError("Position", "Invalid position selected.");
                            return View(model);
                    }

                    // Assuming success redirects to a dashboard or home page
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"An error occurred: {ex.Message}");
                    return View(model);
                }
            }

            private void CreateManager(RegisterModel model)
            {
                // Create a new ManagersModel instance
                ManagersModel manager = new ManagersModel
                {
                    ID = model.Id, // Use the provided ID
                    Name = model.Name,
                    Waiters = new List<WaitersModel>(),
                    Cooks = new List<CooksModel>(),
                    Hosts = new List<HostsModel>(),
                    Deliverers = new List<DeliverersModel>()
                };

                // Save manager to the database
                _context.Managers.Add(manager);
                _context.SaveChanges();
            }

            private void CreateCook(RegisterModel model)
            {
                // Create a new CooksModel instance
                CooksModel cook = new CooksModel
                {
                    ID = model.Id, // Use the provided ID
                    Name = model.Name,
                    Orders = new List<OrdersModel>(),
                    ToGoOrders = new List<ToGoOrdersModel>()
                };

                // Save cook to the database
                _context.Cooks.Add(cook);
                _context.SaveChanges();
            }

            private void CreateWaiter(RegisterModel model)
            {
                // Create a new WaitersModel instance
                WaitersModel waiter = new WaitersModel
                {
                    ID = model.Id, // Use the provided ID
                    Name = model.Name,
                    OnWork = true, // Default to true when created
                    Sector = new List<TablesModel>(),
                    Orders = new List<OrdersModel>()
                };

                // Save waiter to the database
                _context.Waiters.Add(waiter);
                _context.SaveChanges();
            }

            private void CreateDeliverer(RegisterModel model)
            {
                // Create a new DeliverersModel instance
                DeliverersModel deliverer = new DeliverersModel
                {
                    ID = model.Id, // Use the provided ID
                    Name = model.Name,
                    ToGoOrders = new List<ToGoOrdersModel>()
                };

                // Save deliverer to the database
                _context.Deliverers.Add(deliverer);
                _context.SaveChanges();
            }

            private void CreateHost(RegisterModel model)
            {
                // Create a new HostsModel instance
                HostsModel host = new HostsModel
                {
                    ID = model.Id, // Use the provided ID
                    Name = model.Name,
                    Sector = new List<TablesModel>(),
                    ToGoOrders = new List<ToGoOrdersModel>()
                };

                // Save host to the database
                _context.Hosts.Add(host);
                _context.SaveChanges();
            }
        }
}
