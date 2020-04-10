using AcademyApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Entities
{
    class Trainer : Participant
    {
        public Expertise Expertise;

        private bool EnglishLanguage;

        public Trainer()
        {
            Console.WriteLine("Constructor from trainer");
        }
        
        public Trainer(string firstName, string lastName)
           : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Constructor with parameters - trainer");
            EnglishLanguage = true;
        }
    }
}
