using System;
using System.Collections.Generic;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class Singleton : AModel
  {

    private static Singleton instance;
    private Singleton()
    {
      Orders = new List<OrderModel>();
      Pizzas = new List<PizzaModel>();
    }

    public static Singleton GetInstance()
    {
      if (instance == null)
      {
        instance = new Singleton();
      }
      return instance;
    }
    public List<OrderModel> Orders { get; set; }

    public List<PizzaModel> Pizzas { get; set; }

    public bool AddOrder(OrderModel order)
    {
      try{
        order.ComputeOrderTotal();
        Orders.Add(order);
      }
      catch(Exception e)
      {
        System.Console.WriteLine(e);
        return false;
      }
      return true;
    }
    public UserModel GetUserModel()
    {
      var userModel = new UserModel();
      userModel.Name = Singleton.GetInstance().Name;
      userModel.Orders = Singleton.GetInstance().Orders;
      return userModel;
    }
    public void Convert(PizzaViewModel pizzaViewModel)
    {
      var pizza = new PizzaModel();
      Pizzas.Add(pizza.Create(pizzaViewModel.PizzaName,
                    pizzaViewModel.Crust,
                    pizzaViewModel.Size,
                    ExtractToppings(pizzaViewModel.SelectedToppings)));
      System.Console.WriteLine("num pizzas in order: " + Pizzas.Count);
      foreach (var p in Pizzas)
      {
        System.Console.WriteLine("pizza price: " + p.Price);
      }
    }
    public List<string> ExtractToppings(List<CheckBoxTopping> selectedToppings)
    {
      var toppings = new List<string>();
      foreach (var st in selectedToppings)
      {
        if (st.IsSelected)
        {
          toppings.Add(st.Name);
        }
      }
      return toppings;
    }
  }
}