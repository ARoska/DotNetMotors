using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Camry : Car, INeedKey, INeedGas
    {
        public override int NumberOfDoors { get; set; } = 4;
        public override int Cost { get; set; } = 15000;

        /// <summary>
        /// Action of filling with gas.  Implemented from INeedGas.
        /// </summary>
        /// <returns>Amount of gas vehicle is filled with.</returns>
        public int FillWithGas()
        {
            return 15;
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
