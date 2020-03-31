using System;

namespace Class_and_Object
{
    //Task 7
    //Create a class Dog
    //Add properties: Name, race, color
    //The dog needs to have:
    //Eat method that returns message: The dog is now eating
    //Play method returning a message : The dog is now playing
    //ChaseTail method that returns a message: Dog is now chasing its tail.
    //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.

    //public class Dog
    //{
    //    public string Name;
    //    public string Race;
    //    public string Color;

    //    public void Eat()
    //    {
    //        Console.WriteLine($"{Name} is now eating! ");
    //    }
    //    public void Play()
    //    {
    //        Console.WriteLine($"{Name} is now playing! ");
    //    }
    //    public void ChaseTail()
    //    {
    //        Console.WriteLine($"{Name} is now chasing its tail! ");
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog FirstDog = new Dog();

    //        Console.WriteLine("What's your dog's name?");
    //        Console.WriteLine("--------------------------------");

    //        FirstDog.Name = Console.ReadLine();
    //        Console.WriteLine($"What race is {FirstDog.Name}?");
    //        Console.WriteLine("--------------------------------");

    //        FirstDog.Race = Console.ReadLine();
    //        Console.WriteLine("What color have?");
    //        Console.WriteLine("--------------------------------");
    //        FirstDog.Color = Console.ReadLine();

    //        Console.WriteLine("Name: {0}, Race: {1}, Color: {2} ", FirstDog.Name, FirstDog.Race, FirstDog.Color);
    //        Console.WriteLine("--------------------------------");

    //        Console.WriteLine("what is your dog doing now");
    //        Console.WriteLine("--------------------------------");

    //        Console.WriteLine(" A - Eat \n B - Play \n C - Chase its tail ");
    //        string dogJob = Console.ReadLine();
    //        char ejBiCi = char.Parse(dogJob);

    //        if (ejBiCi == 'A')
    //        {
    //            FirstDog.Eat();
    //        }
    //        if (ejBiCi == 'B')
    //        {
    //            FirstDog.Play();
    //        }
    //        if (ejBiCi == 'C')
    //        {
    //            FirstDog.ChaseTail();
    //        }

    //        Console.ReadLine();

    //    }
    //}



    //Task 8
    //    Create a class Human
    //Add properties: FirstName, LastName, Age
    //Create a method called GetPersonStats that returns the full name of the human as well as their age
    //Create an object human by asking the user to fill the required information
    //Call the GetPersonStats method and print the result in the console after the object is created

    public class Human
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void GetPersonStats()
        {

            Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}", FirstName, LastName, Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human Person = new Human();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("FILL IN THE FIELDS! \n");
            Console.ResetColor();

            Console.Write("FIRST NAME: ");
            Person.FirstName = Console.ReadLine();
            Console.WriteLine("________________________");

            Console.Write("LAST NAME: ");
            Person.LastName = Console.ReadLine();
            Console.WriteLine("______________________________");

            Console.Write("AGE: ");
            int humanAge;

            string inputAge = Console.ReadLine();
            bool numAge = int.TryParse(inputAge, out humanAge);
            if (numAge)
            {
                Person.Age = humanAge;
                Console.WriteLine("----------------------------------------");
            }


            Person.GetPersonStats();
            Console.ReadLine();
        }
    }
}
