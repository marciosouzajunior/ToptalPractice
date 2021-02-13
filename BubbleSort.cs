using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToptalPractice
{
    public class BubbleSort
    {

        public static int[] Sort(int[] numbers)
        {

            bool changed = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                int n1 = numbers[i];
                int n2 = numbers[i + 1];
                
                // If bigger, swap
                if (n1 > n2)
                {
                    numbers[i] = n2;
                    numbers[i + 1] = n1;
                    changed = true;
                }

            }

            if (changed)
                return Sort(numbers);

            return numbers;

        }

    }

}
