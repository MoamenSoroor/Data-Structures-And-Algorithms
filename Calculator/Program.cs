using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----------- Check Balanced Parentheses ----------- ");
            InputProcessor inputProcessor = new InputProcessor();
            Utility.InputLoop(input => inputProcessor.Process(input), "> ");

        }

    }
}
