using System;

namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# Sharp program to find the sum of first 10 natural numbers
            //*Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10

            //int sum = 1;
            //for (int i = 0; i <= 10; i++){
            //    sum = sum + i;
            //    Console.WriteLine(sum);
            //    Console.ReadLine();
            //}

            //2. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            // PART 1 (NO ARRAY)
            
            //int sum = 1;
            //Console.WriteLine("Enter some numbers ");
            //int inputNum = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= inputNum; i++)
            //{
            //    inputNum += sum + i;
            //    Console.WriteLine("------------------");
            //    Console.WriteLine(inputNum);
            //    Console.ReadLine();

            //    if (inputNum > 20)
            //    {
            //        break;

            //    }

            //}

            //int avg = inputNum / 10;
            //    Console.WriteLine("------------------");
            //    Console.WriteLine("Averige :" + inputNum);
            //    Console.ReadLine();

            // PART 2 (with ARRAY) 

            int[] numbers = new int[] { };

            int index = 0;


            while (true)
            {
                Console.WriteLine("Write 10 numbers");
                Console.WriteLine("------------------");

                string inputNum = Console.ReadLine();
                int n = int.Parse(inputNum);
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[index] = n;


                if (numbers.Length >= 10)
                {

                    n += numbers[index];
                    Console.WriteLine("------------------");
                    Console.WriteLine("Sum of all numbers is:" + n);
                    Console.ReadLine();
                    double avg = n / 10.0;
                    Console.WriteLine("------------------");
                    Console.WriteLine("Averige:" + avg);
                    Console.ReadLine();


                    break;
                }
                //
                index++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                Console.ReadLine();

            }

        }
    }
}
