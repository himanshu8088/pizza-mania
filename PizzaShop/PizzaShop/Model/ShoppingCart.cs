using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShoppingMania
{
    public class ShoppingCart : ICart
    {        
        private int _maxCartLimit;
        private List<IItem> _itemList;

        public ShoppingCart(int maxCartLimit)
        {
            _maxCartLimit = maxCartLimit;
            _itemList = new List<IItem>();
        }

        public List<IItem> CartItemList => _itemList;

        public void Add(IItem item)
        {
            if (_itemList.Count < _maxCartLimit)
            {
                _itemList.Add(item);
            }
        }

        public void Remove(IItem item)
        {
            if (_itemList.Count >0)
            {
                _itemList.Remove(item);
            }
        }
    }
}
