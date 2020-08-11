using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Domain.Models;
using domain = PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repositories
{
  public class StoreRepository
  {
    private PizzaStoreDbContext _db;

    public StoreRepository(PizzaStoreDbContext context)
    {
      _db = context;
    }

    public List<OrderModel> GetAll(int storeId)
    {
      // var store = storeId == 1 ? "West" : "East";
      var orders = new List<OrderModel>();
      var query = _db.Orders.Where(s => s.StoreId == storeId)
                  .Include(c => c.Pizzas).ThenInclude(c => c.Crust)
                  .Include(c => c.Pizzas).ThenInclude(c => c.Size)
                  .Include(c => c.Pizzas).ThenInclude(t => t.Toppings);
      foreach (var o in query)
      {
        System.Console.WriteLine("Order Date: " + o.OrderDate);
        var order = new OrderModel();
        order.Id = o.Id;
        order.OrderDate = o.OrderDate;
        order.OrderTotal = o.OrderTotal;
        order.StoreId = o.StoreId;

        foreach (var p in o.Pizzas)
        {
          var toppings = new List<ToppingModel>();
          foreach (var t in p.Toppings)
          {
            var topping = new ToppingModel()
            {
              Name = t.Name,
              Price = t.Price
            };
            toppings.Add(topping);
          }
          order.Pizzas.Add(new PizzaModel()
          {
            Name = p.Name,
            Crust = new CrustModel()
            {
              Name = p.Crust.Name,
              Price = p.Price
            },
            Size = new SizeModel()
            {
              Name = p.Size.Name,
              Price = p.Price
            },
            Price = p.Price,
            Toppings = toppings
          });
        }
        orders.Add(order);
      }
      System.Console.WriteLine("Orders count from db: " + orders.Count);
      return orders;
    }
  }
}