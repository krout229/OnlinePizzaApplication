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
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartItem> cartItem { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItem { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Toppings> toppings { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> user { get; set; }
    }
}
