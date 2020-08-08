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
    Singleton instance = Singleton.GetInstance();
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
    // [ValidateAntiForgeryToken]
    public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) // model binding
    {
      System.Console.WriteLine(pizzaViewModel.Crust + " " + pizzaViewModel.Size);
      if (ModelState.IsValid)
      {
        instance.Convert(pizzaViewModel);
        // var repo = new PizzaRepository(_db);
        // try
        // {
        //   repo.Create(pizzaViewModel.Convert(pizzaViewModel));
        // }
        // catch(DbUpdateException)
        // {
        //   System.Console.WriteLine("Exception catched in controller");
        // }
        // return Redirect("/user/index"); // <-- 300-series status
        return RedirectToAction("Home");    // What is going on here>????
      }
      return View();
    }
    public IActionResult Cart()
    {
      if(instance.Pizzas == null){
        System.Console.WriteLine("Pizza List is Empty");
        return NotFound();
      }
      return View("Cart", instance.Pizzas);
    }
    public IActionResult Checkout()
    {
      var order = new OrderModel(){
        Pizzas = instance.Pizzas,  // calculate price here
      };
      instance.Orders.Add(order);
      return View("Checkout", order);
    }
    [HttpPost]
    public IActionResult Submit(OrderModel order, String username)
    {
      if(ModelState.IsValid)
      {
        if(username==null)
        {
          System.Console.WriteLine("username came in null");
        }
        instance.Orders[0].StoreId = order.StoreId;  // FIXME
        instance.Orders[0].OrderDate = DateTime.Now; // FIXME
        instance.Name = username;
        System.Console.WriteLine("Orders: " + instance.Orders.Count);
        var repo = new UserRepository(_db);
        if(repo.Insert(instance.GetUserModel()))
        {
          return View("ThankYou");
        }
      }
      return NotFound();
    }
    public IActionResult Delete(int id)
    {
      if(instance.Pizzas == null)
      {
        System.Console.WriteLine("No Pizzas to Delete");
        return View();
      }
      if(id >= 0)
      {
        instance.Pizzas.RemoveAt(id);
        System.Console.WriteLine("Pizza removed succesfully");
        System.Console.WriteLine("num of pizzas left in cart: " + instance.Pizzas.Count());
        return RedirectToAction("Cart");
      }
      System.Console.WriteLine("Pizza came in null from Cart/Delete");
      return NotFound();
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