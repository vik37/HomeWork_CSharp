using System;

namespace Homework_strings_date_ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeWork - Strings
            /* Task 1
             *Print individual characters of the string in reverse order. *Example: we love c# 
             * *Expected Output : #c evol ew */

            //string cSharp = "we love c#";
            //char[] charsSharp = cSharp.ToCharArray();
            //Array.Reverse(charsSharp);

            //Console.WriteLine(charsSharp);
            //Console.ReadLine();


            // Task 2
            /* *Count the total number of words in a string entered by the user. *Example: user enters 
            "I love C#" *Expected output: "I love c#" contains 3 words. */

            //string userWords = Console.ReadLine();
            //string[] splitWord = userWords.Split(" ");
            //int lengthOfWords = splitWord.Length;

            //Console.WriteLine(lengthOfWords);
            //Console.ReadLine();


            // Task 3
            /* *Find maximum occurring character in a string *Example:
             * "We want this situation with covid-19 to ends!" *Expected Output : 
             * The highest frequency of character 't' appears number of times : 6 */

            string covidNintheen = "We want this situation with covid-19 to ends!";
            char[] covidChar = covidNintheen.ToCharArray();
            
            int[] count = new int[covidChar.Length];
            int i, j; 

            for (i = 0; i < covidChar.Length; i++)
            {
                int c = 0;
                for (j = 0; j < covidChar.Length; j++)
                {
                    if (covidChar[i] == covidChar[j])
                    {
                        
                        c++;                        
                    }
                }
                count[i] = c;
            }
            
            int max = 0;
            int maxTimes = 0;
            for(i = 0;i < count.Length; i++)
            {
                if(count[i] > max)
                {
                    max = Array.IndexOf(count, count[i]);
                    maxTimes = count[i];
                    
                }
            }
          
           
            Console.WriteLine("Number of same letter is {0}", maxTimes);
            
            Console.ReadLine();


            /*  Task 4
             "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"

            * Print the whole text after "," in the console. *Bonus - Try to do that without counting the characters till "," by yourself :) */

            //string groupG1 = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            //string[] splitGone = groupG1.Split(", ");


            //Console.WriteLine(@"""No bonus"" - {0} ", splitGone[1]);
            //Console.WriteLine("----------------");
            //int indexOfGroupOne = groupG1.IndexOf("we are sure that with their deducation and passion they will be successfull programers soon!");
            //string newString = groupG1.Substring(indexOfGroupOne);

            //Console.WriteLine(@"""Bonus"" - {0} ", newString);
            //Console.ReadLine();
        }
    }
}
