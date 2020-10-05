using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class DigitsAnalysis
    {
        protected static List<int> Convert(int number)
        {
            List<int> ints = new List<int>();
            int input = number;
            int divisor = 10;
            while (input > 0)
            {
                int digit = input % divisor;
                input -= digit;
                input = input / divisor;
                ints.Add(digit);
            }

            return ints;

        }

        public static List<int> GetIntegerDigits(double number, out int integerDigits)
        {
            List<int> digits = new List<int>();
            int integerPart = (int)number;
            int divisor = 10;
            while (integerPart > 0)
            {
                int digit = integerPart % divisor;
                integerPart -= digit;
                integerPart = integerPart / divisor;
                digits.Add(digit);
            }

            integerDigits = digits.Count;

            return digits;

        }

        public static List<int> GetFractionalDigits(double number, out int fractionDigits)
        {
            List<int> digits = new List<int>();


            double decimalPart = Math.Round(number - (int)number, 15);
            double multiplier = 10;
            while (decimalPart > 0)
            {
                double v1 = decimalPart * multiplier;
                int digit = (int)v1;
                decimalPart = Math.Round(v1 - digit, 15);
                digits.Add(digit);
            }

            fractionDigits = digits.Count;
            return digits;

        }

        public static List<int> GetIntegerDigits(double number)
        {
            List<int> digits = new List<int>();
            int integerPart = (int)number;
            int divisor = 10;
            while (integerPart > 0)
            {
                int digit = integerPart % divisor;
                integerPart -= digit;
                integerPart = integerPart / divisor;
                digits.Add(digit);
            }


            return digits;

        }

        public static List<int> GetFractionalDigits(double number)
        {
            List<int> digits = new List<int>();


            double decimalPart = Math.Round(number - (int)number, 15);
            double multiplier = 10;
            while (decimalPart > 0)
            {
                double v1 = decimalPart * multiplier;
                int digit = (int)v1;
                decimalPart = Math.Round(v1 - digit, 15);
                digits.Add(digit);
            }

            return digits;

        }

        // convert number to digits each digit alone without using string

        public static void Test()
        {
            Console.WriteLine("Test Digits Conversion: ");
            //var list = Convert(122);
            //list.PrintInline();
            //
            //
            //var list2 = Convert(122.134);
            //list2.PrintInline();
        }




        private double number;
        public double Number
        {
            get => number; 
            set
            {
                number = value;
                Convert();
            }
        }

        private List<int> Digits { get; set; } = new List<int>();

        public DigitsAnalysis(double number)
        {
            Number = number;
            Convert();
        }

        public DigitsAnalysis()
        {
            Number = 0;
            Convert();
        }


        public void Convert()
        {

            double decimalPart = Math.Round(number - (int)number, 15);
            double multiplier = 10;
            while (decimalPart > 0)
            {
                double v1 = decimalPart * multiplier;
                int digit = (int)v1;
                decimalPart = Math.Round(v1 - digit, 15);
                Digits.Add(digit);
            }

            // integer part

            int integerPart = (int)number;
            int divisor = 10;
            while (integerPart > 0)
            {
                int digit = integerPart % divisor;
                integerPart -= digit;
                integerPart = integerPart / divisor;
                Digits.Add(digit);
            }





        }












    }
}
