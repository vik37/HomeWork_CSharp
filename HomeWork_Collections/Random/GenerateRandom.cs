using System;

namespace RandomGenerate
{
    public class RandomNumber
    {
        
        public static int GenerateRandomNum()
        {
            var random = new Random();

            int ranNum = random.Next(1, 23);
            return ranNum;

        }
    }
}
