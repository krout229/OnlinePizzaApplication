using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime createdDate { get; set; }
        public bool IsActive { get; set; }
        public User user { get; set; }
    }
}
