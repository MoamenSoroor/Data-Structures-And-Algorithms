using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
namespace Calculator
{
    public class InputProcessor
    {
        private LexicalAnalyzer analyzer = new LexicalAnalyzer();

        
        public string Process(string input)
        {
            analyzer.SetInput(input);

            StringBuilder result = new StringBuilder();

            try
            {
                foreach (var item in analyzer)
                {
                    //Console.WriteLine("  " + item);

                    result.AppendLine("  " + item.ToString());
                }

                return result.ToString();
            }
            catch (SyntaxErrorException error)
            {
                return "  " + error.UnderMarkString + NewLine + error.Message;
            }

            catch (Exception error)
            {
                return error.Message;
            }


        }

    }
}
