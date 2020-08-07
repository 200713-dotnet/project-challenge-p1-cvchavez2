using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repositories
{
  public class SeedDB
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var _db = new PizzaStoreDbContext(
        serviceProvider.GetRequiredService<
          DbContextOptions<PizzaStoreDbContext>>()))
      {
        // look for any orders.
        if (_db.Orders.Any())
        {
          // var orderToDelete = _db.Orders.Find(1);
          // _db.Orders.Remove(orderToDelete);
          // _db.SaveChanges();
          // System.Console.WriteLine("Order Deleted");
          return;  // DB has been seeded
        }
        var order1 = new Domain.Models.OrderModel
        {
          OrderDate = DateTime.Now,
          OrderTotal = 15.75M,
          Pizzas = new List<PizzaModel>()
            {
              new PizzaModel()
              {
                Name = "Hawaiian",
                Crust = new CrustModel()
                {
                  Name = "Chicago"
                },
                Size = new SizeModel()
                {
                  Name = "L"
                },
                Toppings = new List<ToppingModel>()
                {
                  new ToppingModel()
                  {
                    Name = "Meat"
                  },
                  new ToppingModel()
                  {
                    Name = "Peppers"
                  }
                },
                Price = 10.75M
              },
              new PizzaModel()
              {
                Name = "Cheese",
                Crust = new CrustModel()
                {
                  Name = "thin"
                },
                Size = new SizeModel()
                {
                  Name = "M"
                },
                Toppings = new List<ToppingModel>()
                {
                  new ToppingModel()
                  {
                    Name = "Jalapeno"
                  },
                  new ToppingModel()
                  {
                    Name = "Olives"
                  }
                },
                Price = 11.99M
              }
            },
            StoreId = 1,
            
        };
        var user = new UserModel();
        user.Name = "Pedro";
        user.Orders.Add(order1);
        _db.Users.Add(user);
        _db.SaveChanges();
      }
    }
  }
}