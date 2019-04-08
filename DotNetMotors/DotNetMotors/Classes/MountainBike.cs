using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class MountainBike : Bike
    {
        public override int Cost { get; set; } = 250;
        public override bool SelfPropelled { get; set; } = false;

        /// <summary>
        /// Action of doing a wheelie.  Inherited from Bike.
        /// </summary>
        public override void DoWheelie()
        {
            Console.WriteLine("Only able to get enough speed going downhill.");
        }

        /// <summary>
        /// Action of starting the vehicle.  Inherited from Vehicle.
        /// </summary>
        public override void Start()
        {
            Console.WriteLine("Peddle Power!");
        }
    }
}
