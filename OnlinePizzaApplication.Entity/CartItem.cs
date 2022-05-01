using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class CartItem
    {
        [Key]
        public int CartItem_id { get; set; }
        public int CartId { get; set; }
        public int Pizza_Id { get; set; }
        public int ToppingsId { get; set; }
        public decimal Price { get;  set; }
        public int Quantity { get; set; }
    }
}
