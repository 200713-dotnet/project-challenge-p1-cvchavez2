using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Domain.Models
{
  public class OrderModel : AModel
  {
        public OrderModel()
        {
          Pizzas = new List<PizzaModel>();
        }
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        
        [Display(Name = "Order Total")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal OrderTotal { get; set; }
        public List<PizzaModel> Pizzas { get; set; }
        
        [Required(ErrorMessage = "Select a store")]
        [Display(Name = "Store")]
        public int StoreId { get; set; }

  }
}