using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CafeRioSimulator.Interfaces;

namespace CafeRioSimulator.ConcreteComponents
{
    internal class Enchiladas : DishComponent
    {
        private double price;
        private int tasteValue;
        private string description = "A plate of two enchiladas made with ";

        public Enchiladas(double price, int tasteValue)
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
