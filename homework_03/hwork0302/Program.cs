using System;

namespace hwork0302
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solve the following problem. On one tree there are 12 branches with n apples on them. 
            //One basket can hold m apples. If a user enters number of trees find out how many baskets 
            //    does it take to collect all the apples from the trees?
            //n = 8
            //m = 5
            //Result = ?



            int n = 8;
            double m = 5;
            string treeInput = Console.ReadLine();
            double tree = double.Parse(treeInput);

            double result = n * tree / m;

            Int32 resultTwo = Convert.ToInt32(result);


                Console.WriteLine(result);
            
            
            Console.ReadLine();
        }
    }
}
