using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class LinearSearch
    {
        /// <summary>
        /// Searches the entire System.Collections.Generic.List`1 
        /// for an element and returns the 
        /// zero-based index of the element and if not found returns -1
        /// </summary>
        /// <typeparam name="TSource">Type of the list elements and searched value</typeparam>
        /// <param name="source">The Searched List</param>
        /// <param name="value">The Value We Search for it</param>
        /// <returns>returns index of the searched value and if not found it returns -1</returns>
        public static int Search<TSource>(List<TSource> source, TSource value)
        {
            if (source == null) throw new NullReferenceException();

            for (int i = 0; i < source.Count; i++)
            {
                if (source[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;


        }

        public static int Search<TSource>(List<TSource> source, TSource value, int startIndex)
        {
            if (source == null) throw new NullReferenceException();
            if (startIndex < 0 || startIndex > source.Count - 1) throw new IndexOutOfRangeException();


            for (int i = startIndex; i < source.Count; i++)
            {
                if (source[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;


        }


        public static int Search<TSource>(List<TSource> source, TSource value, int startIndex, int count)
        {
            if (source == null) throw new NullReferenceException();
            if (startIndex < 0 || startIndex > source.Count - 1) throw new IndexOutOfRangeException();
            if (count < 1 || count > source.Count) throw new IndexOutOfRangeException();
            if (count + startIndex > source.Count) throw new IndexOutOfRangeException();


            for (int i = startIndex; i < startIndex + count; i++)
            {
                if (source[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;


        }





        public static void Test()
        {
            Console.WriteLine("---------- Test  Binary Search ----------");

            List<int> list =
                new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list.Print("List: ");

            Console.WriteLine($"search 10 = {Search(list, 10)}");
            Console.WriteLine($"search 44 = {Search(list, 44)}");
            Console.WriteLine($"search 03 = {Search(list, 3)}");
            Console.WriteLine($"search 09 = {Search(list, 9)}");
            Console.WriteLine($"search 04 = {Search(list, 4)}");
            Console.WriteLine($"search 100 = {Search(list, 100)}");
            Console.WriteLine($"search 50 = {Search(list, 50)}");



        }
    }
}
