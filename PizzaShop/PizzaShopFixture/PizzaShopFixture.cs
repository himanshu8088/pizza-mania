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
        public void Item_adding_up_onto_cart()
        {
            ShoppingCart cart = new ShoppingCart(2);
            PizzaShop shop = new PizzaShop(cart);
            shop.PickItem(new VegPizza());
            Assert.Equal(cart.ItemList.Count,1);
        }
        [Fact]
        public void Item_removing_up_from_cart()
        {
            ShoppingCart cart = new ShoppingCart(2);
            PizzaShop shop = new PizzaShop(cart);
            IItem item = new VegPizza();
            shop.PickItem(item);
            shop.DropItem(item);
            Assert.Equal(cart.ItemList.Count, 0);
        }

    }
}
