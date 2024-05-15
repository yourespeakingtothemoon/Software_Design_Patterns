using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackBackpackBackpackBackpackYeah.Interfaces
{
    internal interface IInventoryIterator
    {
        bool HasNext();
        void Next();

        IItem? Current();
    }
}
