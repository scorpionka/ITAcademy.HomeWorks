using System;

namespace Flight
{
    public class CheckIn : Airport
    {

        public void CheckRegistration(string passportDetails)
        {
            try
            {
                passportDetails = passportDetails.ToUpper();
            }
            catch { }
            if (!basePerson.Exists(x => x.PassportData == passportDetails))
            {
                Console.WriteLine("No match! Go home!");
                Environment.Exit(0);
            }
        }
    }
}
