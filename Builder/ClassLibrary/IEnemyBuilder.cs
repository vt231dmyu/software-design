using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IEnemyBuilder : ICharacterBuilder<IEnemyBuilder>
    {
        IEnemyBuilder DestroySomething(string something);
        IEnemyBuilder KillSomeone(string someone);
    }
}
