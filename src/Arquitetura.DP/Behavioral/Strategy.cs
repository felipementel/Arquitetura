using System;
using System.Collections.Generic;

namespace Arquitetura.DP.Behavioral
{
    internal abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    internal class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }

    internal class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }

    internal class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }

    internal class SortedList
    {
        private readonly List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            _sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            foreach (var name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }

    public class Strategy
    {
        public static void Execucao()
        {
            var studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }
    }
}