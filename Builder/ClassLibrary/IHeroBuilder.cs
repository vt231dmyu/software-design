using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IHeroBuilder : ICharacterBuilder<IHeroBuilder>
    {
        IHeroBuilder ProtectSomething(string something);
        IHeroBuilder SaveSomeone(string someone);
    }
}
