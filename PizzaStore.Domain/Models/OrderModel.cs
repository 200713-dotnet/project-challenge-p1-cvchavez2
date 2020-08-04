using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public class OrderModel : AModel
  {
        public DateTime OrderDate { get; set; }
        
        [Column(TypeName = "decimal(18,4)")]
        public decimal OrderTotal { get; set; }
        public List<PizzaModel> Pizzas { get; set; }
  }
}