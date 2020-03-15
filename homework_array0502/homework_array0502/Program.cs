using System;

namespace homework_array0502
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { Console.ReadLine() }; 





            //do
            //{
            //    Console.WriteLine("Enter the name");
            //    names = new string[] { Console.ReadLine() };


            //    Console.WriteLine("Do you want to enter another name? (Y / N)");
            //    string yesNo = Console.ReadLine();
            //    Char parsYesno = Char.Parse(yesNo);
            //    //if (parsYesno == 'N')
            //    //{
            //    //    break;
            //    //}


            //}
            //while (parsYesno == 'N');

            //for(int i = 0; i<names.Length;i++)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadLine();
            //}
            string[] names = new string[] { };

            while (true) 
            {
                int index = 0;

                Console.WriteLine("Enter the name");
                string element = Console.ReadLine();
                names[index] = element;
                Array.Resize(ref names, names.Length + 1);

                Console.WriteLine("Do you want to enter another name? (Y / N)");
                string yesNo = Console.ReadLine();
                Char parsYesno = Char.Parse(yesNo);
                if (parsYesno == 'N')
                {
                    break;
                }
                index++;


            }


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                Console.ReadLine();
            }



        }
    }
}
