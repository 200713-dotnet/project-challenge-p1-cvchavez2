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
    public string PizzaName { get; set; }

    [Required(ErrorMessage = "Select a Crust")]
    public string Crust { get; set; }

    [Required(ErrorMessage = "Select a Size")]
    public string Size { get; set; }

    // [Range(2, 5)]
    public List<CheckBoxTopping> SelectedToppings { get; set; } // = new List<CheckBoxTopping>();

    // public List<CheckBoxTopping> SelectedToppings { get; set; } // = new List<CheckBoxTopping>();
    public static PizzaViewModel CreatePizzaVM(string pizzaName)
    {
      var pizza = new PizzaViewModel();
      pizza.PizzaName = pizzaName;
      pizza.Initialize(); pizza.SelectedToppings.Clear();
      if (pizzaName.Equals("Cheese"))
      {
        pizza.SelectedToppings.Add(new CheckBoxTopping()
        {
          Name = "Cheese",
          IsSelected = true
        }
        );
        pizza.SelectedToppings.Add(new CheckBoxTopping()
        {
          Name = "Cheese",
          IsSelected = true
        }
        );
      }
      else if (pizzaName.Equals("Hawaiian"))
      {
        pizza.SelectedToppings.Add(new CheckBoxTopping()
        {
          Name = "Pineapple",
          IsSelected = true
        });
        pizza.SelectedToppings.Add(new CheckBoxTopping()
        {
          Name = "Ham",
          IsSelected = true
        });
      }
      else if (pizzaName.Equals("Veggie"))
      {
        pizza.SelectedToppings.Add(new CheckBoxTopping()
        {
          Name = "Olives",
          IsSelected = true
        });
        pizza.SelectedToppings.Add(new CheckBoxTopping()
        {
          Name = "Spinach",
          IsSelected = true
        });
      }
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
      SelectedToppings = new List<CheckBoxTopping>();
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
          Id = 3,
          Name = "Cheese",
          IsSelected = false,
        },
          new CheckBoxTopping(){
          Id = 4,
          Name = "Pineapple",
          IsSelected = false,
        },
          new CheckBoxTopping(){
          Id = 5,
          Name = "Spinach",
          IsSelected = false,
        },
          new CheckBoxTopping(){
          Id = 6,
          Name = "Ham",
          IsSelected = false,
        },
          new CheckBoxTopping(){
          Id = 7,
          Name = "Mushrooms",
          IsSelected = false,
        },
          new CheckBoxTopping(){
          Id = 8,
          Name = "Pepperoni",
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
