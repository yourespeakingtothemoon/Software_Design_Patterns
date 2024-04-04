using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDP_Decorators.Interfaces;

namespace SDP_Decorators.ConcreteDecorator
{
    internal class Barrel : Mod
    {
        private int barrelDamage;

        public Barrel(WeaponComponent baseComp, int inBarrelDamage) : base(baseComp)
        {
            this.barrelDamage = inBarrelDamage;
        }

        public override int Fire()
        {
            return base.Fire() + barrelDamage;
        }
    }
}
