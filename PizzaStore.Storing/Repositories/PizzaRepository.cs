using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzaStore.Domain.Models;
using domain = PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repositories
{
  public class PizzaRepository
  {
    private PizzaStoreDbContext _db;

    public PizzaRepository(PizzaStoreDbContext context)
    {
      _db = context;
    }
    public void Create(PizzaModel pizza)
    {
      try
      {
        _db.Pizzas.Add(pizza);
        _db.SaveChanges();
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex);
        throw ex;
      }
    }

  }
}