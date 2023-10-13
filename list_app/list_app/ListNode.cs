using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace list_app
{
    internal class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
        public ListNode<T> Prev { get; set; }

    }
}
