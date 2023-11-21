using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace treee
{
    internal class MyBSTDictionary<Tkey, TValue> : IEnumerable<(Tkey, TValue)>
    {
        List<Tkey> Keys = new List<Tkey>();
        List<TValue> Values = new List<TValue>();
        public Tkey this[int index]
        {
            get{return Keys[index];} set{}
        }
        public void Add(Tkey key, TValue value)
        {
            if (Keys.Contains(key))
                throw new Exception("Эл-т с таким ключем уже есть!");
            Keys.Add(key); Values.Add(value);
        }
        public bool Remove(Tkey key)
        {
            if (Keys.Contains(key))
            {
                Values.RemoveAt(Keys.IndexOf(key));
                Keys.Remove(key);
                return true;
            }
            else return false;
        }
        public TValue ValueByKey(Tkey key)
        {
            if (!ContainsKey(key))
                throw new Exception("Эл-т с таким ключем не найден!");
            return Values[Keys.IndexOf(key)];
        }
        public Tkey KeyByValue(TValue value)
        {
            if (!ContainsValue(value))
                throw new Exception("Эл-т с таким значением не найден!");
            return Keys[Values.IndexOf(value)];
        }
        public bool ContainsKey(Tkey key)
        {
            return Keys.Contains(key);

        }
        public bool ContainsValue(TValue value)
        {
            return Values.Contains(value);
        }
        public void Clear()
        {
            Keys.Clear(); Values.Clear();
        }

        public IEnumerator<(Tkey, TValue)> GetEnumerator()
        {
            for (int i = 0; i < Keys.Count; i++)
            {
                yield return (Keys[i], Values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }

    }
}
