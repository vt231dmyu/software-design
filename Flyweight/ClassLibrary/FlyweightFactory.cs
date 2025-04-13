using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class FlyweightFactory
    {
        private static Dictionary<string, Flyweight> _cache = new Dictionary<string, Flyweight>();

        public static Flyweight GetFlyweight(string tagName, DisplayType display, ClosingType closing)
        {
            string key = $"{tagName}|{display}|{closing}";

            if (!_cache.ContainsKey(key))
            {
                _cache[key] = new Flyweight(tagName, display, closing);
            }

            return _cache[key];
        }

        public static int Count
        {
            get { return _cache.Count; }
        }
    }
}
