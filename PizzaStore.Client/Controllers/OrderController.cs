using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  public class OrderController : Controller
  {
    private readonly PizzaStoreDbContext _db;

    public OrderController(PizzaStoreDbContext dbContext)
    {
      _db = dbContext;
    }

    public IActionResult Home()
    {
      return View("Order", new PizzaViewModel());
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) // model binding
    {
      if(ModelState.IsValid)
      {
        // repository here, pass pizzamodelview
        // var p = new PizzaFactory();
        // p.Create(pizzaViewModel);
        // return View("Index"); // or whatever user you want
        // try
        // {
        //   _db.Update(pizzaViewModel);
        //   await _db.SaveChangesAsync();
        // }
        // catch(DbUpdateConcurrencyException)
        // {
        //   return NotFound();
        // }
        return RedirectToAction("Index");
      }
      return View("Order", pizzaViewModel);
    }
    [HttpGet]        
    public IEnumerable<OrderModel> Get()
    {
      return _db.Orders.ToList();
    }
    public string Index()
    {
      return "This is the Index page inside Order";
    }
  }
}