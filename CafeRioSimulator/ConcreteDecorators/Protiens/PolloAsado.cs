using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteDecorators.Protiens
{
    internal class PolloAsado : AddOn
    {
        private double price = 0.75;
        private int tasteValue = 3;
        private string description = "earthy and zesty grilled chicken, ";
        public PolloAsado(DishComponent baseComp) : base(baseComp)
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
