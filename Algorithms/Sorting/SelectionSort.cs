using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public static void Sort<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();


            int minIndex;
            for (int i = 0; i < source.Count - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < source.Count; j++)
                    if (source[minIndex].CompareTo(source[j]) > 0)
                        minIndex = j;

                Utils.Swap(source, minIndex, i);
            }

        }

        public static void SortDescending<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();


            int maxIndex;
            for (int i = 0; i < source.Count - 1; i++)
            {
                maxIndex = i;

                for (int j = i + 1; j < source.Count; j++)
                    if (source[maxIndex].CompareTo(source[j]) < 0)
                        maxIndex = j;

                Utils.Swap(source, maxIndex, i);
            }

        }


        public static void Test()
        {
            Console.WriteLine("---------- Test Selection Sort ----------");

            List<int> list = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list.PrintInline("List before Asc Selection Sorting");
            Sort(list);
            list.PrintInline("List after Asc Selection Sorting");


            List<int> list2 = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list2.PrintInline("List before Desc Selection Sorting");
            SortDescending(list2);
            list2.PrintInline("List after Desc Selection Sorting");
        }






    }
}
