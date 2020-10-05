using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class NumberDigits
    {

        public static void Test()
        {
            Console.WriteLine("Test Digits Conversion: ");
            var digits1 = NumberDigits.Convert(122);
            Console.WriteLine(digits1);
            
            var digits2 = NumberDigits.Convert(122.134);
            Console.WriteLine(digits2);

            // get specific digits

            Console.WriteLine();
        }



        public static NumberDigits Convert(double number)
        {
            NumberDigits digits = new NumberDigits(number);
            double decimalPart = Math.Round(number - (int)number, 15);
            double multiplier = 10;
            double divValue = 0.1;
            while (decimalPart > 0)
            {
                double v1 = decimalPart * multiplier;
                int digit = (int)v1;
                decimalPart = Math.Round(v1 - digit, 15);
                digits.Digits.Add(divValue, digit);
                divValue /= 10;
            }

            // integer part

            int integerPart = (int)number;
            int divisor = 10;
            double mulValue = 1;
            while (integerPart > 0)
            {
                int digit = integerPart % divisor;
                integerPart -= digit;
                integerPart = integerPart / divisor;
                digits.Digits.Add(mulValue, digit);
                mulValue *= 10;
            }


            return digits;


        }


        public Dictionary<double, int> Digits { get; } = new Dictionary<double, int>();

        public double Number { get; }

        public int this[double index]
        {
            get 
            {
                try
                {
                    return Digits[index];
                }
                catch (KeyNotFoundException)
                {

                    return -1;
                }
                
            }
        }

        public int DigitsCount { get => Digits.Count; }

        public int IntegersCount
        {
            get
            {
                return Digits.Count(entry => entry.Key >= 1);
            }
        }

        public int FractionsCount
        {
            get
            {
                return Digits.Count(entry => entry.Key < 1);
            }
        }

        private NumberDigits(double number)
        {
            Number = number;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(Digits.Count * 5);
            builder.AppendLine("NumberDigits(" + Number + ") ==>");
            foreach (var item in Digits)
            {
                builder.AppendLine($"{item.Key} = {item.Value}");
            }
            return builder.ToString();
        }


    }
}
