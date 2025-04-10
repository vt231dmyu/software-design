using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new CharacterDirector();

            IHeroBuilder heroBuilder = new HeroBuilder();
            IEnemyBuilder enemyBuilder = new EnemyBuilder();

            Character hero = director.CreateDreamHero(heroBuilder);
            Character enemy = director.CreateWorstEnemy(enemyBuilder);

            Console.WriteLine(hero);
            Console.WriteLine(enemy);
        }
    }
}
