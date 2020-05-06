using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWork_Collections.Class_Product;
using HomeWork_Collections.Class_Product.Enum;
using RandomGenerate;

namespace HomeWork_Collections.Helper
{
    public class HelpTwo
    {
       
        public static void ShowId(List<Products>products)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\a  \t  pRODUCTS BY I.D.  \a /");
            foreach (var item in products)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{item.Id} ---  {item.Name}");
            }
            
        }
        
        public static void GetPriceById(int num,List<Products> products)
        {
            foreach (var item in products)
            {
                if(num == item.Id)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Name: {0} - Price: {1}",item.Name,  item.Price);
                }
                
            }
        }
        public static int FindMinPrice(List<Products> products)
        {           
            int lowestPrice = products.Min(p => p.Price);            
            return lowestPrice;
        }
        public static int FindMaxPrice(List<Products> products)
        {
            int max = 0;
            foreach (var item in products)
            {
                if(item.Price > max)
                {
                    max = item.Price;
                }
            }
            return max;
        }
      
    }

}
