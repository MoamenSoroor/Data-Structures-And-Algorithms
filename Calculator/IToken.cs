﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public interface IToken
    {
        TokenType Type { get; }
        string Lexeme { get; }
    }
}