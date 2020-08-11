using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class StoreViewModel
  {
    public static List<OrderViewModel> ConvertToVM(List<OrderModel> orders)
    {
      var ordersVM = new List<OrderViewModel>();
      foreach (var ord in orders)
      {
        var order = new OrderViewModel();
        order.OrderDate = ord.OrderDate;
        order.OrderTotal = ord.OrderTotal;
        order.StoreId = ord.StoreId;
        foreach (var p in ord.Pizzas)
        {
          order.Pizzas.Add(p);
        }
        ordersVM.Add(order);
      }
      return ordersVM;
    }
  }
}