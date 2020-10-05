using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Utility
    {

        public static string Indent = " ";

        public static void InputLoop( Func<string,string> ProcessInput, string title)

        {
            bool end = false;
            do
            {
                Console.Write(title);
                string text = Console.ReadLine();
                if (text.Equals("exit", StringComparison.OrdinalIgnoreCase)
                    || text.Trim().Equals(string.Empty))
                    end = true;
                else
                {
                    string result = ProcessInput(text);
                    Console.WriteLine(result);
                    Console.WriteLine();
                }
                
            } while (!end);
        }
    }
}
