using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2_
{
    class Student
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Student(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return $"Ім'я: {Name}, Рік навчання: {Year}";
        }
    }

    public class Program
    {
        static void Main()
        {
            // 1. Створення списку студентів
            List<Student> students = new List<Student>
            {
            new Student("Андрій", 2),
            new Student("Марія", 1),
            new Student("Олексій", 3),
            new Student("Ірина", 2)
            };

            // 2. Додавання нового студента
            students.Add(new Student("Віктор", 1));

            // 3. Видалення студента (наприклад, студента на 1 курсі)
            students.RemoveAll(s => s.Year == 1);

            // 4. Пошук студента за ім'ям
            Student foundStudent = students.FirstOrDefault(s => s.Name == "Ірина");
            if (foundStudent != null)
            {
                Console.WriteLine($"\nЗнайдено студента: {foundStudent}");
            }
            else
            {
                Console.WriteLine("\nСтудента не знайдено.");
            }

            // 5. Сортування за ім'ям
            students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));

            Console.WriteLine("\nСписок студентів після сортування за ім'ям:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // 6. Сортування за роком навчання (в порядку спадання)
            students = students.OrderByDescending(s => s.Year).ToList();

            Console.WriteLine("\nСписок студентів після сортування за роком навчання:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }

}
