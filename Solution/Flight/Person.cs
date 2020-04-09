using System;
using System.Reflection.PortableExecutable;

namespace Flight
{
    class Person : Airport
    {
        public const string defaultField = "NO_VALUE";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        private string _accost;
        public string Accost
        {
            get
            {
                string[] buildAccost = new string[2];
                buildAccost[0] = FirstName;
                if (!Patronymic.Equals(defaultField))
                {
                    buildAccost[1] = Patronymic;
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
        public string PassportData { get; set; }
        public string FlightNumber { get; set; }

        public Person()
        {
            FirstName = defaultField;
            LastName = defaultField;
            Patronymic = defaultField;
            PassportData = defaultField;
            FlightNumber = defaultField;
        }

        public Person(string lastName, string firstName, string patronymic, string passportData, string flightNumber)
        {
            if (!firstName.Equals(null))
            {
                FirstName = Char.ToUpper(firstName[0]) + firstName.Substring(1);
            }
            if (!lastName.Equals(null))
            {
                LastName = Char.ToUpper(lastName[0]) + lastName.Substring(1);
            }
            if (!patronymic.Equals(null))
            {
                Patronymic = Char.ToUpper(patronymic[0]) + patronymic.Substring(1);
            }
            if (!passportData.Equals(null))
            {
                PassportData = passportData.ToUpper();
            }
            if (!flightNumber.Equals(null))
            {
                FlightNumber = flightNumber.ToUpper();
            }
        }
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
        public void GetFullData(ref Person person)
        {
            Console.WriteLine("Please, introduce yourself! Last name, first name, patronymic, your passport and flight details:");
            string fullData = Console.ReadLine();
            string[] fullDataSplit = new string[5];
            fullDataSplit = fullData.Split();
            while (fullDataSplit.Length < 2 || fullDataSplit.Length > 5)
            {
                Console.WriteLine("Wrong data! Try again!");
                fullData = Console.ReadLine();
                fullDataSplit = fullData.Split();
            }
            person = new Person(fullDataSplit[0], fullDataSplit[1], fullDataSplit[2], fullDataSplit[3], fullDataSplit[4]);
        }
        public void PrintAll()
        {
            Console.WriteLine(LastName + " " + FirstName + " " + Patronymic + " " + PassportData + " " + FlightNumber);
        }
        public void PersonAccost()
        {
            Console.WriteLine("Dear " + Accost + "!");
        }
    }
}