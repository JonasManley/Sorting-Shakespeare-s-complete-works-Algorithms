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
            ReadTxtFile readTxtFile2 = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/shakespeare-complete-works.txt");  //På github, full size 
            
            Stopwatch stopwatch = new Stopwatch();

            //Heap sort with timing test    -    
            //ReadTxtFile readTxtFile3 = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words
            //string[] ShakespearsArrayOfWords3 = readTxtFile3.ShakespearTextArray;
            //stopwatch.Start();
            //HeapSort.Heapsort(ShakespearsArrayOfWords3, ShakespearsArrayOfWords3.Length);
            //stopwatch.Stop();
            //Console.WriteLine("Heap sort" + stopwatch.Elapsed);
            //stopwatch.Restart();

            //Insertions sort timing test    -
            //ReadTxtFile readTxtFile2 = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words
            string[] ShakespearsArrayOfWords2 = readTxtFile2.ShakespearTextArray;
            stopwatch.Start();
            InsertionSort.InsertSort(ShakespearsArrayOfWords2);
            stopwatch.Stop();
            Console.WriteLine("Insertions sort" + stopwatch.Elapsed);
            stopwatch.Restart();

            //// Selection sort timing test    -  is VERY slow.. so don't expect a time being printed out 
            //ReadTxtFile readTxtFile1 = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words
            //string[] ShakespearsArrayOfWords1 = readTxtFile1.ShakespearTextArray;
            //stopwatch.Start();
            //SelectionSort.selectionSort(ShakespearsArrayOfWords1);
            //stopwatch.Stop();
            //Console.WriteLine("Selection sort" + stopwatch.Elapsed);
            //stopwatch.Restart();






            //Heap sort with <T> timing test    -   
            //ReadTxtFile readTxtFile4 = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words
            //string[] ShakespearsArrayOfWords4 = readTxtFile4.ShakespearTextArray;
            //stopwatch.Start();
            //var test = HeapSortWithT.heapSort<string>(ShakespearsArrayOfWords4);
            //stopwatch.Stop();
            //Console.WriteLine("Heap sort" + stopwatch.Elapsed);
            //stopwatch.Restart();



            //// Merge sort timing test    - 
            //ReadTxtFile readTxtFile5 = new ReadTxtFile("C:/Users/Jonas/Documents/GitHub/Sorting-Shakespeare-s-complete-works-Algorithms/SortingShakespeare/SortingShakespeare/shakespeare-complete-works.txt");  //test file 1000 words
            //string[] ShakespearsArrayOfWords5 = readTxtFile5.ShakespearTextArray;
            //stopwatch.Start();
            //MergeSort.mergeSort(ShakespearsArrayOfWords5);
            //stopwatch.Stop();
            //Console.WriteLine("Merge sort: " + stopwatch.Elapsed);
            //stopwatch.Restart();






            Console.ReadLine();
        }
    }
}
