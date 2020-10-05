using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T> where T: IComparable<T>
    {
        public BinaryNode<T> Root { get; private set; }


        public BinarySearchTree()
        {

        }

        public BinarySearchTree(BinaryNode<T> root)
        {
            Root = root;
        }

        // 
        public bool IsEmpty()
        {
            return Root == null;
        }

        // 
        public bool Contains(T item)
        {
            return true;
        }

        // 
        public bool SearchWithRecursion(T item)
        {
            return true;
        }

        // 
        public void Add(T item)
        {
            var  node = new BinaryNode<T>();
            node.Value = item;
            node.Left = null;
            node.Right = null;

            if (Root == null)
            {
                Root = node;
                return;
            }

            var  current = Root;
            var next = current;

            if (node.Value.CompareTo(current.Value) > 0)
                next = current.Right;
            else
                next = current.Left;

            while (next != null)
            {
                if (node.Value.CompareTo(current.Value) > 0)
                    next = current.Right;
                else
                    next = current.Left;
                current = next;
            }

            




            // 
        }

        // 
        public void Remove(T item)
        {

        }

        // 
        public T Min()
        {
            return default;
        }

        // 
        public T Max()
        {
            return default;
        }

        // 
        public void InorderTraversal()
        {

        }

        // 
        public void PreorderTraversal()
        {

        }

        // 
        public void PostorderTraversal()
        {

        }

        // 
        public int TreeHeight()
        {
            return 0;
        }

        // 
        public int TreeNodeCount()
        {
            return 0;
        }

        // 
        public int TreeLeavesCount()
        {
            return 0;
        }

        // 
        public void Clear()
        {

        }

        // 

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
