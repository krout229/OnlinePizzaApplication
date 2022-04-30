using Microsoft.EntityFrameworkCore;
using OnlinePizzaApplication.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePizzaApplication.DAL.Data
{
    public class PizzaDbContext:DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {

        }
        public DbSet<Pizza> pizza { get; set; }
        
    }
}
