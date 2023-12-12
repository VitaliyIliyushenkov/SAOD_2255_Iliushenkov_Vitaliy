using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public T this[int index]
        {
            get { return At(index); }
            set { SetValue(index, value); }
        }

        public T At(int index) 
        {
            return _data[index]; 
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
        
        public void SetValue(int index, T item)
        {
            if(index < 0 ||  index > Size) throw new Exception("Индекс вне массива");
            _data[index] = item;
        }

        public void Resize(int newSize)
        {
            if (newSize <= 0) throw new Exception("Неверное число");

            if (newSize < Size) Size = newSize;
            Capacity = newSize * 2;
        }

        public void Reserve(int newCapacity)
        {
            if (newCapacity <= 0 || newCapacity < Size)
                throw new Exception("Неверное число");
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

