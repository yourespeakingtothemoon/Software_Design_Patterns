using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteDecorators.AddOns
{
    internal class UndercookedRice :  AddOn
    {
        private double price = 0.10;
        private int tasteValue = -5;
        private string description = "served piping hot on a bed of crunchy and near-inedible undercooked rice, better luck next time.";

        public UndercookedRice(DishComponent baseComp) : base(baseComp)
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
