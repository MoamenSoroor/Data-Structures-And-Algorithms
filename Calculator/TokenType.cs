using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public enum TokenType
    {
        Identifier = 1, Keyword, Operator, Number,Error,Skip
    }
}