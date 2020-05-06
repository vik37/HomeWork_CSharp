using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork_Collections.Class_Product;
using HomeWork_Collections.Class_Product.Enum;
using HomeWork_Collections.Helper;
using RandomGenerate;

namespace HomeWork_Collections
{
    class Program
    {
        public static int Id { get; private set; }

        static void Main(string[] args)
        {
            List<Products> products = new List<Products>
            {
                new Products() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Products() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Products() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Products() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Products() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Products() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Products() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Products() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Products() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Products() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Products() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Products() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Products() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Products() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Products() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Products() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Products() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Products() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Products() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Products() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Products() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            };
            Console.WriteLine("-  - PRODUCT'S by CATEGORY  -  -");           
            HelpOne.CategoryProducts(products);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-  PRODUCT'S FROM MINIMUM TO MAXIMUM PRICE  -");
            HelpOne.FromMinToMax(products);
            Console.WriteLine("_________________________________");
            HelpOne.FindByPartOfName(products);
            Console.WriteLine("_________________________________");

            var IdNum = RandomNumber.GenerateRandomNum();
            int count = 0;
            foreach (var item in products)
            {                
                item.Id = IdNum + count;

                count++;
            }
           
            HelpTwo.ShowId(products);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" \v    PRICE  BY  I.D.   \v");
            Console.WriteLine("-----_________________-----");
            HelpTwo.GetPriceById(22,products);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-  CHEAPEST PRODUCT  -");
            Console.WriteLine("--------------------------");
            var minPrice = HelpTwo.FindMinPrice(products);
            foreach (var item in products)
            {
                if(minPrice == item.Price)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The cheapest Product is:| ID: {0} | NAME: {1}, |PRICE: {2}|", item.Id,item.Name,item.Price);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-  MOST EXPENSIVE PRODUCT  -");
            Console.WriteLine("--------------------------");
            var maxPrice = HelpTwo.FindMaxPrice(products);
            foreach (var item in products)
            {
                if(maxPrice == item.Price)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The cheapest Product is:| ID: {0} | NAME: {1}, |PRICE: {2}|", item.Id, item.Name, item.Price);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-  ADDED PRODUCT  -");
            Console.WriteLine("--------------------------");
            products.Add(new Products() { Id = IdNum, Name = "Hp 15 NoteBook", Price = 47172, Category = Category.LapTop });
            foreach(var product in products)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("ID: {0} NAMe: {1} PRICE: {2} CAtEgOrI: {3}", product.Id,product.Name,product.Price,product.Category);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-  REMOVE PRODUCT by id  -");
            Console.WriteLine("--------------------------");
            products.Remove(new Products() { Id = 12 });
            Console.ForegroundColor = ConsoleColor.Gray;
            products.ForEach(p => Console.WriteLine($"ID: {p.Id},| NAME: {p.Name}, \n | PRICE: {p.Price}, | CATEGORY: {p.Category} "));
            Console.ReadLine();
        }
    }
}
