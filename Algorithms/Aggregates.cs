using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Aggregates
    {
        public static TSource Max<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            TSource max = source[0];

            for (int i = 1; i < source.Count; i++)
            {
                if (source[i].CompareTo(max) > 0)
                {
                    max = source[i];
                }
            }

            return max;
        }

        public static TSource Min<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            TSource min = source[0];

            for (int i = 1; i < source.Count; i++)
            {
                if (source[i].CompareTo(min) < 0)
                {
                    min = source[i];
                }
            }
            return min;
        }

        /// <summary>
        /// This Method find the Maximum Item in a List or, 2nd Max, 3rd Max,...etc. 
        /// setting degree arg to 1 means finding the minimum , 
        /// to 2 finding the 2nd minimum, 
        /// to 3 finding the 3rd minimum, ...etc
        /// </summary>
        /// <typeparam name="TSource">Type Parameter of List</typeparam>
        /// <param name="source">List to find Max Item in it</param>
        /// <param name="degree">the degree of the min item: e.g the first Max , 2nd Max, 3rd Max,...etc </param>
        /// <returns></returns>
        public static TSource Max<TSource>(List<TSource> source, int degree)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            TSource max = Max(source);
            TSource threshold = max;

            for (int d = 1; d < degree; d++)
            {
                max = source[0];
                for (int i = 1; i < source.Count; i++)
                {
                    if (source[i].CompareTo(max) > 0 
                        && source[i].CompareTo(threshold) < 0)
                    {
                        max = source[i];
                    }
                }

                threshold = max;
            }

            return max;
        }

        /// <summary>
        /// This Method find the Minimum Item in a List or, 2nd Min, 3rd Min,...etc. 
        /// setting degree arg to 1 means finding the minimum , 
        /// to 2 finding the 2nd minimum, 
        /// to 3 finding the 3rd minimum, ...etc
        /// </summary>
        /// <typeparam name="TSource">Type Parameter of List</typeparam>
        /// <param name="source">List to find Min Item in it</param>
        /// <param name="degree">the degree of the min item: e.g the first Min , 2nd Min, 3rd Min,...etc </param>
        /// <returns></returns>
        public static TSource Min<TSource>(List<TSource> source, int degree)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            TSource min = Min(source);
            TSource threshold = min;

            for (int d = 1; d < degree; d++)
            {
                min = source[0];
                for (int i = 1; i < source.Count; i++)
                {
                    if (source[i].CompareTo(min) < 0 && source[i].CompareTo(threshold) > 0)
                    {
                        min = source[i];
                    }
                }

                threshold = min;
            }

            return min;
        }







        // tests
        public static void Test()
        {
            List<int> list2 = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            Console.WriteLine("-------------- Test Aggregates: --------------");
            list2.PrintInline("List: ");
            Console.WriteLine("1 Max: " + Max(list2));
            Console.WriteLine("2 Max: " + Max(list2,2));
            Console.WriteLine("3 Max: " + Max(list2,3));
            Console.WriteLine("4 Max: " + Max(list2,4));


            list2.PrintInline("List: ");
            Console.WriteLine("1 Min: " + Min(list2));
            Console.WriteLine("2 Min: " + Min(list2, 2));
            Console.WriteLine("3 Min: " + Min(list2, 3));
            Console.WriteLine("4 Min: " + Min(list2, 4));


        }


    }
}
