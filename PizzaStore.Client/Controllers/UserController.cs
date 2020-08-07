using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  public class UserController : Controller
  {
    private readonly PizzaStoreDbContext _db;

    public UserController(PizzaStoreDbContext dbContext)
    {
      _db = dbContext;
    }

    public IActionResult Home()
    {
      return View("Index");
    }
    public IActionResult GetOrdersByUser()
    {
      return View("UserName");
    }
    [HttpPost]
    public IActionResult GetOrdersByUser(string username)
    {
      if (username != null)
      {
        ViewData["Username"] = username;
        // TODO search for person orders
        // I should give it a list of orders

        // call frommodeltoviewmodel
        var orders = new OrderViewModel(_db);
        return View("ViewOrders", orders.ConvertFromModelToViewModel(username));
      }
      return NotFound();
    }


    // [HttpGet]         // creeate user model in Domains/Models
    // public IEnumerable<UserModel> Get()
    // {
    //   return _db.Pizzas.ToList();
    // }
  }
}