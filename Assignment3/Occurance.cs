using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment31
{
    class Occurance
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inp_string = Console.ReadLine();

            Console.WriteLine("Enter the letter to count in the given string:");
            char letter = Console.ReadLine()[0];

            int cnt = CounttheOccurrences(inp_string, letter);
            Console.WriteLine($"The letter {letter} appears {cnt} times in the string.");
            Console.Read();
        }

        public static int CounttheOccurrences(string inp_string, char letter)
        {
            int cnt = 0;

            foreach (char i in inp_string)
            {
                if (i == letter)
                {
                    cnt++;
                }
            }

            return cnt;
            
        }
    }
}

