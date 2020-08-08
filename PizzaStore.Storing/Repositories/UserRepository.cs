using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Domain.Models;
using domain = PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repositories
{
  public class UserRepository
  {
    private PizzaStoreDbContext _db;

    public UserRepository(PizzaStoreDbContext context)
    {
      _db = context;
    }

    public bool Insert(UserModel user)
    {
      _db.Add(user);
      _db.SaveChanges();
      return true;
    }
  }
}