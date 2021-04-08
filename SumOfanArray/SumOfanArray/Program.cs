using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 65, 56, 85, 63, 45, 22, 84, 65, 42, 88, 54};

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("The sum of the elements is: " + sum);
            Console.ReadKey();

        }
    }
}
