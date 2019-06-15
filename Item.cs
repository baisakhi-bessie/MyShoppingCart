using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingCart
{
    class Item
    {
        public int ID;
        public int Package;
        public string Name;
        public double Price;
        private int v;
        private string itemName;

        public Item(int id, int package, string name, double price)
        {
            ID = id;
            Package = package;
            Name = name;
            Price = price;
        }
    }
}
