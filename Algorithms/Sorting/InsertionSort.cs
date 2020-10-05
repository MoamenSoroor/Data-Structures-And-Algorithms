using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class InsertionSort
    {
        public static void Sort<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();
            for (int i = 1; i < source.Count; i++)
            {
                if (source[i].CompareTo(source[i - 1]) > 0)
                    continue;

                TSource current = source[i];
                int j = i;

                while (j > 0 && current.CompareTo(source[j - 1]) < 0)
                {
                    source[j] = source[j - 1];
                    j--;
                }
                source[j] = current;


            }

        }

        public static void SortDescending<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            for (int i = 1; i < source.Count; i++)
            {
                if (source[i].CompareTo(source[i - 1]) < 0)
                    continue;

                TSource current = source[i];
                int j = i;
                while (j > 0 && current.CompareTo(source[j - 1]) > 0)
                {
                    source[j] = source[j - 1];
                    j--;
                }
                source[j] = current;


            }

        }




        public static void Test()
        {
            Console.WriteLine("---------- Test Insertion Sort ----------");

            List<int> list = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list.PrintInline("List before Asc Insertion Sorting");
            Sort(list);
            list.PrintInline("List after Asc Insertion Sorting");


            List<int> list2 = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list2.PrintInline("List before Desc Insertion Sorting");
            SortDescending(list2);
            list2.PrintInline("List after Desc Insertion Sorting");


            // test object
            List<Number> listOfObj = new List<Number>()
            {
                new Number(10),
                new Number(5),
                new Number(2),
                new Number(1),
                new Number(3),
                new Number(11),
                new Number(3),
                new Number(44),
                new Number(4),
                new Number(9),
                new Number(8),
                new Number(100) };

            listOfObj.PrintInline("Object List before Asc Insertion Sorting");
            Sort(listOfObj);
            listOfObj.PrintInline("Object List after Asc Insertion Sorting");
        }
    }
}
