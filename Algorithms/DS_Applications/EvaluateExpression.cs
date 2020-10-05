using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DS_Applications
{
    class EvaluateExpression
    {
        // test method
        public static void Test()
        {

        }




        public bool IsOperand(string value)
        {
            return true;
        }

        public bool IsOperator(string value)
        {
            return true;
        }


        public double Evaluate(string expression)
        {
            string[] operators = { "" };

            string[] exp = expression.Trim().Split();

            if (exp == null || exp.Length == 0)
            {
                return 0.0;
            }

            Stack<string> stack = new Stack<string>();

            foreach (var item in exp)
            {

            }


            return 0.0;
        }



    }
}
