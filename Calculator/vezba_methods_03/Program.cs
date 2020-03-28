using System;

namespace vezba_methods_03
{
    class Program
    {
        static void Main(string[] args)
        {
              int firstNumber;
              int secondNumber;
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            bool parseOne = int.TryParse(num1, out firstNumber);
            bool parseTwo = int.TryParse(num2, out secondNumber);
            int result = Sum(firstNumber, secondNumber);
            Console.WriteLine(result);
            if(result != 5)
            {
                Console.WriteLine("dfdsfjhdjkfhds.k");
            }
            Console.ReadLine();
        }
        public static int Sum(int first, int second)
        {
            int resultOne = first + second;
            int resultTwo = first - second;
            if (resultOne > resultTwo)
            {
                return resultOne;
            }
            return resultTwo;
        }

    }
}
