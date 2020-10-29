using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
   public class CartDaoCollectionTest
    {
        public static void TestAddCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1, 1);
            var cart = cartDao.GetAllCartItems(1);
            foreach (var item in cart.MenuItemList)
            {
                Console.WriteLine(item.Name + " Rs." + item.Price.ToString() + " " + item.Active + " " + item.DateOfLaunch.ToString("dd-MM-yyyy") + " " + item.Category + " " + item.FreeDelivery);
                Console.WriteLine(cart.Total);
            }
        }
        public static void TestGetAllCartItems()
        {
            try
            {
                CartDaoCollection cartDao = new CartDaoCollection();
                var cart = cartDao.GetAllCartItems(1);
                if (cart != null)
                {
                    foreach (var item in cart.MenuItemList)
                    {
                        Console.WriteLine(item.Name + " Rs." + item.Price.ToString() + " " + item.Active + " " + item.DateOfLaunch.ToString("dd-MM-yyyy") + " " + item.Category + " " + item.FreeDelivery);
                        Console.WriteLine(cart.Total);
                    }
                }
            }
            catch (CartEmptyException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        public static void TestRemoveCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
           
            try
            {
                cartDao.RemoveCartItem(1, 1);
                cartDao.GetAllCartItems(1);
            }
            catch (CartEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
