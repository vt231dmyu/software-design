using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CharacterDirector
    {
        public Character CreateDreamHero(IHeroBuilder builder)
        {
            return builder
                .SetName("Ichigo")
                .SetHeight("186 cm")
                .SetBodyType("Trapezoid")
                .SetHairColor("Orange")
                .SetEyeColor("Brown")
                .SetClothes("Shinigami shihakusho")
                .AddInventoryItem("Zanpakuto")
                .ProtectSomething("World of the Living")
                .SaveSomeone("Humans")
                .Build();
        }

        public Character CreateWorstEnemy(IEnemyBuilder builder)
        {
            return builder
                .SetName("Yhwach")
                .SetHeight("198 cm")
                .SetBodyType("Rectangle")
                .SetHairColor("Black")
                .SetEyeColor("Reddish-brown")
                .SetClothes("Quincy suit")
                .SetClothes("Burgundy cloak")
                .AddInventoryItem("The Almighty")
                .DestroySomething("Soul Society")
                .KillSomeone("Yamamoto")
                .Build();
        }
    }
}
