using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToptalPractice
{
    public class BubbleSort
    {

        public static int[] SortRecursive(int[] numbers)
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
                return SortRecursive(numbers);

            return numbers;

        }

        public static int[] Sort(int[] numbers)
        {

            do
            {

                bool changed = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {

                    int firstNum = numbers[i];
                    int secNum = numbers[i + 1];

                    if (firstNum > secNum)
                    {

                        numbers[i] = secNum;
                        numbers[i + 1] = firstNum;
                        changed = true;

                    }

                }

                if (!changed)
                    break;

            } while (true);

            return numbers;

        }

    }

}
