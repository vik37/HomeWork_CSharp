using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class ListMenager
    {
        public static List<PersonClass> LoadSempleData()
        {

            List<PersonClass> outpot = new List<PersonClass>();
            outpot.Add(new PersonClass { FirstName = "Tomy", LastName = "Gan", BirthDay = Convert.ToDateTime("2/25/1973"), YearsExperience = 24 });
            outpot.Add(new PersonClass { FirstName = "Michel", LastName = "Moor", BirthDay = Convert.ToDateTime("6/15/2003"), YearsExperience = 14 });
            outpot.Add(new PersonClass { FirstName = "Jane", LastName = "Sandanski", BirthDay = Convert.ToDateTime("12/21/1993"), YearsExperience = 4 });
            outpot.Add(new PersonClass { FirstName = "Sanja", LastName = "Georgievska", BirthDay = Convert.ToDateTime("4/8/1997"), YearsExperience = 19 });
            outpot.Add(new PersonClass { FirstName = "Maja", LastName = "Panceva", BirthDay = Convert.ToDateTime("2/25/2011"), YearsExperience = 2 });
            outpot.Add(new PersonClass { FirstName = "Jordan", LastName = "Piperkata", BirthDay = Convert.ToDateTime("12/9/1968"), YearsExperience = 34 });
            outpot.Add(new PersonClass { FirstName = "Rocky", LastName = "Balboa", BirthDay = Convert.ToDateTime("6/2/1982"), YearsExperience = 15 });
            outpot.Add(new PersonClass { FirstName = "Viktor", LastName = "Zafirovski", BirthDay = Convert.ToDateTime("5/26/1982"), YearsExperience = 1 });
            outpot.Add(new PersonClass { FirstName = "TOma", LastName = "Zdravkovic", BirthDay = Convert.ToDateTime("6/8/1988"), YearsExperience = 18 });
            outpot.Add(new PersonClass { FirstName = "Vera", LastName = "Civirivi-Trena", BirthDay = Convert.ToDateTime("1/30/2006"), YearsExperience = 4 });
            return outpot;
        }
    }
}
