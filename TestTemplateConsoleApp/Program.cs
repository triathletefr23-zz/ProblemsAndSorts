using System;
using System.Diagnostics;
using ProblemsLibrary.Problems.Helpers;
using SortsLibrary;
using static System.Console;

namespace TestTemplateConsoleApp
{
    internal class Program
    {
        static void miniMaxSum(int[] arr)
        {
            Int64 sum = 0;
            foreach (var el in arr)
            {
                sum += el;
            }

            Int64 min = Int64.MaxValue;
            Int64 max = Int64.MinValue;
            foreach (var el in arr)
            {
                Int64 curr = sum - el;
                if (curr > max) max = curr;
                if (curr < min) min = curr;
            }

            WriteLine(min + " " + max);
        }

        public static void Main(string[] args)
        {
            //string exit = null;
            //while (exit != "exit")
            //{
            //    WriteLine("First param: ");
            //    var first = ReadLine();

            //    //WriteLine("Second param: ");
            //    //var second = ReadLine();

            //    WriteLine("Result is " + Problems.ToLowercase(first));
            //    WriteLine("Want to finish (tape \"exit\"):");
            //    exit = ReadLine();
            //}

            const int step = 5000;
            for (var i = step; i < 65000; i += step)
            {
                WriteLine("N = " + i);

                var defaultArray = Data.GenerateRandomArray(i);
                var watch = new Stopwatch();
                //watch.Start();
                //Sorts.InsertionSort(defaultArray);
                //watch.Stop();
                //WriteLine("InsertionSort time " + watch.ElapsedMilliseconds);

                //watch = new Stopwatch();
                //watch.Start();
                //Sorts.SelectionSort(defaultArray);
                //watch.Stop();
                //WriteLine("SelectionSort time " + watch.ElapsedMilliseconds);

                watch = new Stopwatch();
                watch.Start();
                Sorts.ShellSort(defaultArray);
                watch.Stop();
                WriteLine("ShellSort time " + watch.ElapsedMilliseconds);

                //watch = new Stopwatch();
                //watch.Start();
                //Sorts.MergeSort(defaultArray);
                //watch.Stop();
                //WriteLine("MergeSort time " + watch.ElapsedMilliseconds);

                //watch = new Stopwatch();
                //watch.Start();
                //Sorts.BottomUpMergeSort(defaultArray);
                //watch.Stop();
                //WriteLine("BottomUp MergeSort time " + watch.ElapsedMilliseconds);

                watch = new Stopwatch();
                watch.Start();
                Sorts.HeapSort(defaultArray);
                watch.Stop();
                WriteLine("HeapSort time " + watch.ElapsedMilliseconds);

                watch = new Stopwatch();
                watch.Start();
                Sorts.QuickSort(defaultArray);
                watch.Stop();
                WriteLine("QuickSort time " + watch.ElapsedMilliseconds);
            }

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //miniMaxSum(arr);

            ReadKey();
        }
    }
}
