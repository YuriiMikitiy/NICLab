using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            // Робота з класом Console
            Console.WriteLine("Введіть ваше ім'я:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привіт, {name}!");

            // Робота з класом String
            string text = "Hello, World!";
            Console.WriteLine($"Довжина рядка: {text.Length}");
            Console.WriteLine($"Підрядок: {text.Substring(0, 5)}");

            // Робота з класом Int32
            Console.WriteLine("Введіть число:");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Ваше число: {number}");

            // Робота з класом DateTime
            DateTime now = DateTime.Now;
            Console.WriteLine($"Поточна дата та час: {now}");
            Console.WriteLine($"Дата через 7 днів: {now.AddDays(7)}");

            // Робота з класом Random
            Random random = new Random();
            Console.WriteLine($"Випадкове число: {random.Next(1, 100)}");

            // Робота з колекціями
            List<string> fruits = new List<string> { "Яблуко", "Банан", "Апельсин" };
            Console.WriteLine("Фрукти:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Анна", 25 },
            { "Іван", 30 }
        };
            Console.WriteLine("Вік Івана: " + ages["Іван"]);

            // Робота з файлами
            string filePath = "D:\\D--VSEducation\\NICLab\\Lab1(3)\\student.txt";
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{name}, 2 курс");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
