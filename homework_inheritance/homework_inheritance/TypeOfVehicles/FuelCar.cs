using System;
using System.Collections.Generic;
using System.Text;
using homework_inheritance.CarClass;
using homework_inheritance.Enum;

namespace homework_inheritance.TypeOfVehicles
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public Consumption CarConsumpt { get; set; }

        public FuelCar()
        {

        }
        
        public FuelCar(int id, string brand, string model, int doors, int topSpeed)
            : base(id, brand, model, doors, topSpeed)
        {

        }
        public FuelCar(int fuelCapacity, int currentFuel)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }
        public void Drive(int distance)
        {
            int result;
            if (CarConsumpt == Consumption.Economic)
            {
                result = distance * 1 / 10;
            }
            else if (CarConsumpt == Consumption.Medium)
            {
                result = distance * 2 / 10;
            }
            else
            {
                result = distance * 3 / 10;
            }
            
            Console.WriteLine("From {0} KM, fuel has been use {1} Litters. ", distance, result);
            Console.WriteLine("----------------------------------------------");
        }

        public void Refuel(int fuel)
        {
            int addFuel = FuelCapacity - CurrentFuel + fuel;
            int canAddFuel = FuelCapacity - addFuel;
            if(addFuel >= FuelCapacity)
            {
                Console.WriteLine("Your tank is full. If you submit, it will overflow. Can't refuel more then {0} liters", FuelCapacity);
            }
            else
            {
                Console.WriteLine($"Add: {addFuel} fuel, you can add more {canAddFuel}.L fuel.");
            }
            Console.WriteLine("____________________________________________________________________");
        }


    }
}
