using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingShakespeare.Algorithms
{
    public class SelectionSort
    {
        // Sort an array of Strings
        public static void selectionSort(String[] array)
        {
            // Find the string reference that should go in each cell of
            // the array, from cell 0 to the end
            for (int j = 0; j < array.Length - 1; j++)
            {
                // Find min: the index of the string reference that should go into cell j.
                // Look through the unsorted strings (those at j or higher) for the one that is first in lexicographic order
                int min = j;
                for (int k = j + 1; k < array.Length; k++)
                    if (array[k].CompareTo(array[min]) < 0) min = k;

                // Swap the reference at j with the reference at min 
                String temp = array[j];
                array[j] = array[min];
                array[min] = temp;
            }
        }
    }
}
