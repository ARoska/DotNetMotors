using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Bike : Vehicle
    {
        public override int NumberOfWheels { get; set; } = 2;
        public virtual bool RequiresLicense { get; set; } = false;

        public abstract void DoWheelie();
    }
}
