using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShoppingMania
{
    public interface ICheckout
    {        
        string PlaceOrder(int orderNo);        
    }
}
