using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        public string FullName { get; set; }
        public string StudentID { get; set; }
        public double AverageGrade { get; set; }

        // Конструктор за замовчуванням
        public Student()
        {
            FullName = "Unknown";
            StudentID = "Unknown";
            AverageGrade = 0.0;
        }

        // Конструктор з параметрами
        public Student(string fullName, string studentID, double averageGrade)
        {
            FullName = fullName;
            StudentID = studentID;
            AverageGrade = averageGrade;
        }

        // Конструктор копіювання
        public Student(Student other)
        {
            FullName = other.FullName;
            StudentID = other.StudentID;
            AverageGrade = other.AverageGrade;
        }

        // Деструктор
        ~Student()
        {
            Console.WriteLine($"Об'єкт студента {FullName} знищується.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Використання конструктора за замовчуванням
            Student student1 = new Student();
            Console.WriteLine($"Студент: {student1.FullName}, Номер квитка: {student1.StudentID}, Середній бал: {student1.AverageGrade}");

            // Використання конструктора з параметрами
            Student student2 = new Student("Сидоренко Сидір", "54321", 4.9);
            Console.WriteLine($"Студент: {student2.FullName}, Номер квитка: {student2.StudentID}, Середній бал: {student2.AverageGrade}");

            // Використання конструктора копіювання
            Student student3 = new Student(student2);
            Console.WriteLine($"Студент: {student3.FullName}, Номер квитка: {student3.StudentID}, Середній бал: {student3.AverageGrade}");

            // Використання ініціалізатора об'єкта
            Student student4 = new Student
            {
                FullName = "Коваленко Катерина",
                StudentID = "98765",
                AverageGrade = 4.8
            };
            Console.WriteLine($"Студент: {student4.FullName}, Номер квитка: {student4.StudentID}, Середній бал: {student4.AverageGrade}");

            // Примусове викликання збору сміття для демонстрації деструктора
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
