using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class BaseDecorator : IHero
    {
        protected IHero _hero;

        public BaseDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetDescription()
        {
            return _hero.GetDescription();
        }
    }
}
