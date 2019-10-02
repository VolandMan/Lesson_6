using System;

namespace University
{
    class Program
    {
        class Student
        {
            public int AcademicDebt;
            public int iq;
            public string Name;
            public string Faculty;
            public int State;

            static void Main(string[] args)
            {
                Student stud = new Student();
                Random rnd = new Random();
                stud.AcademicDebt = rnd.Next(0, 1); // рандом академ задолжности
                stud.iq = rnd.Next(0, 100); // рандом IQ задолжности
                stud.State = rnd.Next(0, 1);  // рандом (пьяный, трезвый) задолжности

                stud.InputInfo();

                stud.GetInfo();

                Console.WriteLine($" Узнать решение по студенту ");

                Console.ReadLine();

                stud.StudStatus();

                stud.GetInfo();
            }
            public void GetInfo()
            {

                Console.Write($"Имя:{Name}\nФакультет={Faculty}\nIQ ={iq}\nАкадемическая задолжность= {AcademicDebt}\n");
                Console.WriteLine((State == 0) ? ($"{Name} трезвый!") : ($"{Name} пьяный!"));
            } // Выводим информацию

            public void StudStatus()
            {
                if ((iq < 70 && State == 1) || (State == 1 && AcademicDebt > 3) || (iq < 70 && AcademicDebt > 3))
                {
                    Console.WriteLine("ОТЧИСЛЕН!!!");

                }
                else
                {
                    Random rnd = new Random();
                    State = rnd.Next(0, 1);
                    if (State == 0)
                    {
                        iq += 10;
                    }

                }

            } // Проверяем условие  по студенту
            public void InputInfo()
            {
                Console.WriteLine("Введите Имя студента");
                Name = Console.ReadLine();
                Console.WriteLine("Введите Факультет");
                Faculty = Console.ReadLine();
            }// Входящая информация  Имя - Факультет
        }

    }

}
