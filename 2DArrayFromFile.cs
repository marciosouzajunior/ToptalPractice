using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToptalPractice
{
    public class _2DArrayFromFile
    {

        public static void ReadFile()
        {

            string[] lines = File.ReadAllLines("2d_array.txt");
            int[,] arr = new int[lines.Length, 10];

            for (int i = 0; i < lines.Length; i++)
            {

                string[] splited = lines[i].Split(" ");

                for (int j = 0; j < splited.Length; j++)
                {
                    arr[i, j] = int.Parse(splited[j]);
                }

            }

            // Print
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }

                Console.WriteLine("");

            }            

        }

    }

}
