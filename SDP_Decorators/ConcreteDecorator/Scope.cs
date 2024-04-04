using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDP_Decorators.Interfaces;

namespace SDP_Decorators.ConcreteDecorator
{
    internal class Scope : Mod
    {
        private int scopeDamage;

        public Scope(WeaponComponent baseComp, int inScopeDamage) : base(baseComp)
        {
            this.scopeDamage = inScopeDamage;
        }

        public override int Fire()
        {
            return base.Fire() + scopeDamage;
        }
    }
}
