using homework_inheritance.CarClass;
using homework_inheritance.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework_inheritance.TypeOfVehicles
{
    public class ElectricCar : Car
    {       
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }
        public Consumption CarConsumpt { get; set; }
        public ElectricCar()
        {
            Console.WriteLine("Batery Capacity {0}, Batery Usage {1} months", BatteryCapacity, BatteryUsage);
        }
        public ElectricCar(int batteryCapacity, int batteryUsage)
           
        {
            BatteryCapacity = batteryCapacity;
            BatteryUsage = batteryUsage;
        }
        public ElectricCar(int id, string brand, string model, int doors, int topSpeed)
            : base(id, brand, model, doors, topSpeed)
        {
            
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
            Console.WriteLine("From {0} KM, battery has been use {1} KWh. ", distance, result);
        }

        public void Recharge(int minute)
        {
            int percent = minute / 10;

            Console.WriteLine($"Battery charge from {minute} minutes, to {percent} percent ");
        }
    }
}
