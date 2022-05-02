using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class Reviews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Review { get; set; }
        public User user { get; set; }
    }
}
