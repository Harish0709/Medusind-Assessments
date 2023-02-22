using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class lengthproblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Text:");
            string s = Console.ReadLine();
            int length = s.Length;
            Console.WriteLine("The length of the Text is " + length );
            Console.ReadLine(); 
        }
    }
}

