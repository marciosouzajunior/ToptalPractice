using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public class Anagram
    {

        public static void IsAnagram(string word)
        {

            
            string reversed = Reverse(word);

            if (word == reversed)
                Console.WriteLine("{0} is anagram.");
            else
                Console.WriteLine("{0} is not anagram.");

        }

        static string Reverse(string word)
        {

            string reversed = "";

            for (int i = word.Length -1; i >= 0; i--)
            {
                reversed += word[i];
            }

            return reversed;

        }  

    }

}
