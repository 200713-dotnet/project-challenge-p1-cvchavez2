using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Models
{
  public class OrderViewModel
  {
    private PizzaStoreDbContext _db;
    public OrderViewModel()
    {
      Pizzas = new List<PizzaModel>();
    }
    public OrderViewModel(PizzaStoreDbContext context)
    {
      _db = context;
    }
    [DataType(DataType.Date)]
    public DateTime OrderDate { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal OrderTotal { get; set; }
    public List<PizzaModel> Pizzas { get; set; }
    public List<PizzaViewModel> PizzasViewModel { get; set; }
    public int StoreId { get; set; }

    public List<OrderViewModel> ConvertFromModelToViewModel(string username)
    {
      var orderViewModelList = new List<OrderViewModel>();

      var query3 = _db.Users.Where(u => u.Name == username)
                  .Include(um => um.Orders).ThenInclude(om => om.Pizzas).Include(m => m.Orders).ThenInclude(om => om.Pizzas).ThenInclude(c => c.Crust)
                  .Include(o => o.Orders).ThenInclude(p => p.Pizzas).ThenInclude(s => s.Size)
                  .Include(o => o.Orders).ThenInclude(p => p.Pizzas).ThenInclude(s => s.Toppings);
      foreach (var user in query3)
      {
        var order = new OrderViewModel();
        foreach (var ord in user.Orders)
        {
          order.OrderDate = ord.OrderDate;
          order.OrderTotal = ord.OrderTotal;
          order.StoreId = ord.StoreId;
          foreach (var p in ord.Pizzas)
          {
            order.Pizzas.Add(p);
          }
        }
        orderViewModelList.Add(order);
      }
      return orderViewModelList;
    }
  }

}