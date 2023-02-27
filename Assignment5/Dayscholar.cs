using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface IStudent
    {
        int Stud_Id { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    class DayScholar : IStudent
    {
        public int Stud_Id { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Day Scholar Details");
            Console.WriteLine("Student ID: " + Stud_Id);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine();
        }
    }

    class Resident : IStudent
    {
        public int Stud_Id { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Resident Details");
            Console.WriteLine("Student ID: " +Stud_Id);
            Console.WriteLine("Student Name: " +Name);
            Console.WriteLine();
        }
    }

    class Interface
    {
        public static void Main()
        {
            DayScholar d = new DayScholar();

            Console.WriteLine("Enter The Student Id :");
            d.Stud_Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Student Name :");
            d.Name = Console.ReadLine();

            d.ShowDetails();

            Resident r = new Resident();

            Console.WriteLine("Enter The Student Id :");
            r.Stud_Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Student Name:");
            r.Name = Console.ReadLine();

            r.ShowDetails();

            Console.Read();
        }
    }
}