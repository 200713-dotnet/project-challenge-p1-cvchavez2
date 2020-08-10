using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
    public interface IFactory<T> where T : class, new()
    {
        T Create();
        T Create(T t);
        T Create(string name, string crust, string size, List<string> toppings);
    }
}