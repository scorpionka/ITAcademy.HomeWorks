using System;

namespace Flight
{
    public class Person : Airport
    {
        public const string defaultField = "NO_VALUE";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Accost => $"{FirstName} {Patronymic}";
        public string AccostNoPatronymic => $"{FirstName}";
        public string PassportData { get; set; }
        public string FlightNumber { get; set; }
        readonly private bool registrationStatus;
        public bool RegistrationStatus { get; set; }
        public Person(bool regisrationStatus)
        {
            this.registrationStatus = registrationStatus;
        }
        public bool BaggageStatus { get; set; }
        public Guid BaggageId { get; set; }
        public bool HandLuggageStatus { get; set; }
        public int TerminalNumber { get; set; }
        public Person()
        {
            FirstName = defaultField;
            LastName = defaultField;
            Patronymic = defaultField;
            PassportData = defaultField;
            FlightNumber = defaultField;
            RegistrationStatus = registrationStatus;
        }
        public Person(string lastName, string firstName, string patronymic, string passportData, string flightNumber)
        {
            try
            {
                FirstName = Char.ToUpper(firstName[0]) + firstName.Substring(1);
            }
            catch { }
            try
            {
                LastName = Char.ToUpper(lastName[0]) + lastName.Substring(1);
            }
            catch { }
            try
            {
                Patronymic = Char.ToUpper(patronymic[0]) + patronymic.Substring(1);
            }
            catch { }
            try
            {
                PassportData = passportData.ToUpper();
            }
            catch { }
            try
            {
                FlightNumber = flightNumber.ToUpper();
            }
            catch { }
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
            Console.WriteLine("Please, introduce yourself! Last name, first name, patronymic, passport details and flight number:");
            string fullData = Console.ReadLine();
            string[] fullDataSplit = fullData.Split();
            while (fullDataSplit.Length < 4 || fullDataSplit.Length > 5)
            {
                Console.WriteLine("Wrong data! Try again!");
                fullData = Console.ReadLine();
                fullDataSplit = fullData.Split();
            }
            if (fullDataSplit.Length.Equals(4))
            {
                Array.Resize(ref fullDataSplit, 5);
                fullDataSplit[4] = fullDataSplit[3];
                fullDataSplit[3] = fullDataSplit[2];
                fullDataSplit[2] = defaultField;
            }
            person = new Person(fullDataSplit[0], fullDataSplit[1], fullDataSplit[2], fullDataSplit[3], fullDataSplit[4]);
        }
        public void PrintAll()
        {
            if (!Patronymic.Equals(defaultField))
            {
                PrintData(LastName, FirstName, Patronymic, PassportData, FlightNumber);
            }
            else
            {
                PrintData(LastName, FirstName, PassportData, FlightNumber);
            }
        }
        private void PrintData(string lastName, string firstName, string patronymic, string passportData, string flightNumber)
        {
            Console.WriteLine(LastName + " " + FirstName + " " + Patronymic + " " + PassportData + " " + FlightNumber);
        }
        private void PrintData(string lastName, string firstName, string passportData, string flightNumber)
        {
            Console.WriteLine(LastName + " " + FirstName + " " + PassportData + " " + FlightNumber);
        }
        public void PersonAccost()
        {
            if (!Patronymic.Equals(defaultField))
            {
                Console.WriteLine("Dear " + Accost + "!");
            }
            else
            {
                Console.WriteLine("Dear " + AccostNoPatronymic + "!");
            }
        }
    }
}