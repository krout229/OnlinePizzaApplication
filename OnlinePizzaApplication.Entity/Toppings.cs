using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class Toppings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ToppingsId { get; set; }

        [ForeignKey("Pizza")]
        public int Pizza_Id { get; set; }

        public string ToppingName { get; set; }
        public Pizza pizza { get; set; }

        
    }
}
