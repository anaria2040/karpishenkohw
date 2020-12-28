using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class ListFilter
    {
        public static List<object> FilterList (List<object> inputList)
        {
            List<object> newList = inputList.FindAll(i => i.GetType() != typeof(string)).ToList();

            return newList; 
        }
    }
}
