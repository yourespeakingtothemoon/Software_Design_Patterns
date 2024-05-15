using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackpackBackpackBackpackBackpackYeah.Interfaces;
using BackpackBackpackBackpackBackpackYeah.ConcreteAggregate;

namespace BackpackBackpackBackpackBackpackYeah.ConcreteIterator
{
    internal class BackpackIterator : IInventoryIterator
    {

        BackpackInventory backpack;
        private int index = 0;
        public BackpackIterator(BackpackInventory backpack)
        {
            this.backpack = backpack;
        }
        public bool HasNext()
        {
            return index < backpack.Items.Count;
        }

        public void Next()
        {
            this.index++;
        }

        public IItem? Current()
        {
            return backpack.Items[index] ?? null;
        }
    }
    
    
}
