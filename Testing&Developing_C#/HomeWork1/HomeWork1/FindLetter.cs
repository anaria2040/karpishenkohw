using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class FindLetter
    {

        public static char FirstNonRepeatingLetter(string input)
        {
            bool fl = true;
            
            for (int i = 0; i < input.Length; i++)
            {
                fl = true;
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[i].ToString().ToUpper() == input[j].ToString().ToUpper() && i != j)
                    {
                        fl = !fl;
                        break;
                    }
                }
                if (fl)
                    return input[i];
            }
            return ' ';
        }
    }
}
