using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_tabl
{
    internal class HashItem<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public int Hash { get; set; }
        public HashItem<TKey, TValue>  Child { get; set; }
    }
}
