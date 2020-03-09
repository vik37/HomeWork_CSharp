using System;

namespace HomeWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 01
            //string firstName = "Viktor";
            //string lastName = "Zafirovski";
            //string fullName = firstName  +  lastName;

            //Console.WriteLine(fullName);
            //string numOne = "9";
            //string numTwo = "3";

            //int result = Int32.Parse(numOne + numTwo);
            //Console.WriteLine(result);
            //Console.ReadLine();

            // Exercise 02
            //int numInt = 23;
            //string someString = "My lucky number is: ";
            //var result = someString + numInt;
            //Console.WriteLine(result);
            //Console.ReadLine();

            // Exercise 03

            //int n = 102;
            //int m = 5;
            //int result = n / m;
            //Console.WriteLine("You can sand " + result + " SMS message");
            //Console.ReadLine();

            // Exercise 04 (* BONUS)

            Console.WriteLine("Input some number, only number");
            //string someNumber = Console.ReadLine();
            //int inputNumber;
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            //bool convertNumber = int.TryParse(someNumber, out inputNumber);
            var result = inputNumber / 2 == 0;


            if (result)
            {
                Console.WriteLine("ODD");
                Console.ReadLine();
            }
            else if (!result)
            {
                Console.WriteLine("EVEN");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("You inserted invalid input");
                Console.ReadLine();
            }

        }
    }
}
