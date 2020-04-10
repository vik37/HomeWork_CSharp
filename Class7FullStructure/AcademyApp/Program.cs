﻿using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using SubjectServices;
using System;


namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var trainer = new Trainer();

            var assistant = new Assistant();

            var student = new Student();

            Trainer trainer1 = new Trainer();
            trainer1.FirstName = "Miodrag";
            trainer1.LastName = "Cekikj";
            trainer1.DateOfBirth = new DateTime(1989, 5, 15);
            // trainer1.Role = AcademyRole.Trainer;

            int[] number = new int[] { 1, 2, 3, 4 };
            trainer1.Subjects = new Subject[]
            {
                new Subject()
                {
                    Title = "C# Basic",
                    Semester = 2,
                    Tools = new Tooling()
                },
                new Subject()
                {
                     Tools = new Tooling()
                }
            };

            trainer1.Greetings();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Role = AcademyRole.Assistant;
            participant2.Greetings();

            var participant3 = new Participant("Bob", "Marley");
            participant3.Role = AcademyRole.Assistant;
            Console.ForegroundColor = ConsoleColor.Yellow;
            participant3.PrintFullName();

            var participant4 = new Participant()
            {
                FirstName = "Tupac",
                LastName = "Shakur"
            };

            var cSharpBasic = new Subject();
            cSharpBasic.Title = "C# Basic";
            cSharpBasic.Semester = 2;

            var cSharpAdvanced = new Subject();
            cSharpAdvanced.Title = "C# Advanced";
            cSharpAdvanced.Semester = 2;

            //participant4.Subjects = new string[] {"C# Basic", "C# Advanced"};

            participant4.Subjects = new Subject[] { cSharpBasic, cSharpAdvanced };

            foreach (var subject in participant4.Subjects)
            {
                Console.WriteLine(subject.Title);
            }

            participant4.PrintFullName();

            var participants = new Participant[4];
            participants[0] = trainer1;
            participants[1] = participant2;
            participants[2] = participant3;
            participants[3] = participant4;

            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Trainer);

            Console.ReadLine();
        }
    }
}