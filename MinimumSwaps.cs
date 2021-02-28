using System;
using System.Collections;
using System.Collections.Generic;

namespace ToptalPractice
{
    public static class MinimumSwaps
    {

        public static int minimumSwaps(int[] arr)
        {

            int swapCount = 0;

            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                dict1.Add(i + 1, arr[i]);
                dict2.Add(arr[i], i + 1);
            }


            for (int i = 0; i < arr.Length; i++)
            {

                int value = dict1[i + 1];

                if (value != i + 1)
                {

                    int keyToSwap = dict2[i + 1];
                    dict1[keyToSwap] = value;
                    dict1.Remove(i + 1);
                    dict2.Remove(i + 1);
                    dict2.Remove(value);
                    dict2.Add(value, keyToSwap);
                    swapCount++;

                }

            }

            return swapCount;

        }

    }

}
