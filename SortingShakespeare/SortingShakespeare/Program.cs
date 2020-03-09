using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingShakespeare
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTxtFile readTxtFile = new ReadTxtFile(); 

            // Console.WriteLine(readTxtFile.ShakespearText);   Check if text has beeen read.
            foreach (var item in readTxtFile.ShakespearTextArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
