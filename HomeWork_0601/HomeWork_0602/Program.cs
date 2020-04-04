using System;

namespace HomeWork_0602
{

    class FirstCourse
    {
        public string Name;
        public bool Pass;

        public SecondCourse CourseTwo;
        public Grades grade;
        Project project;
        public FirstCourse()
        {

        }
        public FirstCourse(string name, bool pass)
        {
            Name = name;
            Pass = pass;
        }
        public void IsPassed()
        {
            if (Pass)
            {
                Console.WriteLine($"Student have grade: {grade} and he is Pass the cuerse.");
            }
            else
            {
                Console.WriteLine($"Student have grade: {grade} and he is Not Passed the cuerse.");
            }
        }
    }
    class SecondCourse
    {
        public string Name;
       // public int Grade;
        public Grades grade;
        public FirstCourse CourseOne;

        public SecondCourse()
        {

        }
        public SecondCourse(string name)
        {
            Name = name;
            
        }
              
        public void IsPassed()
        {
            if(CourseOne.Pass){
                Console.WriteLine($"Student have grade: {grade} and he is Pass the cuerse.");
            }
            else
            {
                Console.WriteLine($"Student have grade: {grade} and he is Not Passed the cuerse.");
            }
        }

    }

    
    class Project
    {
        SecondCourse CourseTwo;
        FirstCourse CourseOne;
        Grades grades;
        public Project()
        {
            
        }
        public void isPassed()
        {
            if (CourseTwo.grade != Grades.NoPassGrade && CourseOne.grade != Grades.NoPassGrade)
            {
                CourseOne.Pass = true;

            }
            else
            {
                CourseOne.Pass = false;
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
            Grades a = Grades.LowGrade;
            course1.grade = a;
            var course2 = new FirstCourse();
            course2.Name = "JavaScript Advanced";
            Grades b = Grades.NoPassGrade;
            course2.grade = b;
            var course3 = new SecondCourse();
            course3.Name = "C Sharp Beggin";
            Grades c = Grades.ExcellentGrade;
            course2.grade = c;
            var course4 = new SecondCourse();
            course4.Name = "C Sharp Advanced";
            Grades d = Grades.MediumGrade;
            course2.grade = d;


            course1.IsPassed();
            course2.IsPassed();
            // Console.WriteLine(course1.IsPassed());
            Console.ReadLine();
        }
    }
}
