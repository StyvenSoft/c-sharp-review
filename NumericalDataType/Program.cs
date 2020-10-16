using System;

namespace NumericalDataType
{
    class Program
    {
        static void Main(string[] args)
        {
                /** NUMERICAL DATA TYPE  */


            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            double revenue = 390819.28;

            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);
            // Signed integers 
            sbyte myInt8  = 2; // -128   to +127 
            short myInt16 = 1; // -32768 to +32767 
            int   myInt32 = 0; // -2^31  to +2^31-1 
            long  myInt64 =-1; // -2^63  to +2^63-1
            
            Console.WriteLine(myInt8);
            Console.WriteLine(myInt16);
            Console.WriteLine(myInt32);
            Console.WriteLine(myInt64);

                /** ARITHMETIC OPERATORS */


                // Your Age
            int userAge = 30;

            int answer = 4 + 19;
            Console.WriteLine(answer);

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge/jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge/jupiterYears;

            // Log calculations to console
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

                /** OPERATOR SHORTCUTS */


            int apple = 0;
            apple = apple + 1;
            Console.WriteLine(apple); // prints 1

            // a shorter way to do the same thing 
            apple++;
            Console.WriteLine(apple); // prints 1

            apple += 3; // is the same as apple = apple + 3
            Console.WriteLine(apple); // prints 3

            // declare steps variable
            int steps = 0;

            // Two steps forward 
            steps += 2;

            // One step back 
            steps--;

            // Print result to the console
            Console.WriteLine(steps);


                /** MODULO */


            int eggs = 56;
            int crateAmount = 12;

            int eggsLeftOver = eggs % crateAmount; 
            Console.WriteLine(eggsLeftOver); // prints 8

            int myNum = 85939824;
            Console.WriteLine(myNum % 2); // prints 0, so number is even

            // Example
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);

            /** BUILT-IN METHODS */

            /**
                Math.Abs()—Encontrará el valor absoluto de un número. 
                    Ejemplo: Math.Abs(-5)devuelve 5.
                Math.Sqrt()— Hallará la raíz cuadrada de un número. 
                    Ejemplo: Math.Sqrt(16)devuelve 4.
                Math.Floor()— Redondeará el doble o decimal dado al número entero más cercano. 
                    Ejemplo: Math.Floor(8.65)devuelve 8.
                Math.Min(): Devuelve el menor de dos números. 
                    Ejemplo: Math.Min(39, 12)devuelve 12.
            */

            // Create variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));

            /** USING DOCUMENTATION */

            // Math.Pow()
            // Math.Max()
            // Math.Ceiling()

            double numberOne = 6.5;
            double numberTwo = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));

            // 1785.0625
            // 7
            // 6.5

            // BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max
        }
    }
}
