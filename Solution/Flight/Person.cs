using System;

namespace Flight
{
    class Person : Airport
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        private string _accost;
        public string Accost
        {
            get
            {
                string[] buildAccost = new string[2];
                buildAccost[0] = FirstName;
                buildAccost[1] = Patronymic;
                if (!Patronymic.Equals("NONAME"))
                {
                    _accost = String.Join(" ", buildAccost);
                }
                else _accost = buildAccost[0];
                return _accost;
            }
            set
            {
                _accost = value;
            }
        }

        private string passportData;
        private int flightNumber;

        public void Greeting()
        {
            TimeSpan timeNow = DateTime.Now.TimeOfDay;
            int hourNow = timeNow.Hours;

            if (hourNow >= 9 && hourNow < 12)
            {
                Console.WriteLine("Good morning!");
            }

            else if (hourNow >= 12 && hourNow < 15)
            {
                Console.WriteLine("Good day!");
            }

            else if (hourNow >= 15 && hourNow < 22)
            {
                Console.WriteLine("Good evening!");
            }

            else Console.WriteLine("Good night!");

            Console.WriteLine("Welcome to Minsk Airport!");
        }

        public void GetFullName()
        {
            Console.WriteLine("Please, introduce yourself! Second name, first name, patronymic:");
            string fullName = Console.ReadLine();
            string[] fullNameSplit = fullName.Split();
            while (fullNameSplit.Length < 2 || fullNameSplit.Length > 3)
            {
                Console.WriteLine("Wrong full name! Try again!");
                fullName = Console.ReadLine();
                fullNameSplit = fullName.Split();
            }
            SecondName = fullNameSplit[0].ToUpper();
            FirstName = fullNameSplit[1].ToUpper();
            if (fullNameSplit.Length.Equals(3))
            {
                Patronymic = fullNameSplit[2].ToUpper();
            }
            else Patronymic = "NONAME";
        }

        public void PersonAccost()
        {
            Console.WriteLine("Dear " + Accost + "!");
        }

        public void GetPassportAndFlight()
        {
            Console.WriteLine("Please, tell us your passport and flight details:");
        }
    }
}