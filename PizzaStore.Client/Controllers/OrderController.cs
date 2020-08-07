using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;
using PizzaStore.Storing.Repositories;

namespace PizzaStore.Client.Controllers
{
  // [Route("/[Controller]/[action]")]
  // [EnableCors("private")]
  public class OrderController : Controller
  {
    private readonly PizzaStoreDbContext _db;

    public OrderController(PizzaStoreDbContext dbContext)
    {
      _db = dbContext;
    }

    public IActionResult Home()
    {
      var pizzaviewmodel = new PizzaViewModel();
      pizzaviewmodel.Initialize();
      return View("Order", pizzaviewmodel);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) // model binding
    {
      if (ModelState.IsValid)
      {
        var repo = new PizzaRepository(_db);
        try
        {
          repo.Create(pizzaViewModel.Convert(pizzaViewModel));
        }
        catch(DbUpdateException)
        {
          System.Console.WriteLine("Exception catched in controller");
        }
        // return Redirect("/user/index"); // <-- 300-series status
        return RedirectToAction("Index");
      }
      return View("Order", pizzaViewModel);
    }
    // [HttpGet]
    // public IActionResult Get()
    // {
    //   return View("/User/ViewOrders", _db.Orders.ToList());
    // }
    public string Index()
    {
      return "This is the Index page inside Order";
    }
  }
}