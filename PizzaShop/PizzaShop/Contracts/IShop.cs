using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public interface IShop
    {
        void PickItem(IItem item);
        void DropItem(IItem item);
    }
}
