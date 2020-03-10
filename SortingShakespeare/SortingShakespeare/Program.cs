using SortingShakespeare.Algorithms;
using SortingShakespeare.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingShakespeare
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            //ReadTxtFile readTxtFile = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/shakespeare-complete-works.txt");  //På github, full size 
            ReadTxtFile readTxtFile = new ReadTxtFile("C:/Users/Bruger/source/repos/Sorting-Shakespeare-s-complete-works-Algorithms/shakespeare-complete-works.txt"); // Christoffer
            Stopwatch stopwatch = new Stopwatch();
            //setup end

            //Trie sort with timing test ~ 00:00:00.5325465
            string[] ShakespearsArrayOfWords6 = readTxtFile.ShakespearTextArray;
            stopwatch.Start();
            SortStrings.printInSortedOrder(ShakespearsArrayOfWords6);
            stopwatch.Stop();
            Console.WriteLine("Trie sort: " + stopwatch.Elapsed);
            stopwatch.Restart();

            //Heap sort with timing test ~ 00:00:00.8853860
            string[] ShakespearsArrayOfWords3 = readTxtFile.ShakespearTextArray;
            stopwatch.Start();
            HeapSort.Heapsort(ShakespearsArrayOfWords3, ShakespearsArrayOfWords3.Length);
            stopwatch.Stop();
            Console.WriteLine("Heap sort: " + stopwatch.Elapsed);
            stopwatch.Restart();

            //Heap sort with <T> timing test ~ 00:00:10.3874843
            string[] ShakespearsArrayOfWords4 = readTxtFile.ShakespearTextArray;
            stopwatch.Start();
            HeapSortWithT.heapSort<string>(ShakespearsArrayOfWords4);
            stopwatch.Stop();
            Console.WriteLine("Heap sort <T>: " + stopwatch.Elapsed);
            stopwatch.Restart();

            // Merge sort timing test ~ 00:00:03.5317335
            string[] ShakespearsArrayOfWords5 = readTxtFile.ShakespearTextArray;
            stopwatch.Start();
            MergeSort.mergeSort(ShakespearsArrayOfWords5);
            stopwatch.Stop();
            Console.WriteLine("Merge sort: " + stopwatch.Elapsed);
            stopwatch.Restart();

            // TOO SLOW TO RUN

            ////Insertions sort timing test ~
            //string[] ShakespearsArrayOfWords2 = readTxtFile.ShakespearTextArray;
            //stopwatch.Start();
            //InsertionSort.InsertSort(ShakespearsArrayOfWords2);
            //stopwatch.Stop();
            //Console.WriteLine("Insertions sort" + stopwatch.Elapsed);
            //stopwatch.Restart();

            //// Selection sort timing test ~  is VERY slow.. so don't expect a time being printed out 
            //string[] ShakespearsArrayOfWords1 = readTxtFile.ShakespearTextArray;
            //stopwatch.Start();
            //SelectionSort.selectionSort(ShakespearsArrayOfWords1);
            //stopwatch.Stop();
            //Console.WriteLine("Selection sort" + stopwatch.Elapsed);
            //stopwatch.Restart();

            Console.ReadLine();
        }
    }
}
