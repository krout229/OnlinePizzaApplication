using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Payement")]    
        public int Payment_Id { get; set; }
        public string street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Locality { get; set; }
        public string PhoneNumber { get; set; }

        public User user { get; set; }
        public Payment payment { get; set; }
    }
}
