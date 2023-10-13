using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_app
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        ListNode<T> First;
        ListNode<T> Now;

        public MyListEnumerator(ListNode<T> first)
        {
            Now = first;
        }
        public T Current
        {
            get { return Now.Value; }
            set { Now.Value = value; }
        }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (First == null)
            {
                First = Now;
                return true;
            }
            else if (Now.Next != null )
            {
                Now = Now.Next;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            Now = First;
            First = null;
        }
    }
}
