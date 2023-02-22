using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123
{
    class Studentdb
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter Ten marks:");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            int total_marks = 0;
            int min = marks[0];
            int max = marks[0];
            for (int i = 0; i < 10; i++)
            {
                total_marks += marks[i];
                if (marks[i] < min)
                {
                    min = marks[i];
                }
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }

            double avg = (double)total_marks / 10;

            Console.WriteLine("Total marks: " + total_marks);
            Console.WriteLine("Average marks: " + avg);
            Console.WriteLine("Minimum marks: " + min);
            Console.WriteLine("Maximum marks: " + max);

            Array.Sort(marks);

            Console.WriteLine("Marks in ascending order:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Marks in descending order:");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}

