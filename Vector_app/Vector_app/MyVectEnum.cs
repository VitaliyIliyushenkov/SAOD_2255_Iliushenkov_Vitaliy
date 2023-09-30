using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_app
{
    public class MyVectEnum<T> : IEnumerator<T>
    {
        T[] _data;
        int currentIndex = -1;
        int size;

        public MyVectEnum(T[] data, int size)
        { 
            _data = data; this.size = size;
        }
        
        public T Current { get { return _data[currentIndex]; } }

        object IEnumerator.Current{ get{ return Current; } }

        public void Dispose() {}

        public bool MoveNext()
        {
            if (currentIndex < size - 1)
            {
                currentIndex++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    } 
}
