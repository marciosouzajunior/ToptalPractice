using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public static class RotateArray
    {

        public static int[] rotLeft(int[] a, int d)
        {

            int[] rotatedArr = new int[a.Length];
            int pos = 0;

            for (int i = 0; i < a.Length; i++)
            {

                pos = i - d;

                if (pos < 0)
                    pos = pos + a.Length;

                rotatedArr[pos] = a[i];

            }

            return rotatedArr;

        }

    }

}
