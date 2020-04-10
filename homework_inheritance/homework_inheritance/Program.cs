using System;
using homework_inheritance.CarClass;
using RandomGenerate;
using homework_inheritance.Enum;
using homework_inheritance.TypeOfVehicles;



namespace homework_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = RandomNumber.GenerateRandomNum();
            var toyota = new Car()
            {
                Brand = "Toyota",
                Model = "C-HR",
                Doors = 2,
                TopSpeed = 209,
                Id = a
            };
            toyota.TypeOfEngine = EngineType.Disel;
            toyota.Consumpt = Consumption.Medium;
           
            toyota.PrintInfo();
            
            var nissan = new Car()
            {
                Brand = "Nissan",
                Model = "Leaf",
                Doors = 5,
                TopSpeed = 150,
                Id = a + 1
            };
            
            nissan.TypeOfEngine = EngineType.Electric;
            nissan.Consumpt = Consumption.Economic;
            //nissan.PrintInfo();
            ElectricCar nissan1 = new ElectricCar(40,96);
            nissan.PrintInfo();
            nissan1.Drive(40);
            nissan1.Recharge(10);
            Console.ReadLine();
        }
    }
}
