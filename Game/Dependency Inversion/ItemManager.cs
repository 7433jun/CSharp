using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Dependency_Inversion
{
    internal class ItemManager 
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void UseItem(Item item)
        {
            item.Use();
            items.Remove(item);
        }

        public void UseAllItem()
        {
            foreach (Item item in items)
            {
                item.Use();
            }
        }
    }
}
