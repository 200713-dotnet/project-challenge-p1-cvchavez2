using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
    public class PizzaViewModel
    {
        // out to the client
        public List<CrustModel> Crusts { get; set; }
        public List<SizeModel> Sizes { get; set; }
        public List<ToppingModel> Toppings { get; set; }

        public PizzaViewModel() // use dependency injection here
        {
          CrustModel c = new CrustModel(){Name="stuffed"};
          CrustModel c1 = new CrustModel(){Name="thin"};
          Crusts = new List<CrustModel>(){c, c1}; // here we will add the repository to retrieve list of toppings
          SizeModel s = new SizeModel(){Name="M"};
          SizeModel s1 = new SizeModel(){Name="L"};
          Sizes = new List<SizeModel>(){s, s1};
          ToppingModel t = new ToppingModel(){Name="Jalapeno"};
          ToppingModel t2 = new ToppingModel(){Name="Mushrooms"};
          Toppings = new List<ToppingModel>(){t,t2};
        }

        [Required(ErrorMessage = "Better select a Crust")]
        public string Crust { get; set; }
        [Required]
        public string Size { get; set; }

        [Range(2,5)]
        public List<string> SelectedToppings { get; set; }   // ?????
        public bool SelectedTopping { get; set; } // ?????

    }
}
