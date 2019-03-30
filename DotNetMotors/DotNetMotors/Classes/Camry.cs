using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Camry : Car, INeedKey, INeedGas
    {
        public override int NumberOfDoors { get; set; } = 4;
        public override int Cost { get; set; } = 15000;

        public int FillWithGas()
        {
            return 15;
        }

        public override bool Start()
        {
            Console.WriteLine(UseKey());
            return true;
        }

        public string UseKey()
        {
            return "Turns key.";
        }
    }
}
