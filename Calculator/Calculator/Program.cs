using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            string firstNum;
            string secondNum;

            char calculationCharachter;
            double numOne;
            double numTwo;

            double resultOne;
            double resultTwo;
            double resultThree;
            double resultFour;
            Console.WriteLine("Welcome to Calculator");
           
                Console.WriteLine(@"Please input your operator (increment (""+""), decrement (""-""), multiplication (""*""), division (""/""). ");
                operation = Console.ReadLine();
                bool parseOperator = char.TryParse(operation, out calculationCharachter);
               
                Console.WriteLine(@"Please enter your first number - ""First number must be bigger then second number");            
                firstNum = Console.ReadLine();
            bool parseNumOne = double.TryParse(firstNum, out numOne);

            Console.WriteLine(@"Please enter your second number - ""Second number must be smaller then first number");
            secondNum = Console.ReadLine();
            bool parseSecondNum = double.TryParse(secondNum, out numTwo);

            if (parseOperator)
            {                
                resultOne = numOne + numTwo;
                resultTwo = numOne - numTwo;
                resultThree = numOne * numTwo;
                resultFour = numOne / numTwo;
                                
                    if (parseNumOne && parseSecondNum)
                    {
                        if (numTwo != 0)
                        {
                            if (numOne > numTwo)
                            {
                                switch (calculationCharachter)
                                {
                                    case '+':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("{0} + {1} result is: {2}", numOne,numTwo,resultOne);
                                        break;

                                    case '-':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("{0} - {1} result is: {2}", numOne, numTwo, resultTwo);
                                        break;

                                    case '*':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("{0} * {1} result is: {2}", numOne, numTwo, resultThree);
                                        break;

                                    case '/':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("{0} / {1} result is: {2}", numOne, numTwo, resultFour);
                                        break;

                                    default:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(@"Invalid operation selected."  + "\r\n" +  "The aplication will automaticly close.");
                                        break;
                                } // switch - zatvorena zagrada

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"Input ""S"" and press enter");
                                char s = char.Parse(Console.ReadLine());
                                if (s == 'S')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@"Tank you for using the calculator."  +  "\r\n"  +  " The aplication will automaticly close");
                                }
                            } // numOne < numTwo - zatvorena zagrada
                        else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("First number must be bigger then second. The aplication will automaticly close. Please try again");
                            }
                        } // num != 0 - zatvorena zagrada
                    else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Division with zero is not posible. The aplication will automaticly close");
                        }
                    } // parseNum - zatvorena zagrada
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input number. The aplication will automaticly close");
                    }
             }
                       
            Console.ReadLine();
        }
    }
}
