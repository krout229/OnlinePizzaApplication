using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class OrderItem
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }
        [ForeignKey("Pizza")]
        public int Pizza_Id { get; set; }
        [ForeignKey("Toppings")]
        public int ToppingsId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        [ForeignKey("Order")]
        public string OrderId { get; set; }
        public Pizza pizza { get; set; }
        public Toppings toppings { get; set; }
        public Order order { get; set; }
    }
}
