using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Environment;
using static System.Math;


namespace Calculator
{
    public class Patterns
    {
        // patterns
        public static Regex space = new Regex(@"\G(\s+)");
        //public static Regex lineComment = new Regex(@"\G//[^"+NewLine+"]"+NewLine+"");
        public static Regex identifier = new Regex(@"\G([a-zA-z_]+[0-9]*)+");
        public static Regex keywords = new Regex(@"\G(del|print)");
        public static Regex digits = new Regex(@"\G[0-9]+");
        public static Regex number = new Regex(@"\G([+-]?[0-9]+(\.[0-9]+)?)");
        public static Regex letters = new Regex(@"\G([a-zA-z_]+)");
        public static Regex operators = new Regex(@"\G(\+|\-|\*|/|%|\(|\))");

        public static IToken Match(string value , int index)
        {
            Match matcher = null;
            
            // space
            matcher = space.Match(value, index);
            if (matcher.Success)
                return new Token(matcher.Value, TokenType.Skip);
            
            // identifier and keywords
            matcher = identifier.Match(value, index);
            if (matcher.Success)
            {
                if (keywords.IsMatch(matcher.Value))
                    return new Token(matcher.Value, TokenType.Keyword);
                else
                    return new Token(matcher.Value, TokenType.Identifier);

            }

            // number
            matcher = number.Match(value, index);
            if (matcher.Success)
                return new Token(matcher.Value, TokenType.Number);


            // operator
            matcher = operators.Match(value, index);
            if (matcher.Success)
                return new Token(matcher.Value, TokenType.Operator);
            // Error
            return null;

        }

    }
}