using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Contracts
{
    public interface ICheckout
    {
        void PlaceOrder();
        void DropOrder();
    }
}
