using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Utility
{
    public class Number : IComparable<Number>
    {

        public int Value { get; set; }

        public Number()
        {
            Value = 0;
        }

        public Number(int value)
        {
            Value = value;
        }

        public int CompareTo(Number other)
        {
            return Value.CompareTo(other?.Value);
        }

        public override bool Equals(object obj)
        {
            return obj is Number number &&
                   Value == number.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
