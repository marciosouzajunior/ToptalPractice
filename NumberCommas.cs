using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public class NumberCommas
    {

        public static string Format(int num)
        {

            string numStr = num.ToString();
            int groupCount = 0;

            for (int i = numStr.Length-1; i > 0; i--)
            {

                groupCount++;

                if (groupCount == 3)
                {
                    numStr = numStr.Insert(i, ",");
                    groupCount = 0;
                }

            }

            return numStr;

        }

    }
}
