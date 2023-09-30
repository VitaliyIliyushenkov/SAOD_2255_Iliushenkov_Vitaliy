using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_app
{ 
    public class MyVector<T> : IEnumerable<T>
    {
        T[] _data;
        int size;
        public MyVector()
        {
            Capacity = 1;
            Size = 0;
        }
        public MyVector(int max_size)
        {
            Capacity = max_size;
            Size = 0;
        }

        public int Size
        {
            get { return size; }
            private set { size = value; }
        }
        public int Capacity
        {
            get { return _data.Length; }
            private set { Array.Resize(ref _data, value); }
        }

        public void Add(T item)
        {
            if (Size == Capacity) Capacity *= 2;
                
            _data[Size] = item;
            Size++;
           
        }
        
        public T SetValue(int item)
        {
            if(item < 0 ||  item > Size) throw new Exception("Индекс вне массива");
            return _data[item];
        }

        public void Resize(int newSize)
        {
            if (newSize <= 0) throw new Exception("Неверное число");

            if (newSize < Size) Size = newSize;
            Capacity = newSize;
        }

        public void Reserve(int newCapacity)
        {
            if (newCapacity <= 0) throw new Exception("Неверное число");

            if (newCapacity < Size)
            {
                    Size = newCapacity;
                    Capacity = Size;
            }
            else Capacity = newCapacity;
        }

        public void ShrinkToFit()
        {
            Capacity = Size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyVectEnum<T>(_data, Size);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

