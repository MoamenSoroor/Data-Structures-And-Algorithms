using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class BubbleSort
    {

        public static void Sort<TSource>(List<TSource> source)
            where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            int rounds = 0;
            bool isSorted = true;

            for (int i = 0; i < source.Count; i++)
            {
                for (int j = 0; j < source.Count - i - 1; j++)
                {
                    if (source[j].CompareTo(source[j + 1]) > 0)
                    {
                        Utils.Swap(source, j, j + 1);
                        isSorted = false;
                    }
                    rounds++;
                }

                if (isSorted == true) break;
            }
            Console.WriteLine("# of Rounds = {0}", rounds);

        }



        public static void SortDescending<TSource>(List<TSource> source)
           where TSource : IComparable<TSource>
        {
            if (source == null) throw new NullReferenceException();

            int rounds = 0;
            bool isSorted = true;

            for (int i = 0; i < source.Count; i++)
            {
                for (int j = 0; j < source.Count - i - 1; j++)
                {
                    if (source[j].CompareTo(source[j + 1]) > 0)
                    {
                        Utils.Swap(source, j, j + 1);
                        isSorted = false;
                    }
                    rounds++;
                }

                if (isSorted == true) break;
            }
            Console.WriteLine("# of Rounds = {0}", rounds);
        }


        public static void Test()
        {
            Console.WriteLine("---------- Test Bubble Sort ----------");

            List<int> list = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list.PrintInline("List before Asc Bubble Sorting");
            Sort(list);
            list.PrintInline("List after Asc Bubble Sorting");

            // sort already sorted list
            Sort(list);
            list.PrintInline("Sorted List after try to sorting it again: ");



            List<int> list2 = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list2.PrintInline("List before Desc Bubble Sorting");
            SortDescending(list2);
            list2.PrintInline("List after Desc Bubble Sorting");
        }




    }
}
