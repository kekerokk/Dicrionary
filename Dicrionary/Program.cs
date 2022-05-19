using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicrionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание коллекции
            Dictionary<int, Student> myDict = new Dictionary<int, Student>();

            // Создание экземпляров студента и помещение их в Коллекцию List
            List<Student> students = new List<Student>()
            {
                new Student("Vasiliy", "Chekov", "3D", 5),
                new Student("Nekoglay", "Chekov", "3D", 15),
                new Student("Stepan", "Chekov", "3D", 63),
                new Student("Yzbejik", "Chekov", "3D", 23),
                new Student("Kolyan", "Chekov", "3D", 21)
            };

            // Вывод списка студентов и добавление их в коллекцию Dictionary
            for(int i = 0;i<5;i++)
            {
                //Вывод
                Console.WriteLine(students[i].toString());
                //Добавление
                myDict.Add(i, students[i]);
            }

            Console.WriteLine($"///////\nОтсортированный список:\n///////\n");

            //Удаление студентов с возрастом больше 22 и вывод в консоль результат
            for (int i = 0; i < 5; i++)
            {
                if (myDict[i].Age > 22)
                {
                    // Удаление элемента
                    myDict.Remove(i);
                    // Это нужно для того, чтобы следующий элемент прошел проверку, тк он сместится на место удаленного
                    i++;
                }
                else
                {
                    // Вывод студента в консоль, если он прошел проверку на возраст
                    Console.WriteLine(myDict[i].toString());
                }
            }


            Console.ReadLine();
        }
    }
}

