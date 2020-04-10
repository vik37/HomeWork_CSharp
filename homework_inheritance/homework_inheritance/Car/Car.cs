using RandomGenerate;
using homework_inheritance.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using homework_inheritance;
using homework_inheritance.TypeOfVehicles;

namespace homework_inheritance.CarClass
{
    public class Car
    {        
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }

        public Consumption Consumpt { get; set; }
        public EngineType TypeOfEngine { get; set; }

        public Car()
        {

        }

        public Car(int id, string brand, string model, int doors, int topSpeed)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
           
        }
       

        public void PrintInfo()
        {
            Console.WriteLine("Id - {0} | Brand: {1}, Model: {2}, Doors: {3}, Top Speed: {4} km/h", Id, Brand, Model, Doors, TopSpeed);
            Console.WriteLine("This car have {0} consumption and his type of engine is {1}", Consumpt, TypeOfEngine);
            Console.WriteLine("---------------------------------------");
        }

        
    }
}
