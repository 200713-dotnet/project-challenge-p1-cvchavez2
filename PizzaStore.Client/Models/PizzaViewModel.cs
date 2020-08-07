using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class PizzaViewModel
  {
    // out to the client
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }

    public PizzaViewModel() // use dependency injection here - dbcontext
    {

    }

    [Required(ErrorMessage = "Select a Crust")]
    public string Crust { get; set; }

    [Required(ErrorMessage = "Select a Size")]
    public string Size { get; set; }

    [Range(2, 5)]
    public List<CheckBoxTopping> SelectedToppings { get; set; } // = new List<CheckBoxTopping>();

    public PizzaModel Convert(PizzaViewModel pizzaViewModel)
    {
        var toppings = new List<ToppingModel>();
        foreach(var t in pizzaViewModel.SelectedToppings)
        {
          toppings.Add(new ToppingModel()
          {
            Name = t.Name
          });
        }
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
          Toppings = toppings,
          Price = 9.99M
        };
        return pizza;
    }
    public void Initialize()
    {
      CrustModel c = new CrustModel() { Name = "Stuffed" };
      CrustModel c1 = new CrustModel() { Name = "Thin" };
      CrustModel c2 = new CrustModel() { Name = "Chicago" };
      Crusts = new List<CrustModel>() { c, c1, c2 }; // here we will add the repository to retrieve list of toppings
      SizeModel s = new SizeModel() { Name = "S" };      
      SizeModel s1 = new SizeModel() { Name = "M" };
      SizeModel s2 = new SizeModel() { Name = "L" };
      Sizes = new List<SizeModel>() { s, s1, s2 };
      SelectedToppings = new List<CheckBoxTopping>(){
        new CheckBoxTopping(){
          Id = 1,
          Name = "Jalapeno",
          IsSelected = false,
        },
        new CheckBoxTopping(){
          Id = 2,
          Name = "Olives",
          IsSelected = false,
        },
          new CheckBoxTopping(){
          Id = 2,
          Name = "Cheese",
          IsSelected = false,
        }
      };
    }
  }
  public class CheckBoxTopping : AModel
  {
    public bool IsSelected { get; set; }
  }

}
