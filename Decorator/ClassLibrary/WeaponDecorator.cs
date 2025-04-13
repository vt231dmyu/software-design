using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WeaponDecorator : BaseDecorator
    {
        public WeaponDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Weapon";
        }
    }
}
