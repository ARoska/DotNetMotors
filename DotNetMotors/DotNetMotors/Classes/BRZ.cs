using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class BRZ : Coupe
    {
        public override bool BackseatSpace { get; set; } = false;
        public override int Cost { get; set; } = 50000;

        /// <summary>
        /// Action of starting the vehicle.  Inherited from Vehicle.
        /// </summary>
        public override void Start()
        {
            Console.WriteLine(DoTheThing());
        }

        /// <summary>
        /// Action of starting with keyless start.
        /// </summary>
        /// <returns>String showing the vehicle is started.</returns>
        public string DoTheThing()
        {
            return "Beep Beep VROOOM!";
        }
    }
}
