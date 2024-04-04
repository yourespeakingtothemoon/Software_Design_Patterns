using CafeRioSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRioSimulator.ConcreteComponents
{
    internal class Tacos : DishComponent
    {
        private double price;
        private int tasteValue;
        private string description = "Three tacos made with ";

        public Tacos(double price, int tasteValue)
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
