using Microsoft.EntityFrameworkCore;
using OnlinePizzaApplication.DAL.Data;
using OnlinePizzaApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlinePizzaApplication.DAL.Repository
{
    public class PizzaRepository : IPizzaRepository
    {
        private PizzaDbContext _pizzaDb;
        public PizzaRepository(PizzaDbContext pizzaDbContext)
        {
            _pizzaDb = pizzaDbContext;
        }
        public string DeletePizza(int Pizza_Id)
        {
            string msg = "";
            Pizza deletePizza =_pizzaDb.pizza.Find(Pizza_Id);//storing the details of the movie in the obj 
            if (deletePizza != null)
            {
                _pizzaDb.pizza.Remove(deletePizza);
                _pizzaDb.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public Pizza GetPizza(int Pizza_Id)
        {
            Pizza pizza = _pizzaDb.pizza.Find(Pizza_Id);
            return pizza;

        }

        public List<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas = _pizzaDb.pizza.ToList();
            return pizzas;
        }

        public string SavePizza(Pizza pizza)
        {
           _pizzaDb.pizza.Add(pizza);
            _pizzaDb.SaveChanges();
            return "Saved";
        }

        public string UpdatePizza(Pizza pizza)
        {
           _pizzaDb.Entry(pizza).State = EntityState.Modified;
            _pizzaDb.SaveChanges();
            return "Updated";
        }
    }
}
