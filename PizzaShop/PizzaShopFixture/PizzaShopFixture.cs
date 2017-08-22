using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PizzaShoppingMania;

namespace PizzaShopFixture
{
    public class PizzaShopFixture
    {
        [Fact]
        public void Is_item_adding_up_onto_cart()
        {
            ShoppingCart cart = new ShoppingCart(2);
            PizzaShop shop = new PizzaShop(cart);
            shop.PickItem(new VegPizza());
            Assert.Equal(cart.ItemList.Count,1);
        }       
    }
}
