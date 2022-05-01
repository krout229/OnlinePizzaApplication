using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string TransactionId { get; set; }
        public decimal Tax { get; set; }
        public string Currency { get; set; }
        public decimal Total { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public int CartId { get; set; }
        public int UserId { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
