using System;
using System.Collections.Generic;
using System.Text;
using OnlinePizzaApplication.DAL.Repository;
using OnlinePizzaApplication.Entity;

namespace OnlinePizzaApplication.BAL.Services
{
    class PizzaServices
    {
        private IPizzaRepository _pizzaRepository;
        public PizzaServices(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public string SavePizza(Pizza pizza)
        {
            return _pizzaRepository.SavePizza(pizza);
        }
        public string UpdatePizza(Pizza pizza)
        {
            return _pizzaRepository.UpdatePizza(pizza);
        }
        public string DeletePizza(int Pizza_Id)
        {
            return _pizzaRepository.DeletePizza(Pizza_Id);
        }
        public Pizza GetPizza(int Pizza_Id)
        {
            return _pizzaRepository.GetPizza(Pizza_Id);
        }
        public List<Pizza> GetAllPizzas()
        {
            return _pizzaRepository.GetAllPizzas();
        }
    }
}
