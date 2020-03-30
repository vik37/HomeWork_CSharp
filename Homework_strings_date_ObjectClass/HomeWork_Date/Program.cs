using System;

namespace HomeWork_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 5
            //*Display the Day properties (year, month, day, hour, minute, second) from the today's date. *Expected Output : *year = 2020
            //*month = 3
            //*day = 26
            //*hour = 23
            //*minute = 12
            //*second = 22 

            // var today = DateTime.Now;

            //int year = today.Year;
            //int month = today.Month;
            //int day = today.Day;
            //int hour = today.Hour;
            //int minute = today.Minute;
            //int second = today.Second;

            //string s = " *year = {0}, \n *month = {1}, \n *day = {2}, \n *hour = {3}, \n *minute = {4}, \n *second = {5}";
            //Console.WriteLine(s,year,month,day,hour,minute,second);
            //Console.ReadLine();


            //  Task 6
            // * Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year. * 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.

            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)

            // PRV NACIN 
            var today = DateTime.Now;
            int year = today.Year;
            int yearTwoThousand = 2008;
            int four = 4;
            
            for(int i = yearTwoThousand; i <= year; i++)
            {
                Console.WriteLine(i + " is a leap year");
                i = i + four -1;
            }
            Console.ReadLine();

            // VTOR NACIN
            for (int y = 2000; y <= 2010; y++)
            {
                if (DateTime.IsLeapYear(y))
                {
                    Console.WriteLine("{0} is a Leap Year.", y);
                }
            }
            Console.ReadLine();
        }
    }
}
