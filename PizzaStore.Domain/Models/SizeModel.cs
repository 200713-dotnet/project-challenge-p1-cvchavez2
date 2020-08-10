
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public class SizeModel : AModel
  {
    const decimal SMALL = 5.0M;
    const decimal MEDIUM = 7.0M;
    const decimal LARGE = 9.0M;
    const decimal XLARGE = 11.0M;
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }

    public void SetPrice()
    {
     switch (Name)
      {
        case "S":
          Price = SMALL;
          break;
        case "M":
          Price = MEDIUM;
          break;
        case "L":
          Price = LARGE;
          break;
        case "XL":
          Price = XLARGE;
          break;
        
      }
    }
  }
}