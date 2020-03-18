using System;

namespace task0102
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes.

            //int[] array = new int[10] { 23, 56, 8, 12, 3, 21, 19, 37, 9, 10 };

            //int max = array[0];
            //int min = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (max < array[i])
            //    {
            //        max = array[i];
            //    }

            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (min > array[i])
            //    {
            //        min = array[i];
            //    }
            //}
            //int indexOfMax = Array.IndexOf(array, max);
            //int indexOfMin = Array.IndexOf(array, min);
            //Console.WriteLine("Maximum number is: " + max + " and his index is: " + indexOfMax);
            //Console.WriteLine("Minimum number is: " + min + " and his index is: " + indexOfMin);

            //Console.ReadLine();

            //4.arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            // Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            //int[] arrayWithDuplicates = new int[10] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };

            //int count = 0;
            //int i, j;

            //for (i = 0; i < arrayWithDuplicates.Length; i++)
            //{
            //    for (j = 0; j < i; j++)
            //    {
            //        if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
            //        {
            //            Console.WriteLine("DUPLICATE = {0}", arrayWithDuplicates[j]);
            //            count++;
            //            break;

            //        }

            //    }
            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Duplicate number Present in arrayWithDuplicates is = {0}", count);
            //Console.ReadLine();

            //5. oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            // Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            //int[] oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            //int countEven = 0, countOdd = 0;

            //int[] oddArray = new int[oddEvenArray.Length];
            //int[] evenArray = new int[oddEvenArray.Length];
            //int i;

            //foreach (int element in oddEvenArray)
            //{
            //    Console.WriteLine("Number is ={0}", element);
            //    Console.ReadLine();
            //}

            //for (i = 0; i < oddEvenArray.Length; i++)
            //{
            //    if (oddEvenArray[i] % 2 == 0)
            //    {
            //        oddArray[countOdd] = oddEvenArray[i];
            //        countOdd++;

            //    }
            //    else
            //    {
            //        evenArray[countEven] = oddEvenArray[i];
            //        countEven++;


            //    }


            //}
            //Console.WriteLine("|ODD Numbers are:_____|");
            //Console.WriteLine("-----------------------");
            //Console.ReadLine();

            //foreach (int element in oddArray)
            //{

            //    Console.WriteLine("Odd Numbers is:" + element, Console.BackgroundColor = ConsoleColor.DarkRed);
            //    Console.ReadLine();
            //}
            //Console.WriteLine("|EVEN Numbers are:_____|");
            //Console.WriteLine("-----------------------");
            //Console.ReadLine();
            //foreach (int element in evenArray)
            //{
            //    Console.WriteLine("Even Numbers is" +
            //        ":" + element, Console.BackgroundColor = ConsoleColor.Magenta);
            //    Console.ReadLine();
            //}

            //6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            // the day with strings.Example: user enters 1, you should print Monday.

            //Console.WriteLine("CHOICE YOUR DAY WITH NUMBER (1 - 7) AND WRITE BELLOW!!!");
            //Console.WriteLine("---------------------------------------------------------");

            //int number = int.Parse(Console.ReadLine());

            //int days = number;

            //    switch (days)
            //    {

            //        case 1:
            //            Console.WriteLine("Mondey");
            //            break;
            //        case 2:
            //            Console.WriteLine("Tuesday");
            //            break;
            //        case 3:
            //            Console.WriteLine("Wednesday");
            //            break;
            //        case 4:
            //            Console.WriteLine("Thursday");
            //            break;
            //        case 5:
            //            Console.WriteLine("Friday");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sathurday");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sundey");
            //            break;
            //        default:

            //            Console.WriteLine("ERROR!!!.... Please enter number from 1 to 7.", Console.ForegroundColor = ConsoleColor.Red);
            //            break;
            //    }


            //         Console.ReadLine();

        }
    }
}
