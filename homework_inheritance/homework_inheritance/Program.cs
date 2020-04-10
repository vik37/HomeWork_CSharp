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
            var idNumber = RandomNumber.GenerateRandomNum();
            var toyota = new FuelCar()
            {
                Brand = "Toyota",
                Model = "C-HR",
                Doors = 2,
                TopSpeed = 190,
                Id = idNumber,
                FuelCapacity = 50,
                CurrentFuel = 30
                
            };
            toyota.TypeOfEngine = EngineType.Disel;
            toyota.Consumpt = Consumption.Medium;
           
            toyota.PrintInfo();

            toyota.Drive(30);
            toyota.Refuel(45);
            
          
            var nissan1 = new ElectricCar()
            {
                Brand = "Nissan",
                Model = "Leaf",
                Doors = 5,
                TopSpeed = 144,
                Id = idNumber + 1,
                BatteryCapacity = 243,
                BatteryUsage = 40
            };
            nissan1.TypeOfEngine = EngineType.Electric;
            nissan1.Consumpt = Consumption.Economic;
           
            nissan1.PrintInfo();
            nissan1.Drive(40);
            nissan1.Recharge(10);


            var audi = new FuelCar()
            {
                Brand = "Audi",
                Model = "A 7",
                Doors = 4,
                TopSpeed = 250,
                Id = idNumber + 2,
                FuelCapacity = 65,
                CurrentFuel = 50
            };
            audi.TypeOfEngine = EngineType.Petrol;
            audi.Consumpt = Consumption.Hight;

            audi.PrintInfo();

            audi.Drive(180);
            audi.Refuel(20);
            Console.ReadLine();
        }
    }
}
