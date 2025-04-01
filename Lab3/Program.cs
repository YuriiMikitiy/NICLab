using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}, Рік: {Year}");
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public void Display()
        {
            Console.WriteLine($"Коло з центром у ({Center.X}, {Center.Y}) та радіусом {Radius}");
        }
    }

    public enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Літак летить.");
        }
    }

    public delegate int MathOperation(int a, int b);

    public class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
    }


    public class Program
    {
        static void Main(string[] args)
        {
            //Використання класу
            Console.WriteLine("Використання класу: ");
            Book book1 = new Book { Title = "1984", Author = "George Orwell", Year = 1949 };
            Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 };

            book1.DisplayInfo(); // Виведе: Книга: 1984, Автор: George Orwell, Рік: 1949
            book2.DisplayInfo(); // Виведе: Книга: To Kill a Mockingbird, Автор: Harper Lee, Рік: 1960

            // Використання структури
            Console.WriteLine("Використання структури: ");
            Point point1 = new Point(3, 4);
            point1.Display(); // Виведе: Точка: (3, 4)

            // Використання класу Circle
            Console.WriteLine("Використання класу Circle: ");
            Circle circle1 = new Circle(point1, 5.5);
            circle1.Display(); // Виведе: Коло з центром у (3, 4) та радіусом 5.5


            //Використання перерахування
            Console.WriteLine("Використання перерахування: ");
            TrafficLightColor currentColor = TrafficLightColor.Red;

            switch (currentColor)
            {
                case TrafficLightColor.Red:
                    Console.WriteLine("Стій! Червоний сигнал."); //Виведеться це повідомлення
                    break;
                case TrafficLightColor.Yellow:
                    Console.WriteLine("Приготуйся! Жовтий сигнал.");
                    break;
                case TrafficLightColor.Green:
                    Console.WriteLine("Рухайся! Зелений сигнал.");
                    break;
            }

            //Використання інтерфейсу
            Console.WriteLine("Використання інтерфейсу: ");
            IFlyable flyableObject = new Airplane();
            flyableObject.Fly(); // Виведе: Літак летить.

            //Використання делегата
            Console.WriteLine("Використання делегата: ");
            MathOperation operation = Calculator.Add;
            Console.WriteLine(operation(5, 3)); // Виведе: 8

            operation = Calculator.Subtract;
            Console.WriteLine(operation(5, 3)); // Виведе: 2

            operation = Calculator.Multiply;
            Console.WriteLine(operation(5, 3)); // Виведе: 15

        }
    }
}
