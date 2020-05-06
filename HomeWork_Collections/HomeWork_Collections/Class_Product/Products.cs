using HomeWork_Collections.Class_Product.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Collections.Class_Product
{
    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        public Products()
        {
            
        }
        public Products (int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        
        public Category Category;


    }
}
