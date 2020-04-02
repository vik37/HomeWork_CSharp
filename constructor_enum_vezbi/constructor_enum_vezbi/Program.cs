using System;

namespace constructor_enum_vezbi
{
    public class Something
    {
      public string firstName;
      public string lastName;
      public int age;
        public int a;
        public int b;
       
      public void fullName()
        {
            Console.WriteLine($"Hallo {firstName} {lastName}");
        }
        public void sum()
        {
            int result = sum(a, b);
            Console.WriteLine(result);
        }               
        
        static int sum(int c, int d)
        {
            return c + d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var something1 = new Something();
            something1.firstName = "Viktor";
            something1.lastName = "Zafirovski";
            something1.age = 37;

            
            something1.fullName();

            something1.a = 145;
            something1.b = 83;
            something1.sum();
            Console.ReadLine();
        }
    }
}
