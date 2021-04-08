using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseOfaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse;

            Console.WriteLine("Enter a Number: ");

            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                reverse = num % 10;

                num = num / 10;
                Console.Write(reverse);
            }

            Console.ReadKey();
        }
    }
}
