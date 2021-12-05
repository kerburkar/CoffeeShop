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
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("getmenus")]
        public ActionResult GetMenus()
        {
            var menus = _menuService.GetMenus();
            return Ok(menus);

        }

        [HttpGet("getmenu/{id}")]
        public ActionResult GetMenu(int id)
        {
            var menu = _menuService.GetMenu(id);
            return Ok(menu);

        }
    }
}
