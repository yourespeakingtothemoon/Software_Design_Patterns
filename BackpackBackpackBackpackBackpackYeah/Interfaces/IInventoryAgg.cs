using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackBackpackBackpackBackpackYeah.Interfaces
{
    internal interface IInventoryAgg
    {
        IInventoryIterator GetIterator();
        void AddItem(IItem item);
        void SwipeItem(IItem item);

    }
}
