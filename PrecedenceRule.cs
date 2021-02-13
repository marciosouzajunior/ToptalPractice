using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    class PrecedenceRule
    {

        /*
         * A precedence rule is given as "P>E", which means that letter "P" is followed directly by the letter "E".
         * Write a function, given an array of precedence rules, that finds the word represented by the given rules.
         * Note: Each represented word contains a set of unique characters, i.e.the word does not contain duplicate letters.
         * 
         * Examples:
         * findWord(["P>E", "E>R", "R>U"]) // PERU
         * findWord(["I>N", "A>I", "P>A", "S>P"]) // SPAIN
         * 
         * Test cases:
         * findWord(["U>N", "G>A", "R>Y", "H>U", "N>G", "A>R"]) // HUNGARY
         * findWord(["I>F", "W>I", "S>W", "F>T"]) // SWIFT
         * findWord(["R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G"]) // PORTUGAL
         * findWord(["W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T"]) // SWITZERLAND
         */

        public static void FindWord(string[] precedence)
        {

            List<string> word = new List<string>();

            // Create word with only distinct chars
            for (int i = 0; i < precedence.Length; i++)
            {

                string firstChar = precedence[i][0].ToString();
                string secondChar = precedence[i][2].ToString();

                if (!word.Contains(firstChar))
                    word.Add(firstChar);

                if (!word.Contains(secondChar))
                    word.Add(secondChar);

            }

            // Run until satisfies all rules
            do
            {

                bool changed = false;

                for (int i = 0; i < precedence.Length; i++)
                {

                    string firstChar = precedence[i][0].ToString();
                    string secondChar = precedence[i][2].ToString();

                    int indexFirst = word.IndexOf(firstChar);
                    int indexSec = word.IndexOf(secondChar);

                    // Check if the chars is in the right order
                    if (indexSec == (indexFirst + 1))
                    {                        
                        continue;

                    } else
                    {
                        
                        // Need to change
                        word.Remove(secondChar);
                        word.Insert(indexFirst, secondChar);
                        changed = true;

                    }
                    
                }

                if (!changed)
                    break;

            } while (true);

            Console.WriteLine(string.Join("", word));

        }

    }
}

