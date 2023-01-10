using System;
using System.Collections.Generic;

namespace Composite
{
    // Выпадающий пункт в меню
    
    public class DropDownItem : Item
    {
        private List<Item> children;
        public DropDownItem(string name) : base(name)
        {
            children = new List<Item>();
        }

        public override void Add(Item subItem)
        {
            subItem.SetOwner(this.itemname);
            children.Add(subItem);
        }

        public override void Remove(Item subItem)
        {
            // Внимание не реализовано убирание значение того кто владелец это важный аспект,  но для примера не существенен
            children.Remove(subItem);
        }

        public override void Display()
        {
            foreach (var items in children)
            {
                if (ownername != null)
                    Console.Write(ownername + itemname);
                items.Display();
            }
        }
    }
}