using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Inventory_Class
{
    public class Item
    {
        protected string name;
        protected int price;
        protected string shape;

        public Item()
        {
            name = "아이템";
            price = 0;
            shape = "■";
        }

        public string Name
        {
            get { return name; }
        }

        public int Price
        {
            get { return price; }
        }

        public string Shape
        {
            get { return shape; }
        }
    }

    public class Potion : Item
    {
        public Potion()
        {
            name = "포션";
            price = 10;
            shape = "♠";
        }
    }

    public class Gem : Item
    {
        public Gem()
        {
            name = "보석";
            price = 100;
            shape = "◈";
        }
    }

    public class Iron : Item
    {
        public Iron()
        {
            name = "철";
            price = 5;
            shape = "▣";
        }
    }
}
