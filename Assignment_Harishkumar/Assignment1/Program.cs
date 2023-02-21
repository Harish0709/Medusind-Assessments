using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5]{ 20,40,60,80,100 };

        int sum = 0;
        int min = arr[0];
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        double avg = (double)sum / arr.Length;

        Console.WriteLine("Average value of array elements: " + avg);
        Console.WriteLine("Minimum value in array: " + min);
        Console.WriteLine("Maximum value in array: " + max);
        Console.Read();
    }
}