using System;
using System.Collections.Generic;
using Vezbi_exercise.Helper;
using Vezbi_exercise.Students;

namespace Vezbi_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Children> someStudents = new List<Children>() { 
                new Children() {FirstName = "Pero",LastName = "Goshev",Grades = 2, DateOfBirth = new DateTime(1973, 4, 15) },
                new Children() {FirstName = "Pablo",LastName = "Eskobar",Grades = 4, DateOfBirth = new DateTime(1989, 12, 12) },
                new Children() {FirstName = "Goce",LastName = "Delcev",Grades = 5, DateOfBirth = new DateTime(2003, 4, 5) },
                new Children() {FirstName = "Goce",LastName = "Sedlovski",Grades = 3, DateOfBirth = new DateTime(1998, 8, 7) },
                new Children() {FirstName = "Biljana",LastName = "Crvenkovska",Grades = 5, DateOfBirth = new DateTime(2014, 9, 23) },
                  };
            someStudents.ForEach(s => s.ShowAge());
            foreach (var student in someStudents)
            {
                Console.WriteLine(ReturnClass.ReturnFirstNames(someStudents));
            }
            
            //foreach (var item in someStudents)
            //{

            //}
            Console.ReadLine();
        }
    }
}
