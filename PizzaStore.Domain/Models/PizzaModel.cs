using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PizzaStore.Domain.Models
{
  public class PizzaModel : AModel
  {
    public CrustModel Crust { get; set; }
    public SizeModel Size { get; set; }
    public List<ToppingModel> Toppings { get; set; } = new List<ToppingModel>();

    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }

    public void ComputePizzaPrice()
    {
      Price = Size.Price + Crust.Price + Toppings.Sum(Topping => Topping.Price); // TODO toppings price
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