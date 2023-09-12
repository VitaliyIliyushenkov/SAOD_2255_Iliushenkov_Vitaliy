using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_app
{
    public class MyStack<T>
    {
        private int _currentIndex; // текущий размер стека
        private T[] _dataArray; // данные стека
       
        public MyStack(int stackMaxSize)
        {
            Capacity = stackMaxSize;
            Count = 0;
        }

        // метод для получения размера стека
        private int Count
        {
            get { return _currentIndex; }
            set { _currentIndex = value; }
        }
        // метод для получения вместимости стека
        private int Capacity
        {
            get { return _dataArray.Length; }
            set { _dataArray = new T[value]; }
        }

        // добавление нового элемента
        public void Push(T item)
        {
            if (_currentIndex == Capacity)
            {
                throw new Exception();
            }

            _dataArray[_currentIndex] = item;
            _currentIndex++;
        }

        // чтение главного элемента стека без удаления
        public T Peek()
        {
            // если данных нет, выбрасываем исключение
            if (Count == 0)
            {
                throw new Exception();
            }

            return _dataArray[_currentIndex - 1];
        }

        // извлечение элемента
        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception();
            }
            var item = Peek();
            _currentIndex--;

            return item;
        }

        // очистка стека
        public void Clear()
        {
            _dataArray = new T[Capacity];
            _currentIndex = 0;
        }

        public T[] Values()
        {
            var items = new T[Count];
            for (int i = Count-1; i >= 0; i--)
            {
                items[Count-i-1] = _dataArray[i];
            }
            return items;
        }
    }
}
