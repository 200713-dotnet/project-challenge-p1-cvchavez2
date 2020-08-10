using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public class ToppingModel : AModel
  {
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }

    const decimal CHEESE_PRICE = 0.7M;
    const decimal HAM_PRICE = 0.6M;
    const decimal JALAPENO_PRICE = 0.5M;
    const decimal MUSHROOMS_PRICE = 0.9M;
    const decimal OLIVES_PRICE = 0.35M;
    const decimal PEPPERONI_PRICE = 0.4M;
    const decimal PINEAPPLE_PRICE = 0.80M;
    const decimal SPINACH_PRICE = 0.80M;

    public void SetPrice()
    {
      switch (Name)
      {
        case "Cheese":
          Price = CHEESE_PRICE;
          break;
        case "Ham":
          Price = HAM_PRICE;
          break;
        case "Jalapeno":
          Price = JALAPENO_PRICE;
          break;
        case "Mushrooms":
          Price = MUSHROOMS_PRICE;
          break;
        case "Olives":
          Price = OLIVES_PRICE;
          break;
        case "Pepperoni":
          Price = PEPPERONI_PRICE;
          break;
        case "Pineapple":
          Price = PINEAPPLE_PRICE;
          break;
        case "Spinach":
          Price = SPINACH_PRICE;
          break;
      }
    }
  }
}
