using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShoppingMania
{
    public interface ICart
    {
        List<IItem> ItemList { get; }
        void Add(IItem item);
        void Remove(IItem item);
    }
}
