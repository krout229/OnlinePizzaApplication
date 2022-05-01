using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlinePizzaApplication.BAL.Services;
using OnlinePizzaApplication.Entity;
namespace OnlinePizzaApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private PizzaServices _pizzaServices;
        public PizzaController(PizzaServices pizzaServices)
        {
            _pizzaServices = pizzaServices;
        }
        [HttpPost("SavePizza")]
        public IActionResult SavePizza(Pizza pizza)
        {
            return Ok(_pizzaServices.SavePizza(pizza));
        }

        [HttpPost("DeletePizza")]
        public IActionResult DeletePizza(int Pizza_Id)
        {
            return Ok(_pizzaServices.DeletePizza(Pizza_Id));
        }

        [HttpPost("UpdatePizza")]
        public IActionResult UpdatePizza(Pizza pizza)
        {
            return Ok(_pizzaServices.UpdatePizza(pizza));
        }

        [HttpGet("GetPizza")]
        public IActionResult GetPizza(int Pizza_Id)
        {
            return Ok(_pizzaServices.DeletePizza(Pizza_Id));
        }

        [HttpGet("GetAllPizzas")]
        public List<Pizza> GetAllPizzas()
        {
            return _pizzaServices.GetAllPizzas();
        }
    }
}
