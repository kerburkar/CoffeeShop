using CoffeeShop.Business.Abstract;
using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.DataAccess.Concrete.EntityFramework;
using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Concrete
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
     
        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public IList<Menu> GetMenus()
        {
            return _menuRepository.GetAll().ToList();

        }

        public Menu GetMenu(int id)
        {
            return _menuRepository.Get(q => q.Id == id);
        }
    }
}
