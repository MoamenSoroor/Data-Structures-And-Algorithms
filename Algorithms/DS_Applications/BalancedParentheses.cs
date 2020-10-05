using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Utility;

namespace Algorithms.DS_Applications
{
    public class BalancedParentheses
    {
        // Test Method
        public static void Test()
        {
            Console.WriteLine(" ----------- Check Balanced Parentheses ----------- ");
            BalancedParentheses balanced = new BalancedParentheses();

            Utils.InputLoop(input => balanced.IsBalanced(input).ToString(), "Enter Expression: ");
        }

        bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var ch in expression)
            {
                if (IsOpenParentheses(ch))
                    stack.Push(ch);
                else if (IsCloseParentheses(ch))
                    if (stack.Count == 0 || !IsPairParentheses(stack.Peek(), ch))
                        return false;
                    else stack.Pop();


            }

            return stack.Count == 0;
        }


        public bool IsOpenParentheses(char ch)
        {
            return "([{".ToCharArray().Any(par => ch == par);
        }

        public bool IsCloseParentheses(char ch)
        {

            return ")]}".ToCharArray().Any(par => ch == par);

        }

        public bool IsPairParentheses(char open, char close)
        {

            return "{} () []".Split().Any(pair => pair == $"{open}{close}" || pair == $"{close}{open}");

        }






    }
}
