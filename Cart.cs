using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingCart
{
    class Cart
    {
        public Cart()
        {
            items = new List<Item>();
        }


        private List<Item> items;


        public string AddToCart(string itemName, int package, double price)
        {
            Item item = new Item(items.Count + 1, package, itemName, price);
            this.items.Add(item);
            return item.ToString();
        }

        public IEnumerable<string> GetCartItemNames()
        {
            foreach (var item in this.items)
            {
                yield return item.ToString();
            }
        }
    }
}
