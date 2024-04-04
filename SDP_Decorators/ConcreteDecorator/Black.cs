using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDP_Decorators.Interfaces;

namespace SDP_Decorators.ConcreteDecorator
{
    internal class Black : SDP_Decorators.Interfaces.Color
    {
        public Black(WeaponComponent baseComp) : base(baseComp)
        {
        }

        public override int Fire()
        {
            return base.Fire();
                

        }
    }
}
    

