using Lab1Interfaces;
using System;


namespace Lab1_4_
{
    public class CLSCompliantClass : ICLSCompliant
    {
        public int GetYearOfBirth(DateTime birthDate)
        {
            return birthDate.Year;
        }

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public void DisplayInfo(string name, int age)
        {
            Console.WriteLine($"Ім'я: {name}, Вік: {age}");
        }
    }

}
