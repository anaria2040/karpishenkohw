using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class RearrangeDigits
    {
        public static int Rearrange(int input)
        {
            int k = 0, smallest;
            string inputToStr = input.ToString();
            int[] digitsArray = new int[inputToStr.Length];

            for (int i = 0; i < digitsArray.Length; i++)
            {
                digitsArray[i] = int.Parse(inputToStr[i].ToString());                // перевожу число в массив цифр
            }

            int[] newDigitsArray = new int[digitsArray.Length];
            Array.Copy(digitsArray, newDigitsArray, digitsArray.Length);

            for (k = newDigitsArray.Length - 1; k > 0; k--)
            {
                if(newDigitsArray[k] > newDigitsArray[k - 1])
                {
                    break;
                }
            } 
            
            if (k == 0)
                return -1;

            smallest = k;
            int minMax = k-1;
            for (int i = k+1; i < newDigitsArray.Length; i++)
            {
                if(newDigitsArray[i] > newDigitsArray[minMax] && newDigitsArray[i] < newDigitsArray[smallest] )
                {
                    smallest = i;
                }
            }

            int temp = newDigitsArray[smallest];
            newDigitsArray[smallest] = newDigitsArray[minMax];
            newDigitsArray[minMax] = temp;

            for (int i = k; i < newDigitsArray.Length - 1; i++)
            {
                for (int j = i + 1; j < newDigitsArray.Length; j++)
                {
                    if (newDigitsArray[i] > newDigitsArray[j])
                    {
                        temp = newDigitsArray[i];
                        newDigitsArray[i] = newDigitsArray[j];
                        newDigitsArray[j] = temp;
                    }
                }
            }

            int result = int.Parse(String.Join("", newDigitsArray));

            return result;
        }
    }
}
