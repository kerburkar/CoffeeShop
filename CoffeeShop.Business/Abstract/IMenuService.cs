using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Abstract
{
    public interface IMenuService
    {
        IList<Menu> GetMenus();
        Menu GetMenu(int id);
    }
}
