using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class Token : IToken
    {
        public Token(string lexeme, TokenType tokenType)
        {
            this.Type = tokenType;
            this.Lexeme = lexeme;
        }

        public TokenType Type { get; }

        public string Lexeme{ get;  }

        public override string ToString()
        {
            return $@"Token[ Type={Type} , Value=""{Lexeme}"" ]";
        }
    }
}
