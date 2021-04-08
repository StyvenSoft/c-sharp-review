using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 63, 78, 22, 98, 52, 74, 32 };

            int sum = 0, avg, i;

            for (i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            avg = sum / i;

            Console.WriteLine("The average is: " + avg);
            Console.ReadKey();
        }
    }
}
