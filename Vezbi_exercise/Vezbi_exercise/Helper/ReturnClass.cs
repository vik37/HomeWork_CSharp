using System;
using System.Collections.Generic;
using System.Text;
using Vezbi_exercise.Students;

namespace Vezbi_exercise.Helper
{
    public class ReturnClass
    {
        public static DateTime today;
        public static int alloo;
        public ReturnClass()
        {
            Dic = new Dictionary<int, string>();
        }
        public static Dictionary<int, string> Dic { get; set; }
        public static int ReturnDate(DateTime dateOfBirth)
        {
            //int alloo;
            //if (today.Month < dateOfBirth.Month)
            //{
                alloo = dateOfBirth.Year - today.Year;
            //}
                
            
            return alloo;
        }
        public static Dictionary<int, string> ReturnFirstNames(List<Children> someStudents)
        {
            //int numberer = 5;
            //Dictionary<int, string> Dic = new Dictionary<int, string>() {  };
            foreach(var student in someStudents)
            {
                Dic.Add(student.Grades,student.LastName);
            }
            return Dic;
        }
    }
}
