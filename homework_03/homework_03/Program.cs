using System;

namespace homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two variables and initialize them with a keyboard input
            //Console.WriteLine("Input number. I don't care what number. Please input some number ok? ");
            //string firstNum = Console.ReadLine();
            //int parsNumFirst = int.Parse(firstNum);

            //string secondNum = Console.ReadLine();
            //int parsNumSecond = int.Parse(secondNum);
            // Write code that can test which number is larger
            //if (parsNumFirst > parsNumSecond)
            //{
            //    Console.WriteLine(parsNumFirst + " is larger then " + parsNumSecond);
            //}

            //else if (parsNumFirst < parsNumSecond)
            //{
            //    Console.WriteLine(parsNumSecond + " is larger then " + parsNumFirst);
            //}
            //else
            //{
            //    Console.WriteLine(parsNumFirst + " is equal to " + parsNumSecond);
            //}
            //Write code that can test the numbers whether they are even or odd

            //if (parsNumFirst % 2 == 0)
            //{
            //    Console.WriteLine(parsNumFirst + "  is EVEN");
            //}
            //else
            //{
            //    Console.WriteLine(parsNumFirst + "  is ODD");
            //}
            //if (parsNumSecond % 2 == 0)
            //{
            //    Console.WriteLine(parsNumSecond + "  is EVEN");
            //}
            //else
            //{
            //    Console.WriteLine(parsNumSecond + "  is ODD");
            //}
            // Console.ReadLine();

            //Write the larger number from the two in the console

            int num = 3;

            if (num > 2)
            {
                Console.WriteLine(num);
                // After that write if the number is even or odd
                if (num % 2 == 0)
                {
                    Console.WriteLine("EVEN");
                }
                else
                {
                    Console.WriteLine("ODD");
                }
            }
            else
            {
                Console.WriteLine("ERROR!!!");

            }

            Console.ReadLine();
        }
    }
}
