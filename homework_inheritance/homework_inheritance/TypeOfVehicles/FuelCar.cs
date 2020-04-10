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
            Console.WriteLine("From {0} KM, fuel has been use {1} KWh. ", distance, result);
        }


    }
}
