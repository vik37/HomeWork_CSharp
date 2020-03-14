using System;

namespace homwork0402
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get an input from the console
            string strNumOne = Console.ReadLine();
            int numOne = int.Parse(strNumOne);
            int count = 2;

            // Print all even numbers from the console
            while (count < numOne)  
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }

                count++;
            }
            Console.ReadLine();

            //Get another number from the console

            //string strNumTwo = Console.ReadLine();
            //int numTwo = int.Parse(strNumTwo);

            //Print all odd numbers starting from 1

            //int count = 0;
            //while(count < numTwo)
            //{
            //    if(count % 2 != 0)
            //    {
            //        Console.WriteLine(count);

            //    }
            //    count++;
            //}
            //Console.ReadLine();
        }
    }
 }
