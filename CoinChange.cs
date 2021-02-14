using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{

    /*
     * Suppose you’re given an array of numbers that represent the values of each coin.
     * Then you’re given an amount and asked to find the minimum number of coins that are needed to make that amount.
     * Assume the number of coins you have are infinite, so you don’t need to worry about how many coins are at your disposal.
     */

    public class CoinChange
    {

        public static void MinCoin(int[] coins, int value)
        {

            List<int> result = new List<int>();
            int sum = 0;

            Array.Reverse(coins);

            for (int i = 0; i < coins.Length; i++)
            {

                while (sum + coins[i] <= value)
                {
                    sum += coins[i];
                    result.Add(coins[i]);
                }

                if (sum == value)
                    break;

            }

            Console.WriteLine("Coin change for {0} is: {1}.", value, string.Join(",", result));

        }

    }

}
