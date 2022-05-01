using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class Toppings
    {
        [Key]
        public int ToppingsId { get; set; }

       
        public int Pizza_Id { get; set; }

        public string ToppingName { get; set; }
        

        
    }
}
