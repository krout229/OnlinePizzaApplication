using OnlinePizzaApplication.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePizzaApplication.DAL.Repository
{
   public interface IPizzaRepository
    {
        public string SavePizza(Pizza pizza);
        public string UpdatePizza(Pizza pizza);
        public string DeletePizza(int  Pizza_Id);
        Pizza GetPizza(int Pizza_Id);
        List<Pizza> GetAllPizzas();
    }
}
