
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
   public class Role 
    {
        [Key]
        public int RoleId { get; set; }
        public string Description { get; set; }
    }
}
