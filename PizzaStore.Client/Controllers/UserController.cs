using Microsoft.AspNetCore.Mvc;
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

    // [HttpGet]         // creeate user model in Domains/Models
    // public IEnumerable<UserModel> Get()
    // {
    //   return _db.Pizzas.ToList();
    // }
  }
}