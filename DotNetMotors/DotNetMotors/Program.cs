using DotNetMotors.Classes;
using System;

namespace DotNetMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            Turcell turcell = new Turcell();
            Camry camry = new Camry();
            BRZ brz = new BRZ();
            MountainBike mountainBike = new MountainBike();
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine($"Class: {turcell}.  Inherited Number of Wheels: {turcell.NumberOfWheels}\n" +
                "");
            Console.WriteLine($"Class: {camry}.  Inherited Number of Doors: {camry.NumberOfDoors}\n" +
                "");
            Console.WriteLine($"Class: {brz}.  Inherited Backseat Space: {brz.BackseatSpace}\n" +
                "");
            Console.WriteLine($"Class: {motorcycle}.  Inherited Number of Wheels: {motorcycle.NumberOfWheels}\n" +
                "");
            Console.WriteLine($"Class: {mountainBike}.  Inherited Self-Propelled: {mountainBike.SelfPropelled}\n" +
                "");
        }
    }
}
