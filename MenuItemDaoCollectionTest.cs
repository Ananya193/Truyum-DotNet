using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollectionTest
    {
        public static void TestGetMenuItemListAdmin()
        {
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            List<MenuItem> menuItemList = menuItemDaoCollection.GetMenuItemListAdmin();
            foreach (var item in menuItemList)
            {
                Console.WriteLine(item.Name + " Rs." + item.Price.ToString() + " " + item.Active + " " + item.DateOfLaunch.ToString("dd-MM-yyyy") + " " + item.Category + " " + item.FreeDelivery);
            }
        }
        public static void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            List<MenuItem> menuItemList = menuItemDaoCollection.GetMenuItemListCustomer();
            foreach (var item in menuItemList)
            {
                Console.WriteLine(item.Name + " Rs." + item.Price.ToString() + " " + item.Active + " " + item.DateOfLaunch.ToString("dd-MM-yyyy") + " " + item.Category + " " + item.FreeDelivery);
            }
        }

        public static void TestModifyMenuItem()
        {
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            MenuItem menuItem = new MenuItem { Id = 1, Name = "Sandwitch", Price = 100.00F, Active = "Yes", DateOfLaunch = DateUtility.ConvertToDate("2017/03/15"), Category = "Main Course", FreeDelivery = "Yes" };
            menuItemDaoCollection.ModifyMenuItem(menuItem);
        }
        public static void TestGetMenuItem()
        {
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            MenuItem menuItem = menuItemDaoCollection.GetMenuItem(1);
            Console.WriteLine(menuItem.Name + " Rs." + menuItem.Price.ToString() + " " + menuItem.Active + " " + menuItem.DateOfLaunch.ToString("dd-MM-yyyy") + " " + menuItem.Category + " " + menuItem.FreeDelivery);

        }
       

    }
}
