using System;
using System.Collections.Generic;

namespace ACS
{
    public class ACSEngine
    {
        private readonly SortedDictionary<Type, Dictionary<string, Secureable>> _secureables;

        public ACSEngine()
        {
            _secureables = new SortedDictionary<Type, Dictionary<string, Secureable>>();
        }

        public void Add(Secureable item)
        {
            var dictionary = GetDictionary(item);
            if (!dictionary.ContainsKey(item.Id))
            {
                dictionary.Add(item.Id, item);
            }
        }

        public void Remove(Secureable item)
        {
            var dictionary = GetDictionary(item);
            if (dictionary.ContainsKey(item.Id))
                dictionary.Remove(item.Id);
            if (dictionary.Count == 0)
                _secureables.Remove(item.GetType());
        }

        public Dictionary<string, Secureable> Items<T>()
        {
            return GetDictionary(typeof(T));
        }

        private Dictionary<string, Secureable> GetDictionary(Type type)
        {
            if (!_secureables.ContainsKey(type))
                _secureables.Add(type, new Dictionary<string, Secureable>());
            return _secureables[type];
        }

        private Dictionary<string, Secureable> GetDictionary(Secureable item)
        {
            return GetDictionary(item.GetType());
        }
    }
}
