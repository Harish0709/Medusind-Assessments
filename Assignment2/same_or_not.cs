using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class same_or_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Word:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Word:");
            string s2 = Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are not the same.");
            }
            Console.ReadLine();
        }
    }
}

