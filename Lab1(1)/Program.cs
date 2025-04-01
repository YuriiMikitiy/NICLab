using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Оголошення та ініціалізація змінних
            int int1 = 10;
            double double1 = 5.5;
            string string1 = "Hello, C#";
            bool bool1 = true;
            char char1 = 'A';
            DateTime dateTime1 = DateTime.Now;
            decimal decimal1 = 100.25m;

            // Арифметичні операції
            int sum = int1 + (int)double1;
            double division = double1 / 2;
            decimal multiplication = decimal1 * (decimal)double1;

            // Логічні операції
            bool andOperation = bool1 && false;
            bool orOperation = bool1 || false;
            bool notOperation = !bool1;

            // Порівняльні операції
            bool isGreater = int1 > double1;
            bool isEqual = string1 == "Hello, C#";
            bool isNotEqual = char1 != 'B';

            // Приведення типів
            double castToDouble = (double)int1;
            int castToInt = (int)double1;
            string castToString = decimal1.ToString();
            char castToChar = (char)(int1 + 65); // Конвертація числа у символ Unicode

            // Виведення результатів
            Console.WriteLine("=== Арифметичні операції ===");
            Console.WriteLine($"Сума int і double (з приведенням): {sum}");
            Console.WriteLine($"Ділення double: {division}");
            Console.WriteLine($"Множення decimal і double (з приведенням): {multiplication}");

            Console.WriteLine("\n=== Логічні операції ===");
            Console.WriteLine($"AND: {andOperation}");
            Console.WriteLine($"OR: {orOperation}");
            Console.WriteLine($"NOT: {notOperation}");

            Console.WriteLine("\n=== Порівняльні операції ===");
            Console.WriteLine($"int > double: {isGreater}");
            Console.WriteLine($"string == 'Hello, C#': {isEqual}");
            Console.WriteLine($"char != 'B': {isNotEqual}");

            Console.WriteLine("\n=== Приведення типів ===");
            Console.WriteLine($"int -> double: {castToDouble}");
            Console.WriteLine($"double -> int: {castToInt}");
            Console.WriteLine($"decimal -> string: {castToString}");
            Console.WriteLine($"int -> char: {castToChar}");

            Console.WriteLine("\n=== Дата та час ===");
            Console.WriteLine($"Поточний час: {dateTime1}");
        }
    }
}
