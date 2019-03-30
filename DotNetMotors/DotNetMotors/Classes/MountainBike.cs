using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class MountainBike : Bike
    {
        public override int Cost { get; set; } = 250;
        public override bool SelfPropelled { get; set; } = false;

        public override void DoWheelie()
        {
            Console.WriteLine("Only able to get enough speed going downhill.");
        }

        public override bool Start()
        {
            Console.WriteLine("Peddle Power!");
            return true;
        }
    }
}
