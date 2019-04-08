using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Bike : Vehicle
    {
        public override int NumberOfWheels { get; set; } = 2;
        public virtual bool RequiresLicense { get; set; } = false;

        /// <summary>
        /// Action of doing a wheelie.  Abstract.
        /// </summary>
        public abstract void DoWheelie();
    }
}
