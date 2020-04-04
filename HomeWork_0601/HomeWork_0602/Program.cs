using System;

namespace HomeWork_0602
{

    class FirstCourse
    {
        public string Name;
        public bool Pass;

        
        public bool IsPassed()
        {
            return Pass;
        }
    }
    class SecondCourse
    {
        public string Name;
       
        public Grades Grade;
        
              
        public bool IsPassed()
        {
            if(Grade != Grades.NoPassGrade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    
    class Project
    {
        public FirstCourse FirstFirstCuerse;
        public FirstCourse SecondFirstCuerse;
        public SecondCourse FirstSecondCuerse;
        public SecondCourse SecondSecondCuerse;

        public void IsPassed()
        {
            var firstChack = FirstFirstCuerse.IsPassed();
            var secondChack = SecondFirstCuerse.IsPassed();
            var thirdChack = FirstSecondCuerse.IsPassed();
            var fourthChack = SecondSecondCuerse.IsPassed();
            var finalChack = new bool[] { firstChack, secondChack, thirdChack, fourthChack };
            var sum = 0;

            foreach (var item in finalChack)
            {
                if(item == true)
                {
                    sum++;
                }
            }
            if(sum >= 3)
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("NOT PASSED");
            }
        }

    }
    public enum Grades
    {
        NoPassGrade = 5,
        LowerGrade,
        LowGrade,
        MediumGrade,
        HigtGrade,
        ExcellentGrade
    }
    class Program
    {
        static void Main(string[] args)
        {
            var course1 = new FirstCourse();
            course1.Name = "Java Script Beggin";
            course1.Pass = true;
            
            var course2 = new FirstCourse();
            course2.Name = "JavaScript Advanced";
            course2.Pass = false;
           
            var course3 = new SecondCourse();
            course3.Name = "C Sharp Beggin";
            course3.Grade = Grades.ExcellentGrade;
            
            var course4 = new SecondCourse();
            course4.Name = "C Sharp Advanced";           
            course4.Grade = Grades.HigtGrade;

            Project final = new Project()
            {
                FirstFirstCuerse = course1,
                SecondFirstCuerse = course2,
                 FirstSecondCuerse = course3,
                SecondSecondCuerse = course4
            };
            final.IsPassed();
            
            Console.ReadLine();
        }
    }
}
