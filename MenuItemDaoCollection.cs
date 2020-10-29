using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    class MenuItemDaoCollection : IMenuItemDao
    {
        private static List<MenuItem> _menuItemList;


        public MenuItemDaoCollection()
        {
            if (_menuItemList==null)
            {
                _menuItemList = new List<MenuItem>();
                _menuItemList.Add(new MenuItem {Id=1,Name="Sandwitch",Price= 99.00F,Active="Yes",DateOfLaunch= DateUtility.ConvertToDate("2017/03/15"),Category="Main Course",FreeDelivery="Yes" });
                _menuItemList.Add(new MenuItem { Id = 2, Name = "Burger", Price = 129.00F, Active = "Yes", DateOfLaunch = DateUtility.ConvertToDate("2017/12/23"), Category = "Main Course", FreeDelivery = "No" });
                _menuItemList.Add(new MenuItem { Id = 3, Name = "Pizza", Price = 149.00F, Active = "Yes", DateOfLaunch = DateUtility.ConvertToDate("2018/08/21"), Category = "Main Course", FreeDelivery = "No" });
                _menuItemList.Add(new MenuItem { Id = 4, Name = "French Fries", Price = 57.00F, Active = "No", DateOfLaunch = DateUtility.ConvertToDate("2017/07/02"), Category = "Starters", FreeDelivery = "Yes" });
                _menuItemList.Add(new MenuItem { Id = 5, Name = "Chocolate Brownie", Price = 32.00F, Active = "Yes", DateOfLaunch = DateUtility.ConvertToDate("2022/11/02"), Category = "Dessert", FreeDelivery = "Yes" });

            }
        }
        
        public MenuItem GetMenuItem(long menuItemId)
        {
            MenuItem menuItem = null;
            foreach (var item in _menuItemList)
            {
                if (item.Id==menuItemId)
                {
                    menuItem = item;
                }
            }
            return menuItem;
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return _menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> menuItemListCustomer = new List<MenuItem>();
            foreach (var item in _menuItemList)
            {
                if (item.DateOfLaunch<DateTime.Now && item.Active=="Yes")
                {
                    menuItemListCustomer.Add(item);
                }
            }
            return menuItemListCustomer;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            foreach (var item in _menuItemList)
            {
                if (item.Id==menuItem.Id)
                {
                    item.Name= menuItem.Name;
                    item.Price = menuItem.Price;
                    item.Active = menuItem.Active;
                    item.DateOfLaunch = menuItem.DateOfLaunch;
                    item.Category = menuItem.Category;
                    item.FreeDelivery = menuItem.FreeDelivery;
                }
            }
        }
    }
}
