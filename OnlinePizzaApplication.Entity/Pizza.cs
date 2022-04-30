using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePizzaApplication.Entity
{
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pizza_Id { get; set; }
        public string Pizza_Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}

