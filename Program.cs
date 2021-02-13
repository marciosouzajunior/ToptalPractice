using System;
using System.Linq;
using System.Collections.Generic;

namespace ToptalPractice
{

    class Program
    {

        static void Main(string[] args)
        {

            // Check if a word is anagram
            Anagram.IsAnagram("ana");
            Anagram.IsAnagram("marcio");

            // Calc average from nested array
            AvgNestedArray.CalcAvg(
                new int[3, 3] {
                    { 1, 2, 3 },
                    { 2, 4, 6 },
                    { 4, 6, 8 }});

            // Determine if the sequence of brackets is balanced
            BalancedBrackets.IsBalanced("{[()]}");
            BalancedBrackets.IsBalanced("{[(])}");
            BalancedBrackets.IsBalanced("{{[[(())]]}}");

            // Binary search
            int[] arr = new int[] { 1, 2, 3, 5, 7, 4, 5, 6 };
            Array.Sort(arr);
            Console.WriteLine("Index of element {0}: {1}", 4, BinarySearch.Search(arr, 4));
            Console.WriteLine("Index of element {0}: {1}", 9, BinarySearch.Search(arr, 9));
            //Console.WriteLine("Index of element {0}: {1}", 4, BinarySearch.SearchRecursive(arr, 0, arr.Length - 1, 4));
            //Console.WriteLine("Index of element {0}: {1}", 9, BinarySearch.SearchRecursive(arr, 0, arr.Length - 1, 9));

            // BubbleSort
            int[] arr1 = new int[] { 5, 8, 3, 2, 7, 1, 0 };
            Console.WriteLine("Unsorted: {0}", string.Join(",", arr1));
            BubbleSort.Sort(arr1);
            Console.WriteLine("Sorted: {0}", string.Join(",", arr1));

            // Find word by precedence rules
            PrecedenceRule.FindWord(
                new string[] { "R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G" });
            PrecedenceRule.FindWord(
                new string[] { "W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T" });

        }

	}

}
