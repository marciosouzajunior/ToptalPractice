using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public class DeckOfCards
    {

        /*
         * In a casino, all the playing cards got mixed up, and some of them got lost.
         * You have to collect as many full decks as possible.
         * You get N mixed up French playing cards as your input.
         * The cards are of the following ranks:
         * 
         * 2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A
         * 
         * The four suits are:
         * S - Spade (♠), C - Club(♣), H - Heart(♥), D - Diamond(♦)
         * 
         * The cards are given using their rank followed by their suit:
         * 2 of Spades: 2S
         * Ace of Clubs: AC
         * 10 of Hearts: TH
         * 
         * Write a function that will accept an array of cards and return the number of full decks contained in the array.
         */

        public static void FullDecks(List<string> cardsArray)
        {

            Dictionary<string, int> deck = new Dictionary<string, int>();

            // Add all cards into an dictionary, and count how many of each type
            foreach (string card in cardsArray)
            {
                if (deck.ContainsKey(card))
                    deck[card] = deck[card] + 1;
                else
                    deck.Add(card, 1);
            }

            // Check if there is a full deck
            if (deck.Count < 52)
            {
                Console.WriteLine("The cards dont make a full deck.");
                return;
            }                

            // Check which card has the minimum value
            int minValue = int.MaxValue;
            foreach (var item in deck)
            {
                if (item.Value < minValue)
                    minValue = item.Value;

                if (minValue == 1)
                    break;
            }

            Console.WriteLine("{0} full decks.", minValue);

        }

    }

}
