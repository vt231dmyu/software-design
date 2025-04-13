using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArmorDecorator : BaseDecorator
    {
        public ArmorDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Armor";
        }
    }
}
