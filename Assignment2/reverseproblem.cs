using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class reverseproblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string s = Console.ReadLine();
            string reversedtext = "";
            for (int i = s.Length - 1; i >= 0; i--) {
                reversedtext += s[i];
        }
        Console.WriteLine("The reverse of the Text is " + reversedtext );
        Console.ReadLine(); 
    }
}
    }

