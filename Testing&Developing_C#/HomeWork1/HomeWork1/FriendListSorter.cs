using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class FriendListSorter
    {
        class Friend
        {
            public string Name;
            public string Surname;

            public Friend(string _Name, string _Surname)
            {
                Name = _Name;
                Surname = _Surname;
            }
        }


        public static string Sorter(string input)
        {
            string[] FriendList = input.ToUpper().Split(';');              // массив строк с парой имя - фамилия

            List<Friend> guests = new List<Friend>(FriendList.Length);

            for (int i = 0; i < FriendList.Length; i++)
            {
                string[] temp = FriendList[i].Split(':');
                guests.Add(new Friend(temp[0], temp[1]));                  // создаю и заполняю список друзей
            }

            FriendList = new string[FriendList.Length];
            for (int i = 0; i < FriendList.Length; i++)
            {
                FriendList[i] = guests[i].Surname + " " + guests[i].Name;  // меняю имя и фамилию местами для сортировки
            }


            FriendList = FriendList.OrderBy(f => f).ToArray();             // сортирую

            for (int i = 0; i < FriendList.Length; i++)
            {
                FriendList[i] = "(" + FriendList[i].Replace(" ", ", ") + ")";  // превожу в вид (имя, фамилия)
            }

            string result = String.Join("", FriendList);                    // объединяю в строку

            return result;
        }
    }
}
