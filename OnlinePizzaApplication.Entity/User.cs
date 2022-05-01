using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePizzaApplication.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string name { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
