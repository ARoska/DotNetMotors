using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Motorcycle : Bike, INeedKey, INeedGas
    {
        public override int Cost { get; set; } = 24000;
        public override bool RequiresLicense { get; set; } = true;

        public override void DoWheelie()
        {
            Start();
            Console.WriteLine("Safely pop a wheelie at speeds > 60 mph...");
        }

        public int FillWithGas()
        {
            return 2;
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
