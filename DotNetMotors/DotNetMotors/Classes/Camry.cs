using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Camry : Car, INeedKey, INeedGas
    {
        public override int NumberOfDoors { get; set; } = 4;
        public override int Cost { get; set; } = 15000;

        public int FillWithGas()
        {
            return 15;
        }

        public override void Start()
        {
            Console.WriteLine(UseKey());
        }

        public string UseKey()
        {
            return "Turns key.";
        }
    }
}
