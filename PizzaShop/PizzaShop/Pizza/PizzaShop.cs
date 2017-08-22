using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class PizzaShop : IShop
    {
        private  ICart _pizzaCart;

        public PizzaShop(ICart cart)
        {
            _pizzaCart = cart;
        }
        private List<IItem> _itemList = new List<IItem>()
        {
            new VegPizza(),
            new NonVegPizza()
        };          

        public void PickItem(IItem item)
        {
            _pizzaCart.Add(item);
        }

        public void DropItem(IItem item)
        {
            _pizzaCart.Add(item);
        }
    }
}
