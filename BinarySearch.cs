using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    class BinarySearch
    {

        public static int Search(int[] arr, int v)
        {

            int start = 0;
            int end = arr.Length - 1;

            do
            {

                // Split
                int mid = (start + end) / 2;
                int vMid = arr[mid];

                // Found
                if (vMid == v)
                    return mid;

                // Not found
                if (v < vMid)
                    end = mid - 1; // Search at the beginning
                else
                    start = mid + 1; // Search at the ending

                // Exit
                if (start >= end)
                    return -1;

            } while (true);

        }

        public static int SearchRecursive(int[] arr, int start, int end, int v)
        {

            if (start >= end)
                return -1;

            // Split
            int mid = (start + end) / 2;
            int value = arr[mid];

            if (value == v)
                return mid;
        
            if (value < v)
                return SearchRecursive(arr, start, mid -1, v); // Search at the beginning
            else
                return SearchRecursive(arr, mid + 1, end, v); // Search at the ending

        }

    }
}
