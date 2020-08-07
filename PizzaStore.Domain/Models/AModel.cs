using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public abstract class AModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    
    // [Column(TypeName = "decimal(18,4)")]
    // public decimal Price { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }

  }
}