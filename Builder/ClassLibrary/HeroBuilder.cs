using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HeroBuilder : IHeroBuilder
    {
        private Character _character = new Character { Type = "Hero" };

        public HeroBuilder()
        {
            Reset();
        }

        public IHeroBuilder Reset()
        {
            _character = new Character { Type = "Hero" };
            return this;
        }

        public IHeroBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public IHeroBuilder SetHeight(string height)
        {
            _character.Height = height;
            return this;
        }

        public IHeroBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public IHeroBuilder SetClothes(string clothes)
        {
            _character.Clothes.Add(clothes);
            return this;
        }

        public IHeroBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public IHeroBuilder AddDeed(string deed)
        {
            _character.Deeds.Add("Good: " + deed);
            return this;
        }

        public IHeroBuilder ProtectSomething(string something)
        {
            return AddDeed("[protected] " + something);
        }

        public IHeroBuilder SaveSomeone(string someone)
        {
            return AddDeed("[saved] " + someone);
        }

        public Character Build()
        {
            Character result = _character;
            Reset();
            return result;
        }
    }
}
