using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        public string TransactionId { get; set; }
        public decimal Tax { get; set; }
        public string Currency { get; set; }
        public decimal Total { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }

        public int UserId { get; set; }
        public decimal GrandTotal { get; set; }
        public Cart cart { get; set; }
        
    }
}
