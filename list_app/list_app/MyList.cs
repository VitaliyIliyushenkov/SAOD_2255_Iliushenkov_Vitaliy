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
            get {return At(index);}
            set { SetValue(index, value);}
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

        public bool SetValue(int index, T value)
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

        public bool Insert(int index, T value)
        {
            int i = 0;
            if(First == null || Last == null)
            {
                Last = new ListNode<T>() { Value = value };
                First = Last;
                return true;
            }
            ListNode<T> item = First;
            while (item != null)
            {
                if (i == index)
                {
                    ListNode<T> new_item = new ListNode<T>() { Value = value, Next = item, Prev = item.Prev};
                    if(item.Prev == null)
                    {
                        First = new_item;
                        item.Prev = new_item;   
                    }
                    else
                    {
                        item.Prev.Next = new_item;
                        item.Prev = new_item;
                    }
                    
                    return true;
                }
                item = item.Next;
                i++;
            }
            throw new Exception("Неверный индекс!");
        }

        public T[] ToArray()
        {
            T[] _data = new T[Size];
            ListNode<T> item = First;
            int i = 0;
            while (item != null)
            {
                _data[i] = item.Value;
                item = item.Next;
                i++;
            }
            return _data;
        }

        public int Size 
        {
            get 
            {
                ListNode<T> item = First;
                int i = 0;
                while (item != null)
                {
                    item = item.Next;
                    i++;
                }
                return i;
            }
            set { }
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
                        First = null; Last = null;
                        return true;
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
            return new MyListEnumerator<T>(First, Last);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
