using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public class BalancePoint
    {

        public static int Balance(int[] arr)
        {

            int total = 0;
            int leftSum = 0;

            // Total sum
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            // Sum left until total / 2
            int j;
            for (j = 0; j < arr.Length; j++)
            {

                leftSum += arr[j];

                if (leftSum > total/2)
                    break;

            }

            return j;

        }

    }
}
