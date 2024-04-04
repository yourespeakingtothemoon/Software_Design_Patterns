using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteDecorators.AddOns
{
    internal class FreshAvocado :  AddOn
    {
        private double price = 1.00;
        private int tasteValue = 7;
        private string description = "topped with fresh avocado slices, ";
        public FreshAvocado(DishComponent baseComp) : base(baseComp)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + price;
        }

        public override int GetTasteValue()
        {
            return base.GetTasteValue() + tasteValue;
        }

        public override string GetDescription()
        {
           return base.GetDescription() + description;
        }
    }
}
