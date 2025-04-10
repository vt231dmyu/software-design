using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ICharacterBuilder<TBuilder>
    {
        TBuilder Reset();
        TBuilder SetName(string name);
        TBuilder SetHeight(string height);
        TBuilder SetBodyType(string bodyType);
        TBuilder SetHairColor(string hairColor);
        TBuilder SetEyeColor(string eyeColor);
        TBuilder SetClothes(string clothes);
        TBuilder AddInventoryItem(string item);
        TBuilder AddDeed(string deed);
        Character Build();
    }
}
