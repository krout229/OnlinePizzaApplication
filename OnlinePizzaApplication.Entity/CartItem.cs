using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartItem_id { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        [ForeignKey("Pizza")]
        public int Pizza_Id { get; set; }
        [ForeignKey("Toppings")]
        public int ToppingsId { get; set; }
        public decimal Price { get;  set; }
        public int Quantity { get; set; }
        public Cart cart { get; set; }
        public Pizza pizza { get; set; }
        public Toppings toppings { get; set; }
    }
}
