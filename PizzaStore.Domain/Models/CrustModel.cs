using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public class CrustModel : AModel
  {
    const decimal REGULAR_CRUST = 0.0M;
    const decimal CHEESE_STUFFED_CRUST = 1.0M;
    const decimal FLATBREAD_CRUST = 0.5M;
    const decimal CHICAGO_CRUST = 0.75M;
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }

    public void SetPrice()
    {
      switch (Name)
      {
        case "Regular":
          Price = REGULAR_CRUST;
          break;
        case "Stuffed":
          Price = CHEESE_STUFFED_CRUST;
          break;
        case "Flatbread":
          Price = FLATBREAD_CRUST;
          break;
        case "Chicago":
          Price = CHICAGO_CRUST;
          break;
      }
    }
  }
}