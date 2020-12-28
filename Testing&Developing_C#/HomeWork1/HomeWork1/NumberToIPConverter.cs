using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class NumberToIPConverter
    {
        public static string Convert(UInt32 input)
        {
            int[,] inputToBinary = new int[4, 2 * sizeof(UInt32)];
            UInt32 numerator = input;
            uint denominator = 2;
            for (int i = 3; i >= 0; i--)
            {
                for (int j = inputToBinary.GetLength(1) - 1; j >= 0; j--)
                {
                    inputToBinary[i, j] = (int)(numerator % denominator);
                    numerator /= denominator;
                }
            }


            string[] arrayToDecimal = new string[4];
            for (int sum = 0, i = 0; i < arrayToDecimal.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < 8; j++)
                {
                    sum += int.Parse((inputToBinary[i, j] * Math.Pow(2, 7 - j)).ToString());
                }
                arrayToDecimal[i] = sum.ToString();
            }

            string result = string.Join(".", arrayToDecimal);

            return result;
        }
    }
}
