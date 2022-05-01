using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int Payment_Id { get; set; }
        public string street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public string Locality { get; set; }
        public string PhoneNumber { get; set; }
    }
}
