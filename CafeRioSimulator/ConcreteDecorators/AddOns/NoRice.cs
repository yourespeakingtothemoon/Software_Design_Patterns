using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteDecorators.AddOns
{
    internal class NoRice :  AddOn
    {
        private double price = 0.10;
        private int tasteValue = 0;
        private string description = "served piping hot.";
        public NoRice(DishComponent baseComp) : base(baseComp)
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
