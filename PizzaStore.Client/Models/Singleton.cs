using System.Collections.Generic;
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

    public UserModel GetUserModel()
    {
      var userModel = new UserModel();
      userModel.Name = Singleton.GetInstance().Name;
      userModel.Orders = Singleton.GetInstance().Orders;
      return userModel;
    }
    public void Convert(PizzaViewModel pizzaViewModel)
    {
      // var toppings = new List<ToppingModel>();
      // foreach(var t in pizzaViewModel.SelectedToppings)
      // {
      //   toppings.Add(new ToppingModel()
      //   {
      //     Name = t.Name
      //   });
      // }
      var pizza = new PizzaModel()
      {
        Name = "Hawaiian",
        Crust = new CrustModel()
        {
          Name = pizzaViewModel.Crust
        },
        Size = new SizeModel()
        {
          Name = pizzaViewModel.Size
        },
        // Toppings = toppings,
        Price = 9.99M
      };
      Pizzas.Add(pizza);
      System.Console.WriteLine("num pizzas in order: " + Pizzas.Count);
    }
  }
}