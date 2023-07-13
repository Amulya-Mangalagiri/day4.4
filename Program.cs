using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] studMarks = new int[4, 5];

            Console.WriteLine("Enter the marks for each student and semester:");

            // Taking input for each student and semester
            for (int i = 0; i < studMarks.GetLength(0); i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                for (int j = 0; j < studMarks.GetLength(1); j++)
                {
                    Console.Write($"Enter marks for Semester {j}: ");
                    studMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nRollNo Sem1 Sem2 Sem3 Sem4 Total");

            // Printing the details of each student
            for (int i = 0; i < studMarks.GetLength(0); i++)
            {
                int totalMarks = 0;

                for (int j = 0; j < studMarks.GetLength(1); j++)
                {
                    Console.Write(studMarks[i, j] + " ");

                    if (j != 0)
                    {
                        totalMarks += studMarks[i, j];
                    }
                }

                Console.WriteLine(totalMarks);
            }

            Console.ReadLine();
        }
    }
}
