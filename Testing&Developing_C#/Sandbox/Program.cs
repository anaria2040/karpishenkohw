using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1.1, 3, 9, 7, 2, 0, -3 };
            double min, max, avg, dev;
            bool isSorted = false;
            double temp;
            while (isSorted == false)
            {
                isSorted = true;
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        isSorted = false;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}
