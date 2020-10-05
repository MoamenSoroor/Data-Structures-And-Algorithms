using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    [Serializable]
    public class SyntaxErrorException : Exception
    {

        public SyntaxErrorException() { }
        public SyntaxErrorException(string message) : base(message) { }
        public SyntaxErrorException(string message, Exception inner) : base(message, inner) { }
        protected SyntaxErrorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public SyntaxErrorException(string message, int index) : base(message)
        {
            Index = index;
            UnderMarkString = "".PadLeft(Index) + "^";
        }

        public int Index { get; }
        public string UnderMarkString { get; }
    }
}
