using Algorithms.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSort<TSource> where TSource : IComparable<TSource>
    {

        private List<TSource> list;

        private List<TSource> result = new List<TSource>();


        public List<TSource> List
        {
            get => list;
            set
            {
                list = value;
                result = new List<TSource>();
            }
        }

        public List<TSource> SortedList { get => result; }

        public MergeSort()
        {
            list = new List<TSource>();

        }

        public MergeSort(List<TSource> plist)
        {
            list = plist;

        }

        public void StartSorting()
        {
            result = new List<TSource>(list.Count);
            Sort(0, list.Count - 1);

        }

        public void Sort(int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) return;

            int middle = startIndex + (endIndex - startIndex) / 2;

            Sort(startIndex, middle);
            Sort(middle + 1, endIndex);

            Merge(startIndex, middle, endIndex);




        }

        public static void SortDescending()
        {

        }


        private void Merge(int startIndex, int middle, int endIndex)
        {
            int i = startIndex, j = middle + 1, k = startIndex;
            while (i <= middle && j <= endIndex)
            {
                if (List[i].CompareTo(List[j]) < 0)
                {
                    SortedList[k] = List[i++];
                }
                else
                    SortedList[k] = List[j++];

                k++;
            }

            while (i <= middle)
            {
                SortedList[k++] = List[i++];
            }

            while (j <= endIndex)
            {
                SortedList[k++] = List[j++];
            }
        }



        public static List<T> MergeLists<T>(List<T> source1, List<T> source2)
            where T : IComparable<T>
        {
            var result = new List<T>(source1.Count + source2.Count);
            int i = 0, j = 0;

            while (i < source1.Count && j < source2.Count)
            {
                if (source1[i].CompareTo(source2[j]) < 0)
                {
                    result.Add(source1[i++]);
                }
                else
                    result.Add(source2[j++]);
            }

            while (i < source1.Count)
            {
                result.Add(source1[i++]);
            }

            while (j < source2.Count)
            {
                result.Add(source2[j++]);
            }


            return result;
        }


        public static void Test()
        {
            Console.WriteLine("---------- Test Merge Sort ----------");


            var smallList1 = new List<int> { 10, 20, 30, 40 };
            var smallList2 = new List<int> { 15, 25, 35, 45 };
            var smallList3 = new List<int> { 10, 20, 30, 40 };
            var smallList4 = new List<int> { 60, 70, 80, 90 };
            smallList1.PrintInline("Small List: ");
            smallList2.PrintInline("Small List: ");
            smallList3.PrintInline("Small List: ");
            smallList4.PrintInline("Small List: ");

            var result = MergeLists(smallList1, smallList2);
            result.PrintInline("Merged List");

            result = MergeLists(smallList3, smallList4);
            result.PrintInline("Merged List");


            result = MergeLists(smallList4, smallList3);
            result.PrintInline("Merged List");

            // 
            List<int> list = new List<int>() { 10, 5, 2, 1, 3, 11, 3, 44, 4, 9, 8, 100 };

            list.PrintInline("List before Asc Merge Sort");
            var mergeSort = new MergeSort<int>(list);
            mergeSort.Sort(0, list.Count - 1);
            mergeSort.SortedList.PrintInline("List after Asc Merge Sort");

        }
    }
}
