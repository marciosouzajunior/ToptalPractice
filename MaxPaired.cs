using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public class MaxPaired
    {

        public static void Max(string str)
        {

            char currentValue = ' ';
            int count = 0;
            int max = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != currentValue)
                {
                    
                    currentValue = str[i];

                    if (count > max)
                        max = count;

                    count = 0;

                }

                count++;

            }

            Console.WriteLine("Maximum sequence: {0}.", max);

        }

    }

}
