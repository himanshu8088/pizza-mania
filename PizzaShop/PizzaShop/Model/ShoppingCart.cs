using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class ShoppingCart : ICart
    {
        public List<IItem> ItemList { get; private set; }
        private int _maxCartLimit;

        public ShoppingCart(int maxCartLimit)
        {
            _maxCartLimit = maxCartLimit;
        }

        public void Add(IItem item)
        {
            if (ItemList.Count < _maxCartLimit)
            {
                ItemList.Add(item);
            }
        }

        public void Remove(IItem item)
        {
            if (ItemList.Count >0)
            {
                ItemList.Remove(item);
            }
        }
    }
}
