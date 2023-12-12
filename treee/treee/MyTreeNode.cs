using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treee
{
    internal class MyTreeNode<T>
    {
        public T Value { get; set; }
        public MyTreeNode<T> Parent { get; set; }
        public MyTreeNode<T> Right { get; set; }
        public MyTreeNode<T> Left { get; set; }
    }
}
