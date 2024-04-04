using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteComponents
{
    internal class Burrito : DishComponent
    {
        private double price;
        private int tasteValue;
        private string description = "A massive and freshly made burrito including ";
        public Burrito(double price, int tasteValue)
        {
            this.price = price;
            this.tasteValue = tasteValue;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override int GetTasteValue()
        {
            return tasteValue;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
