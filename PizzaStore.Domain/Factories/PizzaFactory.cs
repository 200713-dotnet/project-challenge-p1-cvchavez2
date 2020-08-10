using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Factories
{
  public class PizzaFactory : IFactory<PizzaModel>
  {
    public PizzaModel Create()
    {
      var p = new PizzaModel();

      p.Crust = new CrustModel();
      p.Size = new SizeModel();
      p.Toppings = new List<ToppingModel> { new ToppingModel() };

      return p;
    }

    public PizzaModel Create(PizzaModel t)
    {
      throw new System.NotImplementedException();
    }

    public PizzaModel Create(string pizzaName, string crust, string size, List<string> toppings)
    {
      var p = new PizzaModel(){ Name = pizzaName};
      p.Crust = new CrustModel() { Name = crust };
      p.Crust.SetPrice();
      p.Size = new SizeModel(){Name = size };
      p.Size.SetPrice();
      foreach(var t in toppings)
      {
        var topping = new ToppingModel(){ Name = t };
        topping.SetPrice();
        p.Toppings.Add(topping);
      }
      p.ComputePizzaPrice();
      return p;
    }
  }
}