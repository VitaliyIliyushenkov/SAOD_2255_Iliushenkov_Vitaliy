using System;
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
        private int _stackMaxSize; //максимальное количество элементов в стеке
                                   // конструктор
        public MyStack(int stackMaxSize)
        {
            _dataArray = new T[stackMaxSize];
            _currentIndex = 0;
            _stackMaxSize = stackMaxSize;
        }

        // метод для получения размера стека
        public int Count()
        {
            return _currentIndex;
        }
        // метод для получения вместимости стека
        public int Capacity()
        {
            return _stackMaxSize;
        }

        // добавление нового элемента
        public void Push(T item)
        {
            // если текущий размер равен максимальному, то смещаем стек на одну позицию
            // при этом первый элемент удаляется
            if (_currentIndex == _stackMaxSize)
            {
                RebuildData();
            }

            _dataArray[_currentIndex] = item;
            _currentIndex++;
        }

        // чтение главного элемента стека без удаления
        public T Peek()
        {
            // если данных нет, выбрасываем исключение
            if (Count() == 0)
            {
                throw new Exception("Stack is empty");
            }

            return _dataArray[_currentIndex - 1];
        }

        // извлечение элемента
        public T Pop()
        {
            var item = Peek();
            _currentIndex--;
            return item;
        }

        // очистка стека
        public void Clear()
        {
            _dataArray = new T[_stackMaxSize];
            _currentIndex = 0;
        }

        private void RebuildData()
        {
            var newData = new T[_stackMaxSize];
            for (var i = 1; i < _dataArray.Length; i++)
            {
                newData[i - 1] = _dataArray[i];
            }

            _dataArray = newData;
            _currentIndex = _stackMaxSize - 1;
        }

        public T Value(int i)
        {
            return _dataArray[i];
        }
    }
}
