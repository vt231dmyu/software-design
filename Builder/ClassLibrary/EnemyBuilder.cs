using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EnemyBuilder : IEnemyBuilder
    {
        private Character _character = new Character { Type = "Enemy" };

        public EnemyBuilder()
        {
            Reset();
        }

        public IEnemyBuilder Reset()
        {
            _character = new Character { Type = "Enemy" };
            return this;
        }

        public IEnemyBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public IEnemyBuilder SetHeight(string height)
        {
            _character.Height = height;
            return this;
        }

        public IEnemyBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public IEnemyBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public IEnemyBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public IEnemyBuilder SetClothes(string clothes)
        {
            _character.Clothes.Add(clothes);
            return this;
        }

        public IEnemyBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public IEnemyBuilder AddDeed(string deed)
        {
            _character.Deeds.Add("Evil: " + deed);
            return this;
        }

        public IEnemyBuilder DestroySomething(string something)
        {
            AddDeed("[destroyed] " + something);
            return this;
        }

        public IEnemyBuilder KillSomeone(string someone)
        {
            AddDeed("[killed] " + someone);
            return this;
        }

        public Character Build()
        {
            Character result = _character;
            Reset();
            return result;
        }
    }
}
