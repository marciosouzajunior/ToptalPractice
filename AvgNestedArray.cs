using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public class AvgNestedArray
    {

        public static void CalcAvg(int[,] arr)
        {

            int sum;
            double avg;

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                sum = 0;
                avg = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   sum += arr[i, j];
                }

                avg = sum / arr.GetLength(1);
                Console.WriteLine("avg = {0}", avg);

            }

        }

    }
}
