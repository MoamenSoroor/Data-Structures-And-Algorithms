using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Utility
{
    public static class Utils
    {

        public static void InputLoop(Func<string, string> ProcessInput, string title)

        {
            bool end = false;
            do
            {
                Console.Write(title + " ");
                string text = Console.ReadLine();
                if (text.Equals("end", StringComparison.OrdinalIgnoreCase)
                    || text.Trim().Equals(string.Empty))
                    end = true;
                else
                {
                    string result = ProcessInput(text);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine();
                }

            } while (!end);
        }

        public static void Swap<TSource>(List<TSource> source, int index1, int index2)
        {
            if (source == null) throw new NullReferenceException();
            if (index1 != index2)
            {
                var temp = source[index1];
                source[index1] = source[index2];
                source[index2] = temp;
            }

        }


        public static void Print<T>(this IEnumerable<T> source, string title = "")
        {
            Console.WriteLine();
            if (title != "" && title != null)
            {
                Console.WriteLine(title);
            }
            int count = 0;
            foreach (var item in source)
            {
                Console.WriteLine($"Item[ {count:d2} ] = {item}");
                count++;
            }
            Console.WriteLine();
        }

        public static void PrintInline<T>(this IEnumerable<T> source, string title = "")
        {
            Console.WriteLine();

            Console.Write($@"{title ?? "" } {{ ");
            foreach (var item in source)
            {
                Console.Write($"{item} ");

            }

            Console.WriteLine(" }");
            //Console.WriteLine();
        }

        public static bool IsValueType<T>(T obj)
        {
            return obj != null && obj.GetType().IsValueType;
        }




    }
}
