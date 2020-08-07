using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public class PizzaModel : AModel
  {
    public CrustModel Crust { get; set; }
    public SizeModel Size { get; set; }
    public List<ToppingModel> Toppings { get; set; } = new List<ToppingModel>();

    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
  }
}