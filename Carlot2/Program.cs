using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class CarLot 
    {
        public String Name { get; set; }
        public List<string> Vehicles { get; set; } 
        public static void AddVehicle() // Add Vehicle Method
        {
            //adding vehicle code
        }
        public virtual string PrintInventory() // To printInventory Method
        {
            // include amount of vehicles
            // include details of each vehicle
            return $"{Vehicles}"; 
        }
    }
    abstract class Vehicle 
    {
        public String LicenseNumber { get; set; } 
        public String Make { get; set; } 
        public String Model { get; set; } 
        public int Price { get; set; } 
        public static string VehicleDetails() // Vehicle Details Method
        {
            // return a description of the vehicle
            return $" ";
        }
    }
    class Car : Vehicle 
    {
        public String Type { get; set; } 
        public int NumberDoors { get; set; } 
    }
    class Truck : Vehicle // additional property to vehicle 
    {
        public String BedSize { get; set; }
    }
    class Program
    {
        static void Main(string[] args) // "driver" for program
        {
            // instantiate 2 different car lots, and add various vehicles to the car lots
            // Print out inventory with the correct info
            
        }
    }
}