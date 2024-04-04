using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRioSimulator.Interfaces
{
    abstract class DishComponent
    {
        public abstract double GetPrice();
        public abstract int GetTasteValue();
        public abstract string GetDescription();
    }
}
