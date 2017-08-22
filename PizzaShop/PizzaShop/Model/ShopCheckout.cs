using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShoppingMania
{
    public class ShopCheckout : ICheckout
    {       
        public string PlaceOrder(int orderNo)
        {
            return "Order placed succesfully";
        }       
    }
}
