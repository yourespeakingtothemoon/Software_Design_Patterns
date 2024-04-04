using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteDecorators.AddOns
{
    internal class HabeneroSauce :  AddOn
    {
        private double price = 0.10;
        private int tasteValue = 6;
        private string description = "a sweet and tastefully spicy habenero sauce, ";
        public HabeneroSauce(DishComponent baseComp) : base(baseComp)
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
