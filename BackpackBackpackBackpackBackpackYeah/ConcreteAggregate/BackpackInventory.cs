using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackpackBackpackBackpackBackpackYeah.Interfaces;
using BackpackBackpackBackpackBackpackYeah.ConcreteIterator;

namespace BackpackBackpackBackpackBackpackYeah.ConcreteAggregate
{
    internal class BackpackInventory : IInventoryAgg
    {
        public List<IItem> Items = new List<IItem>();
       public BackpackInventory()
        {
            this.Items = new List<IItem>();
        }
        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public IInventoryIterator GetIterator()
        {
            return new BackpackIterator(this);
        }

        public void SwipeItem(IItem item)
        {
            Items.Remove(item);
        }
    }
}
