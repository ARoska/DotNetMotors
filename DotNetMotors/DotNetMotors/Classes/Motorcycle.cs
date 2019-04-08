using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Motorcycle : Bike, INeedKey, INeedGas
    {
        public override int Cost { get; set; } = 24000;
        public override bool RequiresLicense { get; set; } = true;

        /// <summary>
        /// Action of doing a wheelie.  Inherited from Bike.
        /// </summary>
        public override void DoWheelie()
        {
            Start();
            Console.WriteLine("Safely pop a wheelie at speeds > 60 mph...");
        }

        /// <summary>
        /// Action of filling with gas.  Implemented from INeedGas.
        /// </summary>
        /// <returns>Amount of gas vehicle is filled with.</returns>
        public int FillWithGas()
        {
            return 2;
        }

        /// <summary>
        /// Action of starting the vehicle.  Inherited from Vehicle.
        /// </summary>
        public override void Start()
        {
            Console.WriteLine(UseKey());
        }

        /// <summary>
        /// Action of using the key.  Implemented from INeedKey.
        /// </summary>
        /// <returns>String showing the key has been turned.</returns>
        public string UseKey()
        {
            return "Turns key.";
        }
    }
}
