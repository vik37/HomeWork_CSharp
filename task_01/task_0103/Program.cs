using System;

namespace task_0103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[] { };
            string[] password = new string[] { };
            string elementOne;
            string elementTwo;
           // bool myBolOne = string.IsNullOrEmpty();
            int i = 0;

            while (true)
            {
                if(userNames != null && userNames.Length > 0) { 
                    Console.WriteLine("Enter usarname");
                    elementOne = Console.ReadLine();
                    Array.Resize(ref userNames, userNames.Length + 1);
                    userNames[i] = elementOne;
                }
                if (password != null && password.Length > 0)
                {
                    Console.WriteLine("Enter password");
                    elementTwo = Console.ReadLine();
                    Array.Resize(ref password, password.Length + 1);
                    password[i] = elementTwo;
                }
                if(userNames.Length == 3 && password.Length == 3)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine("__________________");
            Console.WriteLine("Your Sign is successfully");
            Console.WriteLine("-----------");
            Console.WriteLine();
            //do
            //{
            //    Console.WriteLine("Log in... ");
            //    Console.WriteLine("Enter your user name");
            //    string userFull = Console.ReadLine();
            //    Console.WriteLine("Enter your password");
            //    string passFull = Console.ReadLine();
            //    if (userFull == userNames[i] && passFull == password[i])
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("You are logged in successfully");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine("Incorrect username or password");
            //        Console.ReadLine();
            //    }
            //    i++;
            //} while (true);
           int countUsser = 0;
            int countPass = 0;
            
            int j;
            Console.WriteLine("Log in... ");
            Console.WriteLine("Enter your user name");
            string userFull = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string passFull = Console.ReadLine();
            for (i = 0;i <= userNames.Length; i++)
            {
                for(j = 0; j <= password.Length; j++)
                {
                   // if (userNames[countUsser] == password[countPass])  
                   // {
                        
                        if (userNames[i] == userFull && password[j] == passFull
                        && userNames.Length == password.Length)                           
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You are logged in successfully");
                            Console.ReadLine();
                            countUsser = i;
                            countPass = j;                       
                        break;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Incorrect username or password");
                            Console.ReadLine();
                        };

                    //   }


                    //else
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Red;

                    //    Console.WriteLine("ERRORR!!!");
                    //    Console.ReadLine();
                    //}

                    countUsser++;
                    countPass++;

                }
                
            }
            foreach(string user in userNames)
            {
                Console.WriteLine("User: " + user);
                Console.ReadLine();
            }
            foreach (string pass in password)
            {
                Console.WriteLine("Password: " + pass);
                Console.ReadLine();
            }

        }
    }
}
