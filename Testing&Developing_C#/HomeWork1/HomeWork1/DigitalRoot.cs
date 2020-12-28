using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class DigitalRoot
    {
        public static int FindDigitalRoot(int input)
        {
            int sum = 0;
            string inputToStr = input.ToString();

            do
            {
                sum = 0;

                for (int i = 0; i < inputToStr.Length; i++)
                {
                    sum += int.Parse(inputToStr[i].ToString());
                }

                inputToStr = sum.ToString();

            } while (sum.ToString().Length != 1);

            return sum;
        }
    }
}
