using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_20_2
{
    class Output
    {
        public static void Write(DateTime date)
        {

            WriteNearest(date);
            WriteFutureBirthdays(date);
        }

        private static void WriteNearest(DateTime date)
        {
            int[] dateDifferences = new int[Program.group.Length];

            for (int i = 0; i < dateDifferences.Length; ++i)
            {
                dateDifferences[i] = Math.Abs(Program.group[i].Birthday.DayOfYear - date.DayOfYear);
            }

            int minIndex = 0;

            for (int i = 0; i < dateDifferences.Length; ++i)
            {
                if (dateDifferences[minIndex] >= dateDifferences[i])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine("Студент з найближчим днем народження:");
            Console.WriteLine("{0, -15} {1, -20} {2, -10}", "Прiзвище", "Дата народження", "Iнiцiали");
            Console.WriteLine("{0, -15} {1, -20} {2, -10}", Program.group[minIndex].Lastname, Program.group[minIndex].Birthday.ToShortDateString(), Program.group[minIndex].Initials);
        }

        private static void WriteFutureBirthdays(DateTime date)
        {
            int[] dateDifferences = new int[Program.group.Length];

            for (int i = 0; i < dateDifferences.Length; ++i)
            {
                dateDifferences[i] = Program.group[i].Birthday.DayOfYear - date.DayOfYear;
            }

            Console.WriteLine("Студенти, в яких ще буде день народження цього року:");
            Console.WriteLine("{0, -15} {1, -20} {2, -10}", "Прiзвище", "Дата народження", "Iнiцiали");

            for (int i = 0; i < dateDifferences.Length; ++i)
            {
                if (dateDifferences[i] > 0)
                {
                    Console.WriteLine("{0, -15} {1, -20} {2, -10}", Program.group[i].Lastname, Program.group[i].Birthday.ToShortDateString(), Program.group[i].Initials);
                }
            }
        }
    }
}
