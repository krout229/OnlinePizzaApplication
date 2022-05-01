using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class OrderItem
    {
       [Key]
        public int OrderItemId { get; set; }
        public int Pizza_Id { get; set; }
        public int ToppingsId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string OrderId { get; set; }
    }
}
