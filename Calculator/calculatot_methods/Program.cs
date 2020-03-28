using System;

namespace calculatot_methods
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
           
            Console.WriteLine("Welcome to Calculator");
           // INPUTS I PARSENUMBER
            Console.WriteLine(@"Please input your operator (increment (""+""), decrement (""-""), multiplication (""*""), division (""/""), modul(""%"") ");
            operation = Console.ReadLine();
            bool parseOperator = char.TryParse(operation, out calculationCharachter);

            Console.WriteLine(@"Please enter your first number - ""First number must be bigger then second number");
            firstNum = Console.ReadLine();
            bool parseNumOne = double.TryParse(firstNum, out numOne);

            Console.WriteLine(@"Please enter your second number - ""Second number must be smaller then first number");
            secondNum = Console.ReadLine();
            bool parseSecondNum = double.TryParse(secondNum, out numTwo);

            // (METODI - (ARGUMENT1, ARGUMENT2)
            double resultOne = CalculationIncrement(numOne, numTwo);
            double resultTwo = CalculationDecrement(numOne, numTwo);
            double resultThree = CalculationMultiplication(numOne, numTwo);
            double resultFour = CalculationDivision(numOne, numTwo);
            double modulResult = CalculationModuls(numOne, numTwo);

            if (parseOperator)
            {               
                if (parseNumOne && parseSecondNum)
                {
                    if (numTwo != 0)
                    {
                        if (numOne > numTwo)
                        {

                            if (calculationCharachter == '+')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0} + {1} result is: {2}", numOne, numTwo, resultOne);
                            }
                            else if (calculationCharachter == '-')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0} - {1} result is: {2}", numOne, numTwo, resultTwo);
                            }
                            else if (calculationCharachter == '*')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0} * {1} result is: {2}", numOne, numTwo, resultThree);
                            }
                            else if (calculationCharachter == '/')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0} / {1} result is: {2}", numOne, numTwo, resultFour);
                            }
                            else if (calculationCharachter == '%')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0} / {1} result is: {2}", numOne, numTwo, modulResult);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(@"Invalid operation selected." + "\r\n" + "The aplication will automaticly close.");
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"Input ""S"" and press enter");
                            char s = char.Parse(Console.ReadLine());
                            if (s == 'S')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"Tank you for using the calculator." + "\r\n" + " The aplication will automaticly close");
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

        // + FUNCTION INCREMENT
        public static double CalculationIncrement(double one, double two)
        {
            double result;
            result = one + two;            
                return result;                                   
        }
        // - FUNCTION DECREMENT
        public static double CalculationDecrement(double one, double two)
        {
            double result;
            result = one - two;
            return result;
        }
        // * FUNCTION MULTIPLICATION
        public static double CalculationMultiplication(double one, double two)
        {

            double result;
            result = one * two;
            return result;
        }
        // / FUNCTION DIVISION
        public static double CalculationDivision(double one, double two)
        {
            double result;
            result = one + two;
            return result;
        }
        public static double CalculationModuls(double one, double two)
        {
            double result;
            result = one % two;
            return result;
        }
    }
}
