using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
     class FindPairs
    {

        public static int PairsFinderFunction(int[] input)
        {
            int max = input.Max();
            int pairsCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] + input[j] == max && i != j)
                        pairsCounter++;
                }
            }

            return pairsCounter / 2;
        }
    }
}
