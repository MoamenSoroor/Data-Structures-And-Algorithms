using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryNode<T> where T: IComparable<T>
    {
        public BinaryNode()
        {
            Value = default;
            Left = default;
            Right = default;
        }

        public BinaryNode(T value)
        {
            Value = value;
        }

        public BinaryNode(T value, BinaryNode<T> left, BinaryNode<T> right) : this(value)
        {
            Left = left;
            Right = right;
        }

        public T Value { get; set; }

        public BinaryNode<T> Left { get; set; }
        public BinaryNode<T> Right { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BinaryNode<T> node &&
                   EqualityComparer<T>.Default.Equals(Value, node.Value);
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<T>.Default.GetHashCode(Value);
        }

        public static bool operator ==(BinaryNode<T> left, BinaryNode<T> right)
        {
            return EqualityComparer<BinaryNode<T>>.Default.Equals(left, right);
        }

        public static bool operator !=(BinaryNode<T> left, BinaryNode<T> right)
        {
            return !(left == right);
        }
    }
}
