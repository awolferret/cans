using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Storage storage = new Storage();
        }
    }

    class Storage
    {
        private List<Can> _cans = new List<Can> {new Can("Белорусская", 2018),new Can("Главпродукт", 2020), new Can("Армейская", 1984), new Can("Главпродукт", 2021), new Can("Армейская", 1994), new Can("Главпродукт", 2020) };

        public Storage()
        {
            CheckDate();
        }

        private void CheckDate()
        {
            int currentYear = 2022;
            var expired = _cans.Where(can => can.ExpireDate < currentYear);
            ShowExpired(expired.ToList());
        }

        private void ShowExpired(List<Can> list)
        {
            Console.WriteLine("Список просрочки:");

            foreach (var can in list)
            {
                Console.WriteLine(can.Name + " " + can.CreateDate);
            }
        }
    }

    class Can
    {
        public string Name { get; private set; }
        public int CreateDate { get; private set; }
        public int ExpireDate { get; private set; }

        public Can(string name, int date)
        {
            int expirationDate = 3;
            Name = name;
            CreateDate = date;
            ExpireDate = CreateDate + expirationDate;
        }
    }
}
