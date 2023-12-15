using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_tabl
{
    public class MyHashEnum<Tkey, TValue> : IEnumerator<KeyValuePair<Tkey, TValue>>
    {
        List<KeyValuePair<Tkey, TValue>> _hash_list = new List<KeyValuePair<Tkey, TValue>>();
        int currentIndex = -1;

        public MyHashEnum(List<KeyValuePair<Tkey, TValue>>[] hash_mass) 
        {
            for (int i = 0; i < hash_mass.Length; i++)
            {
                if (hash_mass[i] != null)
                {
                    foreach (var item in hash_mass[i])
                    {
                        _hash_list.Add(item);
                    }
                }
            }

        }
        public KeyValuePair<Tkey, TValue> Current
        {
            get { return _hash_list[currentIndex]; }
            set { _hash_list[currentIndex] = value; }
        }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose() {}

        public bool MoveNext()
        {
            if (currentIndex < _hash_list.Count-1)
            {
                currentIndex++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
