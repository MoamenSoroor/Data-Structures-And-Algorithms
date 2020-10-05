using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class LexicalAnalyzer : IEnumerable<IToken>
    {

        public string Input { get; private set; } = "";
        public int Index { get; private set; } = 0;

        public LexicalAnalyzer()
        {

        }

        public LexicalAnalyzer(string input)
        {
            Input = input?? "";

        }

        public void SetInput(string input)
        {
            Input = input ?? "";
            Index = 0;
        }


        public IToken NextToken()
        {
            if (HasNext())
            {
                IToken token = Patterns.Match(Input, Index);
                if (token == null)
                    throw new SyntaxErrorException($"  Lexical Error At Index = {Index}", Index);
                else
                {
                    Index += token.Lexeme.Length;
                    return token;
                }
            }
            else
                throw new Exception("  Error, No more Lexemes in input");
            
                
        }

        public bool HasNext()
        {
            return Index < Input.Length;
        }

        IEnumerator<IToken> IEnumerable<IToken>.GetEnumerator()
        {
            while (HasNext())
            {
                yield return NextToken();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            while (HasNext())
            {
                yield return NextToken();
            }
        }
    }
}