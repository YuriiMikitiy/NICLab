
using Lab1Interfaces;
using Lab1VB;
using System;


namespace Lab1_4_
{
    public class Program
    {
        static void Main()
        {
            ICLSCompliant csharpClass = new CLSCompliantClass();
            ICLSCompliant vbClass = new CLSCompliantClassVB(); // Потрібно додати VB.NET-складову

            DateTime birthDate = new DateTime(2000, 5, 15);

            Console.WriteLine("=== C# клас ===");
            Console.WriteLine($"Рік народження: {csharpClass.GetYearOfBirth(birthDate)}");
            Console.WriteLine($"Повне ім'я: {csharpClass.GetFullName("Андрій", "Коваленко")}");
            csharpClass.DisplayInfo("Андрій", 24);

            Console.WriteLine("\n=== VB.NET клас ===");
            Console.WriteLine($"Рік народження: {vbClass.GetYearOfBirth(birthDate)}");
            Console.WriteLine($"Повне ім'я: {vbClass.GetFullName("Марія", "Іваненко")}");
            vbClass.DisplayInfo("Марія", 22);
        }
    }

}
