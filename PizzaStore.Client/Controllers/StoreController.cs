using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;
using PizzaStore.Storing.Repositories;

namespace PizzaStore.Client.Controllers
{
  public class StoreController : Controller
  {
    private readonly PizzaStoreDbContext _db;

    public StoreController(PizzaStoreDbContext dbContext)
    {
      _db = dbContext;
    }

    public IActionResult Home()
    {
      return View("Index");
    }
    public IActionResult Menu(int storeId)
    {
      ViewData["StoreId"] = storeId;
      return View("AdminMenu");
    }
    public IActionResult ViewAll(int storeId)
    {
      ViewData["StoreName"] = storeId == 1 ? "West" : "East";
      var repo = new StoreRepository(_db);
      var ordersVM = StoreViewModel.ConvertToVM(repo.GetAll(storeId));
      return View("ViewOrders", ordersVM);
    }
    public IActionResult GetOrdersByUser()
    {
      return View("/User/UserName");
    }
    [HttpPost]
    public IActionResult GetOrdersByUser(string username)
    {
      if (username != null)
      {
        ViewData["Username"] = username;
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