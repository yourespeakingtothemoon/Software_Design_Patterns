using SDP_Decorators.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Decorators.ConcreteComponent
{
    internal class Pistol : WeaponComponent
    {
        private int damage;

        public Pistol(int inDamage)
        {
            this.damage = inDamage;
        }

        public override int Fire()
        {
            return damage;
        }
    }
}
