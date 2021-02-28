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
            BalancedBrackets.IsBalancedRecursive("{[()]}");
            BalancedBrackets.IsBalancedRecursive("{[(])}");
            BalancedBrackets.IsBalancedRecursive("{{[[(())]]}}");

            // Binary search
            int[] arr = new int[] { 1, 2, 3, 5, 7, 4, 5, 6 };
            Array.Sort(arr);
            Console.WriteLine("Index of element {0}: {1}", 4, BinarySearch.Search(arr, 4));
            Console.WriteLine("Index of element {0}: {1}", 9, BinarySearch.Search(arr, 9));
            Console.WriteLine("Index of element {0}: {1}", 4, BinarySearch.SearchRecursive(arr, 0, arr.Length - 1, 4));
            Console.WriteLine("Index of element {0}: {1}", 9, BinarySearch.SearchRecursive(arr, 0, arr.Length - 1, 9));

            // BubbleSort
            int[] arr1 = new int[] { 5, 8, 3, 2, 7, 1, 0 };
            Console.WriteLine("Unsorted: {0}", string.Join(",", arr1));
            BubbleSort.Sort(arr1);
            Console.WriteLine("Sorted: {0}", string.Join(",", arr1));

            // Recursive:
            int[] arr2 = new int[] { 5, 8, 3, 2, 7, 1, 0 };
            Console.WriteLine("Unsorted: {0}", string.Join(",", arr2));
            BubbleSort.SortRecursive(arr2);
            Console.WriteLine("Sorted: {0}", string.Join(",", arr2));

            // Find word by precedence rules
            PrecedenceRule.FindWord(
                new string[] { "R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G" });
            PrecedenceRule.FindWord(
                new string[] { "W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T" });

            // Find the balance point in an array of integers
            Console.WriteLine("Balance point: {0}", BalancePoint.Balance(new int[] { 1, 2, 9, 4, -1 }));
            Console.WriteLine("Balance point: {0}", BalancePoint.Balance(new int[] { 1, 2, 3, 7, 6, 5, 9, 5, 6, 7, 5, 2, -1 }));
            Console.WriteLine("Balance point: {0}", BalancePoint.Balance(new int[] { -7, 1, 5, 2, -4, 3, 0 }));

            // Print numbers as string with commas, starting from integers
            Console.WriteLine(NumberCommas.Format(1234567));
            Console.WriteLine(NumberCommas.Format(1000));
            Console.WriteLine(NumberCommas.Format(10000));
            Console.WriteLine(NumberCommas.Format(100));

            // Coin change
            CoinChange.MinCoin(new int[] { 1, 2, 5, 10 }, 12);
            CoinChange.MinCoin(new int[] { 1, 2, 5, 10 }, 13);
            CoinChange.MinCoin(new int[] { 1, 2, 5, 10 }, 15);

            // 2D Array from file
            _2DArrayFromFile.ReadFile();

            // Number of full decks contained in the array
            DeckOfCards.FullDecks(new List<string>() { "9C", "KS", "AC", "AH", "8D", "4C", "KD", "JC", "7D", "9D", "2H", "7C", "3C", "7S", "5C", "6H", "TH" });
            DeckOfCards.FullDecks(new List<string>() { "2S", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH", "2S", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH", "2S", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD" });
            DeckOfCards.FullDecks(new List<string>() { "TD", "TC", "6H", "5H", "KC", "JH", "QC", "4S", "2S", "8H", "JD", "2H", "AC", "7D", "6C", "5D", "AD", "TS", "4D", "KH", "3H", "9H", "3S", "2D", "5S", "6S", "AH", "JS", "6D", "9S", "4C", "7C", "8S", "AS", "KD", "7S", "4H", "KS", "7H", "9D", "8D", "3D", "5C", "9C", "QH", "JC", "8C", "TH", "QS", "3C", "QD", "2C" });

            // Maximum sequence of paired items
            MaxPaired.Max("AAABCEFFFFFFG");

            // Binary Tree
            BinaryTree.BTree();

            // Longest domino chain
            List<Domino> chain = new List<Domino>();
            List<Domino> dominoList = new List<Domino>();

            dominoList.Add(new Domino(0, -1));
            dominoList.Add(new Domino(1, -1));
            dominoList.Add(new Domino(0, 3));
            dominoList.Add(new Domino(3, 0));
            dominoList.Add(new Domino(3, 1));
            dominoList.Add(new Domino(-2, -1));
            dominoList.Add(new Domino(0, -1));
            dominoList.Add(new Domino(2, -2));
            dominoList.Add(new Domino(-1, 2));
            dominoList.Add(new Domino(3, -3));

            DominoChain.ListChains(chain, dominoList);
            Console.WriteLine("Longest domino chain: {0}.",  DominoChain.longestChain);

            // Rotate array
            int[] rotatedArray = RotateArray.rotLeft(new int[] { 1, 2, 3, 4, 5 }, 4);
            Console.WriteLine("Rotated array: {0}", string.Join(", ", rotatedArray));

            // Minimum swaps
            // https://www.hackerrank.com/challenges/minimum-swaps-2
            Console.WriteLine("Minimum swaps: {0}", MinimumSwaps.minimumSwaps(new int[] { 4, 3, 1, 2 }));



        }

    }

}
