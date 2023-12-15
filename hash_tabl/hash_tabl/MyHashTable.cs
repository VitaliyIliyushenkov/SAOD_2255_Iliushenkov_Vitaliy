using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hash_tabl
{
    internal class MyHashTable<Tkey, TValue> : IEnumerable<KeyValuePair<Tkey, TValue>>
    {
        List<KeyValuePair<Tkey, TValue>>[] hash_mass = new List<KeyValuePair<Tkey, TValue>>[10000]; //2,147,483,648
        public void Add(Tkey key, TValue value)
        {
            int hash = Math.Abs(key.GetHashCode()) % 10000;

            if (hash_mass[hash] == null)
                hash_mass[hash] = new List<KeyValuePair<Tkey, TValue>>();
            hash_mass[hash].Add(new KeyValuePair<Tkey, TValue>(key, value));
        }

        public KeyValuePair<Tkey, TValue> Find(Tkey key)
        {
            int hash = Math.Abs(key.GetHashCode()) % 10000;
            if (hash_mass[hash] == null)
                throw new Exception("Эл-т не найден");
            foreach (var item in hash_mass[hash])
            {
                if(item.Key.Equals(key))
                    return item;
            }
            throw new Exception("Эл-т не найден");
        }

        public void Delete(Tkey key)
        {
            int hash = Math.Abs(key.GetHashCode()) % 10000;
            hash_mass[hash].Remove(Find(key));
        }

        public IEnumerator<KeyValuePair<Tkey, TValue>> GetEnumerator()
        {
            return new MyHashEnum<Tkey, TValue>(hash_mass);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}