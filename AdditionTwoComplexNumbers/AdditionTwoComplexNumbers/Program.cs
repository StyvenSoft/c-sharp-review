using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTwoComplexNumbers
{
    class MyComplex
    {
        int r, i;

        public MyComplex(int r, int i)
        {
            this.r = r;
            this.i = i;
        }

        public void show()
        {
            Console.WriteLine(r + "+" + i + "i");
            Console.ReadKey();
        }

        public static MyComplex operator + (MyComplex Comp1, MyComplex Comp2)
        {
            MyComplex Comp3 = new MyComplex(Comp1.r + Comp2.r, Comp1.i + Comp2.i);

            return Comp3;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyComplex C1 = new MyComplex(5, 4);
            MyComplex C2 = new MyComplex(10, 3);
            MyComplex C3 = C1 + C2;
            Console.WriteLine("The addition of the two complex numbers is: ");
            C3.show();
        }
    }
}
