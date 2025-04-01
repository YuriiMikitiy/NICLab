using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3_
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "D:\\D--VSEducation\\NICLab\\Lab1(3)\\student.txt";

            try
            {
                //// 1. Запис у файл
                //using (StreamWriter writer = new StreamWriter(filePath))
                //{
                //    writer.WriteLine("Андрій, 2 курс");
                //    writer.WriteLine("Марія, 1 курс");
                //    writer.WriteLine("Олексій, 3 курс");
                //    writer.WriteLine("Ірина, 2 курс");
                //    Console.WriteLine("Дані успішно записано у файл.");
                //}

                // 2. Зчитування з файлу
                Console.WriteLine("\nЗчитаний вміст файлу:");
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Помилка: Файл не знайдено.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Помилка: Немає прав доступу до файлу.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }
        }
    }
}
