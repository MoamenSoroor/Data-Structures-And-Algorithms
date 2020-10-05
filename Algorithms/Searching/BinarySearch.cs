using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class BinarySearch
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
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            int low = 0;
            int high = source.Count - 1;
            int middle = (high + low) / 2;

            while (low <= high)
            {
                if (source[middle].CompareTo(value) > 0)
                    high = middle - 1;

                else if (source[middle].CompareTo(value) < 0)
                    low = middle + 1;
                else
                    return middle;


                middle = (high + low) / 2;
            }

            return -1;


        }


        public static int SearchWithRecursion<TSource>(List<TSource> source, TSource value)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            return Recursion(source, value, 0, source.Count - 1);


        }

        private static int Recursion<TSource>(List<TSource> source, TSource value, int low, int high)
            where TSource : IComparable<TSource>
        {
            if (low > high) return -1;

            int middle = (high + low) / 2;
            if (source[middle].CompareTo(value) > 0)
                return Recursion(source, value, low, middle - 1);

            else if (source[middle].CompareTo(value) < 0)
                return Recursion(source, value, middle + 1, high);
            else
                return middle;

        }


        public static int Search<TSource>(List<TSource> source, TSource value, int startIndex)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();
            if (startIndex < 0 || startIndex > source.Count - 1) throw new IndexOutOfRangeException();


            int low = startIndex;
            int high = source.Count - 1;
            int middle = (high + low) / 2;

            while (low <= high)
            {
                if (source[middle].CompareTo(value) > 0)
                    high = middle - 1;

                else if (source[middle].CompareTo(value) < 0)
                    low = middle + 1;
                else
                    return middle;


                middle = (high + low) / 2;
            }

            return -1;

        }


        public static int Search<TSource>(List<TSource> source, TSource value, int startIndex, int count)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();
            if (startIndex < 0 || startIndex > source.Count - 1) throw new IndexOutOfRangeException();
            if (count < 1 || count > source.Count) throw new IndexOutOfRangeException();
            if (count + startIndex > source.Count) throw new IndexOutOfRangeException();


            int low = startIndex;
            int high = startIndex + count;
            int middle = (high + low) / 2;

            while (low <= high)
            {
                if (source[middle].CompareTo(value) > 0)
                    high = middle - 1;

                else if (source[middle].CompareTo(value) < 0)
                    low = middle + 1;
                else
                    return middle;


                middle = (high + low) / 2;
            }

            return -1;


        }





        public static void Test()
        {
            Console.WriteLine("---------- Test  Binary Search ----------");

            List<int> list =
                new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list.Sort();

            list.Print("List: ");

            Console.WriteLine($"search 10  = {Search(list, 10)}");
            Console.WriteLine($"search 44  = {Search(list, 44)}");
            Console.WriteLine($"search 3   = {Search(list, 3)}");
            Console.WriteLine($"search 9   = {Search(list, 9)}");
            Console.WriteLine($"search 4   = {Search(list, 4)}");
            Console.WriteLine($"search 100 = {Search(list, 100)}");
            Console.WriteLine($"search 50  = {Search(list, 50)}");

            // SearchWithRecursion

            Console.WriteLine($"Recursive search 10  = {SearchWithRecursion(list, 10)}");
            Console.WriteLine($"Recursive search 44  = {SearchWithRecursion(list, 44)}");
            Console.WriteLine($"Recursive search 3   = {SearchWithRecursion(list, 3)}");
            Console.WriteLine($"Recursive search 9   = {SearchWithRecursion(list, 9)}");
            Console.WriteLine($"Recursive search 4   = {SearchWithRecursion(list, 4)}");
            Console.WriteLine($"Recursive search 100 = {SearchWithRecursion(list, 100)}");
            Console.WriteLine($"Recursive search 50  = {SearchWithRecursion(list, 50)}");
        }
    }
}
