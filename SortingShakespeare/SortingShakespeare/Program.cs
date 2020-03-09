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
            //ReadTxtFile readTxtFile = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/shakespeare-complete-works.txt");  //På github, full size 
            //ReadTxtFile readTxtFile = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words


            // Test of functionality
            // Console.WriteLine(readTxtFile.ShakespearText);   Check if text has beeen read.
            //foreach (var item in readTxtFile.ShakespearTextArray)
            //{
            //    Console.WriteLine(item);
            //}

            // Test of functionality
            //string[] ShakespearsArrayOfWords = readTxtFile.ShakespearTextArray;         

            //SelectionSort.selectionSort(ShakespearsArrayOfWords);
            //foreach (var item in ShakespearsArrayOfWords)
            //{
            //    Console.WriteLine(item);
            //}




            //setup
            ReadTxtFile readTxtFile = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/shakespeare-complete-works.txt");  //På github, full size 
            //ReadTxtFile readTxtFile = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words
            string[] ShakespearsArrayOfWords = readTxtFile.ShakespearTextArray;
            Stopwatch stopwatch = new Stopwatch();

            //// Selection sort timing test    -  is VERY slow.. so don't expect a time being printed out 
            //stopwatch.Start();
            //SelectionSort.selectionSort(ShakespearsArrayOfWords);
            //stopwatch.Stop();
            //Console.WriteLine("Selection sort" + stopwatch.Elapsed);
            //stopwatch.Restart();


            // Insertions sort timing test    -  
            stopwatch.Start();
            InsertionSort.InsertSort(ShakespearsArrayOfWords);
            stopwatch.Stop();
            Console.WriteLine("Insertions sort" + stopwatch.Elapsed);
            stopwatch.Restart();

            ////Heap sort with timing test    -    
            //stopwatch.Start();
            //HeapSort.Heapsort(ShakespearsArrayOfWords, ShakespearsArrayOfWords.Length);
            //stopwatch.Stop();
            //Console.WriteLine("Heap sort" + stopwatch.Elapsed);
            //stopwatch.Restart();

            ////Heap sort with <T> timing test    -    
            //stopwatch.Start();
            //var test = HeapSortWithT.heapSort<string>(ShakespearsArrayOfWords);
            //stopwatch.Stop();
            //Console.WriteLine("Heap sort" + stopwatch.Elapsed);
            //stopwatch.Restart();



            //// Merge sort timing test    - 
            //stopwatch.Start();
            //MergeSort.mergeSort(ShakespearsArrayOfWords);
            //stopwatch.Stop();
            //Console.WriteLine("Merge sort: " + stopwatch.Elapsed);
            //stopwatch.Restart();






            Console.ReadLine();
        }
    }
}
