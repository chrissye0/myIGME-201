using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Create a console application project after referencing Vehicles.dll from PE11 Question #5
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing to see what happens if you feed object that inherits IPassengerCarrier interface
            Compact vehicle = new Compact();
            AddPassenger(vehicle);

            // Error occurs if you feed an object that doesn't inherit the IPassengerCarrier interface
            // FreightTrain testVehicle = new FreightTrain();
            // AddPassenger(testVehicle);
        }

        static void AddPassenger(IPassengerCarrier vehicleObject)
        {
            // call load passenger and print vehicle object to console
            vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());
        }
    }
}