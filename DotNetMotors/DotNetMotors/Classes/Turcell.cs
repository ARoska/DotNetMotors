using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Turcell : Coupe, INeedKey
    {
        public override bool BackseatSpace { get; set; } = true;
        public override int Cost { get; set; } = 2000;

        /// <summary>
        /// Used to start the vehicle.  Inherited from Vehicle.
        /// </summary>
        public override void Start()
        {
            Console.WriteLine(UseKey());
        }

        /// <summary>
        /// Action to turn the key.  Implemented with INeedKey.
        /// </summary>
        /// <returns>String realizing the action of turning the key.</returns>
        public string UseKey()
        {
            return "Turns key.";
        }
    }
}
