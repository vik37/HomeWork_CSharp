using System;
using System.Collections.Generic;
using System.Text;
using HomeWork_Collections.Class_Product;
using HomeWork_Collections.Class_Product.Enum;



namespace HomeWork_Collections.Helper
{
    public class HelpOne
    {
       
        public Category Category;
        public static void CategoryProducts( List<Products> products)
        {
            foreach(var item in products)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (item.Category == Category.ItEquipment)
                {
                    
                    Console.WriteLine($"{item.Name} --- {item.Category}");
                }
                if (item.Category == Category.LapTop)
                {
                    Console.WriteLine($"{item.Name} --- {item.Category}");
                }
                if (item.Category == Category.PC)
                {
                    Console.WriteLine($"{item.Name} --- {item.Category}");
                }
                if (item.Category == Category.TV)
                {
                    
                    Console.WriteLine($"{item.Name} --- {item.Category}");
                }
            }
            
        }
        
        public static void FromMinToMax(List<Products> products)
        {
            products.Sort((x, y) => x.Price.CompareTo(y.Price));
            foreach (var itemOne in products)
            {
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{itemOne.Price} === {itemOne.Name}");
               
            }
        }
       
        public static void FindByPartOfName(List<Products> products)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("| <-    SAME NAME PRODUCTS   -> |");
            Console.WriteLine("_________________________________");
            
            Console.ResetColor();
            Console.WriteLine($"   \n  ");
            Console.WriteLine("PHONE PRODUCTS");
            Console.WriteLine("-------------------------");
           
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in products)
            {               
                bool endWithPhone = item.Name.EndsWith("phone");
                bool endWithPhones = item.Name.EndsWith("phones");
                
                if (endWithPhone || endWithPhones)
                {
                    Console.WriteLine($"{item.Name}");
                }                
            }
            Console.ResetColor();
            Console.WriteLine("_______________________-");
            Console.WriteLine("PRODUCT HP");
            Console.WriteLine("-----------------------");
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in products)
            {
                bool startWithHp = item.Name.StartsWith("Hp");
                if (startWithHp)
                {
                    Console.WriteLine($"{item.Name}");
                }

            }
            Console.ResetColor();
            Console.WriteLine("_______________________-");
            Console.WriteLine("OFFICE PRODUCTS");
            Console.WriteLine("-----------------------");
           
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in products)
            {
                bool startWithOffice = item.Name.StartsWith("Office");
                if (startWithOffice)
                {
                    Console.WriteLine($"{item.Name}");
                }

            }
            Console.ResetColor();
            Console.WriteLine("______________________");
            Console.WriteLine("GAMING PRODUCTS");
            Console.WriteLine("-----------------------");
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in products)
            {
                bool endWithGaming = item.Name.EndsWith("Gaming");
                if (endWithGaming)
                {
                    Console.WriteLine($"{item.Name}");
                }

            }
            Console.ResetColor();
            Console.WriteLine("__________________________");
            Console.WriteLine("SAMSUNG PRODUCTS");
            Console.WriteLine("-----------------------");
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in products)
            {
                bool startWithSamsung = item.Name.StartsWith("Samsung");
                if (startWithSamsung)
                {
                    Console.WriteLine($"{item.Name}");
                }

            }
            Console.ResetColor();
            Console.WriteLine("______________________");
            Console.WriteLine("SONY PRODUCTS");
            Console.WriteLine("-----------------------");
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in products)
            {
                bool startWithSony = item.Name.StartsWith("SONY");
                if (startWithSony)
                {
                    Console.WriteLine($"{item.Name}");
                }

            }
        }

        
    }
}
