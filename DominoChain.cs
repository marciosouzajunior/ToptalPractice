using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{
    public static class DominoChain
    {

        public static int longestChain = 0;

        public static void ListChains(List<Domino> chain, List<Domino> domList)
        {

            for (int i = 0; i < domList.Count; ++i)
            {

                Domino dom = domList[i];

                // Remove domino from list
                List<Domino> domList1 = new List<Domino>(domList);
                domList1.RemoveAt(i);

                // Add domino to chain and test
                List<Domino> chain1 = new List<Domino>(chain);
                chain1.Add(dom);

                if (TestChain(chain1))
                {

                    //Console.WriteLine(string.Join(",", chain1));
                    ListChains(chain1, domList1);

                    if (chain1.Count > longestChain)
                        longestChain = chain1.Count;

                }

                // Now do it with the domino flipped
                List<Domino> chain2 = new List<Domino>(chain);
                chain2.Add(dom.Flipped());

                if (TestChain(chain2))
                {

                    //Console.WriteLine(string.Join(",", chain2));
                    ListChains(chain2, domList1);

                    if (chain2.Count > longestChain)
                        longestChain = chain2.Count;

                }

            }

        }

        private static bool TestChain(List<Domino> seq)
        {

            bool result = true;

            for (int i = 0; i < seq.Count -1; i++)
            {

                if (seq[i].b != seq[i + 1].a)
                {
                    result = false;
                    break;
                }

            }

            return result;

        }

    }

    public class Domino
    {

        public int a;
        public int b;

        public Domino(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Domino Flipped()
        {
            return new Domino(b, a);
        }

        public override string ToString()
        {
            return "[" + a + "/" + b + "]";
        }

    }

}
