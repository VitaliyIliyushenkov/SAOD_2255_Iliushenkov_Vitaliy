using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace list_app
{
    internal class MyList<T> : IEnumerable<T>
    {
        ListNode<T> First;
        ListNode<T> Last;

        public T this[int index]
        {
            get 
            {
                int i = 0;
                ListNode<T> item = First;
                while (item != null)
                {
                    if (i == index)
                        return item.Value;
                    item = item.Next;
                    i++;
                }
                throw new Exception("Неверный индекс!");
            }

            set 
            {
                ListNode<T> item = First;
                int i = 0;
                while (item != null)
                {
                    if (i == index)
                        item.Value = value;
                    item = item.Next;
                    i++;
                }
                if(index > i)
                    throw new Exception("Неверный индекс!");
            }
        }

        public void Append(T value)
        {
            if (First == null || Last == null)
            {
                Last = new ListNode<T>() { Value = value };
                First = Last; 
            }
            else
            {
                Last = new ListNode<T>() { Value = value, Prev = Last };
                Last.Prev.Next = Last;
            }      
        }

        public void Prepend(T value)
        {
            if (First == null || Last == null)
            {
                First = new ListNode<T>() { Value = value };
                Last = First;
            }
            else
            {
                First = new ListNode<T>() { Value = value, Next = First };
                First.Next.Prev = First;
            }
        }

        public bool Insert(int index, T value)
        {
            int i = 0;
            ListNode<T> item = First;
            while (item != null)
            {
                if (i == index)
                {
                    item.Value = value;
                    return true;
                }
                item = item.Next;
                i++;
            }
            throw new Exception("Неверный индекс!");
        }

        public T[] ToArray()
        {
            T[] _data = new T[] { };
            ListNode<T> item = First;
            int i = 0;
            while (item != null)
            {
                Array.Resize(ref _data, i+1);
                _data[i] = item.Value;
                item = item.Next;
                i++;
            }
            return _data;
        }

        public int Find(T value)
        {
            ListNode<T> item = First;
            int i = 0;
            while (item != null)
            {
                if (item.Value.Equals(value))
                    return i;
                item = item.Next;
                i++;
            }
            throw new Exception("Эл-т не найден!");
        }

        public bool Remove(T value)
        {
            ListNode<T> item = First;
            while (item != null)
            {
                if (item.Value.Equals(value))
                {
                    if (First == Last)
                    {
                        throw new Exception("Это последний эл-т!");
                    }
                    
                    if (item == Last)
                    {
                        Last = item.Prev;
                        Last.Next = null;
                    }  
                    else if (item == First)
                    {
                        First = item.Next;
                        First.Prev = null;
                    }
                    else
                    {
                        item.Prev.Next = item.Next;
                        item.Next.Prev = item.Prev;
                    }
                    return true;
                }
                item = item.Next;
            }
            throw new Exception("Эл-т не найден!");
        }

        public T At(int index)
        {
            int i = 0;
            ListNode<T> item = First;
            while (item != null)
            {
                if(i == index)
                    return item.Value;
                item = item.Next;
                i++;
            }
            throw new Exception("Неверный индекс!");
        }

        public bool RemoveAt(int index)
        {
            int i = 0;
            ListNode<T> item = First;
            while (item != null)
            {
                if (i == index)
                {
                    if(First == Last)
                    {
                        throw new Exception("Это последний эл-т!");
                    }

                    if (item == Last)
                    {
                        Last = item.Prev;
                        Last.Next = null;
                    }
                    else if (item == First)
                    {
                        First = item.Next;
                        First.Prev = null;
                    }
                    else
                    {
                        item.Prev.Next = item.Next;
                        item.Next.Prev = item.Prev;
                    }
                    return true;
                }
                item = item.Next;
                i++;
            }
            throw new Exception("Неверный индекс!");
        }

        public void Sort() { }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(First);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
