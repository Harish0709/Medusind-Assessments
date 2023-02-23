using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program123
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lName = Console.ReadLine();

            Program123 pro = new Program123();
            Display(fName.ToUpper(),lName.ToUpper());
        }

        public static void Display(string fName, string lName)
        {
            Console.WriteLine(fName);
            Console.WriteLine(lName);
            Console.Read();
        }
    }
}
    
