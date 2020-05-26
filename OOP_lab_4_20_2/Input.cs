using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_20_2
{
    class Input
    {
        public static DateTime Read()
        {
            ReadTable();
            return ReadDate();
        }

        private static void ReadTable()
        {
            Console.WriteLine("Введiть данi про студентiв");
            Console.Write("Кiлькiсть записiв: ");

            for (int i = 0; i < Program.group.Length; i++)
            {
                Program.group[i] = new Student();

                Console.WriteLine("Студент №{0}:", i + 1);
                Console.Write("Прiзвище: ");
                Program.group[i].Lastname = Console.ReadLine();

                Console.Write("День народження: ");
                Program.group[i].Birthday = DateTime.Parse(Console.ReadLine());

                Console.Write("Iнiцiали: ");
                Program.group[i].Initials = Console.ReadLine();
            }
        }

        private static DateTime ReadDate()
        {
            Console.WriteLine("Введiть дату.");

            return DateTime.Parse(Console.ReadLine());
        }
    }
}
