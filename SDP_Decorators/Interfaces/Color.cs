using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Decorators.Interfaces
{
    abstract class Color : WeaponComponent
    {

        private WeaponComponent baseComponent;

        public Color(WeaponComponent baseComp)
        {
            this.baseComponent = baseComp;
        }

        public override int Fire()
        {
            return baseComponent.Fire();
        }

    }
}
