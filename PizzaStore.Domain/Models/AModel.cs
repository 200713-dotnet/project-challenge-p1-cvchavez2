namespace PizzaStore.Domain.Models
{
  public abstract class AModel
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }

  }
}