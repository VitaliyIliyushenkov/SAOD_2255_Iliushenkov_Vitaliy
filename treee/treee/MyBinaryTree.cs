using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace treee
{
    internal class MyBinaryTree<Tkey, TValue> : MyBSTDictionary<Tkey, TValue>, IEnumerable<TValue> where TValue : IComparable<TValue>
        //если a>b то 1,если a<b то -1, где a.CompareTo(b)
    {
        MyTreeNode<TValue> root;

        public void Insert(Tkey key, TValue value)
        {
            MyTreeNode<TValue> newNode = new MyTreeNode<TValue>() { Value = value };
            Add(key, value);
            if (root == null)
                root = new MyTreeNode<TValue>() { Value = value };
            else
                Insert(root, newNode);
        }

        private void Insert(MyTreeNode<TValue> parent, MyTreeNode<TValue> new_node)
        {
            if (new_node.Value.CompareTo(parent.Value) == -1)
            {
                if (parent.Left == null)
                {
                    parent.Left = new_node;
                    new_node.Parent = parent;
                }
                else Insert(parent.Left, new_node);
            }
            else if (new_node.Value.CompareTo(parent.Value) == 1)
            {
                if (parent.Right == null)
                {
                    parent.Right = new_node;
                    new_node.Parent = parent;
                }
                else Insert(parent.Right, new_node);
            }
            else { }
        }

        public void Delete(TValue value)
        {
            Remove(KeyByValue(value));
            if (root == null)
                throw new Exception("Пустое дерево");
            else Delete(root, value);
        }
        private void Delete(MyTreeNode<TValue> item, TValue value)
        {
            if (item.Value.CompareTo(value) == 1)
            {
                if (item.Left == null) throw new Exception("Эл-т не найден");
                else Delete(item.Left, value);
            }
            else if (item.Value.CompareTo(value) == -1)
            {
                if (item.Right == null) throw new Exception("Эл-т не найден");
                else Delete(item.Right, value);
            }
            else
            {
                if(item.Left == null && item.Right == null)
                {
                    if (item.Parent.Value.CompareTo(item.Value) == 1)
                        item.Parent.Left = null;
                    if (item.Parent.Value.CompareTo(item.Value) == -1)
                        item.Parent.Right = null;
                    item.Parent = null;
                }
                else if (item.Left == null || item.Right == null)
                {
                    if (item.Parent.Value.CompareTo(item.Value) == 1)
                    {
                        if (item.Left == null)
                        {
                            item.Parent.Left = item.Right;
                            item.Right.Parent = item.Parent;
                        }
                        else
                        {
                            item.Parent.Left = item.Left;
                            item.Left.Parent = item.Parent;
                        }
                    }
                    if (item.Parent.Value.CompareTo(item.Value) == -1)
                    {
                        if (item.Left == null)
                        {
                            item.Parent.Right = item.Right;
                            item.Right.Parent = item.Parent;
                        }
                        else
                        {
                            item.Parent.Right = item.Left;
                            item.Left.Parent = item.Parent;
                        }
                    }
                }
                else
                {
                    MyTreeNode<TValue> max_node = item.Left;
                    while(max_node.Right != null)
                    {
                        max_node = max_node.Right;
                    }
                    if (max_node.Parent.Value.CompareTo(max_node.Value) == 1)
                        max_node.Parent.Left = null;
                    if (max_node.Parent.Value.CompareTo(max_node.Value) == -1)
                        max_node.Parent.Right = null;
                    max_node.Parent = null;
                    item.Value = max_node.Value;
                }
                return;
            }
        }

        public bool Contains(TValue value)
        {
            if (root == null)
                throw new Exception("Пустое дерево");
            else return Contains(root, value);
        }
        private bool Contains(MyTreeNode<TValue> item, TValue value)
        {
            if (item.Value.CompareTo(value) == 1)
            {
                if (item.Left == null) return false;
                else return Contains(item.Left, value);
            }
            else if (item.Value.CompareTo(value) == -1)
            {
                if (item.Right == null) return false;
                else return Contains(item.Right, value);
            }
            else { return true; }
        }

        public List<MyTreeNode<TValue>> CLR()
        {
            if (root == null)
                throw new Exception("Пустое дерево");
            return CLR(root);
        }
        private List<MyTreeNode<TValue>> CLR(MyTreeNode<TValue> item)
        {
            List<MyTreeNode<TValue>> sequence = new List<MyTreeNode<TValue>>{item};
            if (item.Left != null)
                sequence.AddRange(CLR(item.Left));
            if (item.Right != null)
                sequence.AddRange(CLR(item.Right));
            return sequence;
        }

        public List<MyTreeNode<TValue>> LCR()
        {
            if (root == null)
                throw new Exception("Пустое дерево");
            return LCR(root);
        }
        private List<MyTreeNode<TValue>> LCR(MyTreeNode<TValue> item)
        {
            List<MyTreeNode<TValue>> sequence = new List<MyTreeNode<TValue>>();
            if (item.Left != null)
                sequence.AddRange(LCR(item.Left));
            sequence.Add(item);
            if (item.Right != null)
                sequence.AddRange(LCR(item.Right));
            return sequence;
        }

        public List<MyTreeNode<TValue>> RCL()
        {
            if (root == null)
                throw new Exception("Пустое дерево");
            return RCL(root);
        }
        private List<MyTreeNode<TValue>> RCL(MyTreeNode<TValue> item)
        {
            List<MyTreeNode<TValue>> sequence = new List<MyTreeNode<TValue>>();
            if (item.Right != null)
                sequence.AddRange(RCL(item.Right));
            sequence.Add(item);
            if (item.Left != null)
                sequence.AddRange(RCL(item.Left));
            return sequence;
        }

        public List<MyTreeNode<TValue>> Across()
        {
            if(root == null)
                throw new Exception("Пустое дерево");
            List<MyTreeNode<TValue>> sequence = new List<MyTreeNode<TValue>>();
            Queue<MyTreeNode<TValue>> queue = new Queue<MyTreeNode<TValue>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                MyTreeNode<TValue> node = queue.Dequeue();
                sequence.Add(node);
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
            return sequence;
        }

        public List<TValue> ToList()
        {
            List<TValue> list = new List<TValue>();
            foreach (var item in LCR())
            {
                list.Add(item.Value);
            }
            return list;
        }

        public new IEnumerator<TValue> GetEnumerator()
        {
            foreach (var item in LCR())
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}