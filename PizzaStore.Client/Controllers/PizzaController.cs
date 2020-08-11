using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  public class PizzaController : Controller
  {
    // private readonly PizzaStoreDbContext _dp = new PizzaStoreDbContext(); // instantiated one time at run time
    // we need to inject the dependency in the constructor of the PizzaStoreSbContext
    private readonly PizzaStoreDbContext _db;
    public PizzaController(PizzaStoreDbContext dbContext) // constructor depeendency injction
    {
      _db = dbContext;
    }

  
    public IActionResult Home()
    {
      ViewData["Name"] = "Carlos";
      return View();
    }

    [HttpGet()] // filter // read about action filters
    public IActionResult Get()
    {
      return View("Home2", _db.Pizzas.ToList()); 
    }
    // [HttpGet()] // filter // read about action filters
    // public IEnumerable<PizzaModel> Get()
    // {
    //   return _db.Pizzas.ToList();
    // }
    [HttpGet("{id}")] // filter
    public PizzaModel Get(int id)
    {
      return _db.Pizzas.SingleOrDefault(p => p.Id == id);

      // foreach(var p in _db.Pizzas) // this is what we are doing in the Lambda function
      // {
      //   if(p.Id == id)
      //   {
      //     return p;
      //   }
      // }
      // return null;
    }
  }
}