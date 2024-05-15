using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackpackBackpackBackpackBackpackYeah.Interfaces;

namespace BackpackBackpackBackpackBackpackYeah.Items
{
    internal class Torch : IItem
    {
        public string? Name()
        {
            return "I'm the Torch!";
        }
    }
}
