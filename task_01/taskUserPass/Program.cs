using System;

namespace taskUserPass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[] { };
            string[] password = new string[] { };
            int i;
            int countUser = 0;
            int countPass = 0;

            //string userElement;
            //string passELement;

            // while(true) { 
            Console.WriteLine("Enter usarname");
            Console.WriteLine("REMEMBER - First letter must be UPPERCASE");
            string elementOne = Console.ReadLine();
             Console.WriteLine("Enter password");         
            string elementTwo = Console.ReadLine();

            char[] charactUser = elementOne.ToCharArray();
            char[] charactPass = elementTwo.ToCharArray();

              //while(true)
              //{
                //userElement = userNames[count];
                //passELement = password[count];
                Array.Resize(ref userNames, userNames.Length + 1);
                userNames[countUser] = elementOne;
                Array.Resize(ref password, password.Length + 1);
                password[countPass] = elementTwo;

            //    if (!char.IsUpper(charactUser[0])) /*|| char.IsSymbol(charactUser[count]) && */
            //       /* char.IsWhiteSpace(charactPass[count]) || char.IsSymbol(charactPass[count]))*/
            //    {
            //        break;
            //    }
            //    countUser++;
            //    countPass++;
            //}

            //if (char.IsUpper(charactUser[0]) && char.IsLower(charactUser[count]) &&
            //        char.IsLetter(charactUser[count]) && char.IsNumber(charactUser[count]))
            // {

            for (i = 0; i < charactUser.Length; i++)
            {
                

                if (char.IsUpper(charactUser[0]) || char.IsLower(charactUser[i]) ||
                    char.IsLetter(charactUser[i]))
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your user logged in successfully");

                }
                break;
                
            }

            for (i = 0; i < charactPass.Length; i++)
            {

              
                if (char.IsUpper(charactPass[i]) || char.IsLower(charactPass[i]) ||
                            char.IsLetter(charactPass[i]) || char.IsNumber(charactPass[i]))
                 {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your password in successfully");
                }
                break;
            }
            Console.ReadLine();
            // count++;
            //  break;
            //}
            //}
            foreach (string user in userNames)
            {              
                Console.WriteLine("User: " + user);
                Console.ReadLine();
            }
            foreach (string pass in password)
            {
                Console.WriteLine("Password: " + pass);
                Console.ReadLine();


            }
            //Console.ReadLine();
        }

    }
}
