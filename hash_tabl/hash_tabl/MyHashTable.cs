using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hash_tabl
{
    internal class MyHashTable<Tkey, TValue> : IEnumerable<HashItem<Tkey, TValue>>
    {
        HashItem<Tkey, TValue>[] hash_mass = new HashItem<Tkey, TValue>[0];
        public void Add(Tkey key, TValue value)
        {
            int hash = HashFunction(key);
            HashItem<Tkey, TValue> newItem = new HashItem<Tkey, TValue> { Key = key, Value = value, Hash = hash};


            if (hash >= hash_mass.Length)
                Array.Resize(ref hash_mass, hash+1);

            if (hash_mass[hash] == null)
                hash_mass[hash] = newItem;
            else
                Add(hash_mass[hash], newItem);
        }
        private void Add(HashItem<Tkey, TValue> root, HashItem<Tkey, TValue> newItem)
        {
            if (root.Child == null)
                root.Child = newItem;
            else
                Add(root.Child, newItem);
        }
        public TValue Find(Tkey key) 
        {
            int hash = HashFunction(key);
            if (hash >= hash_mass.Length || hash_mass[hash] == null)
                throw new Exception("Эл-т не найден");
            if (hash_mass[hash].Key.Equals(key))
                return hash_mass[hash].Value;
            else
                return Find(hash_mass[hash].Child, key);
        }
        private TValue Find(HashItem<Tkey, TValue> root, Tkey key)
        {
            if (root == null)
                throw new Exception("Эл-т не найден");
            if (root.Key.Equals(key))
                return root.Value;
            else
                return Find(root.Child, key);
        }
        public void Delete(Tkey key) 
        {
            int hash = HashFunction(key);
            if (hash_mass[hash].Key.Equals(key))
                if (hash_mass[hash].Child == null)
                {
                    hash_mass[hash] = null;
                    if (hash == hash_mass.Length - 1)
                    {
                        int new_size = 0;
                        foreach (var item in hash_mass)
                        {
                            if (item != null)
                                new_size = item.Hash;
                        }
                        Array.Resize(ref hash_mass, new_size);
                        Console.WriteLine(hash_mass.Length);
                    }
                }
                else
                    hash_mass[hash] = hash_mass[hash].Child;
            else
                Delete(hash_mass[hash].Child, key);
        }
        private void Delete(HashItem<Tkey, TValue> root, Tkey key)
        {
            if (root.Key.Equals(key))
                if (root.Child == null)
                    root = null;
                else
                    root = root.Child;
            else
                Delete(root.Child, key);
        }
        public int HashFunction(Tkey key)
        {
            string str = key.ToString();
            int hash = 0;

            for (int i = 0; i < str.Length; ++i)
                hash += ((int)str[i]);
            hash /= 45;

            return hash;
        }
        public List<HashItem<Tkey, TValue>> ToList()
        {
            List<HashItem<Tkey, TValue>> list = new List<HashItem<Tkey, TValue>>();
            foreach (var item in hash_mass)
            {
                HashItem<Tkey, TValue> root = item;
                while (root != null)
                {
                    list.Add(root);
                    root = root.Child;
                }
            }
            return list;
        }

        public IEnumerator<HashItem<Tkey, TValue>> GetEnumerator()
        {
            foreach (var item in ToList())
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
