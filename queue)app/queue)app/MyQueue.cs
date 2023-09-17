using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace queue_app
{
    public class MyQueue<T> 
    {
        private int currentIn = 0;
        private int currentOut = 0;
        private int count;
        private T[] _Array;

        public MyQueue(int Size)
        {
            Capacity = Size;
            Count = 0;
        }
        private int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int Capacity
        {
            get { return _Array.Length; }
            set { _Array = new T[value]; }
        }
        private bool IsFull()
        {
            return Count == Capacity;
        }
        private bool IsEmpty()
        {
            return Count == 0;
        }
        public void Enqueue(T item)
        {
            if (IsFull())
                throw new Exception();
            
            _Array[currentOut++] = item;
            if (currentOut == Capacity)
                currentOut = 0;
            Count++;

        }
        public T Dequeue()
        {
            if (IsEmpty())
                throw new Exception();
 
            T value = _Array[currentIn++];
            if (currentIn == Capacity)
                currentIn = 0;
            Count--;

            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new Exception();
            T value = _Array[currentIn];
            return value;
        }
        public T[] ToArray()
        {
            var items = new T[Count];
            int j = 0;
            int i = currentIn;

            while (j!=Count)
            {
                if (i == Capacity)
                    i = 0;

                items[j] = _Array[i];

                i++;
                j++;
            }

            return items;
        }
    }
}
