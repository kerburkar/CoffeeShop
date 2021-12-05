using CoffeeShop.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuCoffeeController : ControllerBase
    {
        private readonly IMenuCoffeeService _menuCoffeeService;
        public MenuCoffeeController(IMenuCoffeeService menuCoffeeService)
        {
            _menuCoffeeService = menuCoffeeService;
        }

        [HttpGet("getmenuCoffees")]
        public ActionResult GetMenuCoffees()
        {
            var menuCoffees = _menuCoffeeService.GetMenuCoffees();
            return Ok(menuCoffees);

        }

        [HttpGet("getmenuCoffee/{id}")]
        public ActionResult GetMenuCoffee(int id)
        {
            var menuCoffee = _menuCoffeeService.GetMenuCoffee(id);
            return Ok(menuCoffee);

        }
    }
}
