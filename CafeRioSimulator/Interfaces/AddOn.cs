using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRioSimulator.Interfaces
{
    abstract class AddOn : DishComponent
    {
        private DishComponent baseComponent;

        public AddOn(DishComponent baseComp)
        {
            this.baseComponent = baseComp;
        }

        public override double GetPrice()
        {
            return baseComponent.GetPrice();
        }

        public override int GetTasteValue()
        {
            return baseComponent.GetTasteValue();
        }

        public override string GetDescription()
        {
            return baseComponent.GetDescription();
        }
    }
}
