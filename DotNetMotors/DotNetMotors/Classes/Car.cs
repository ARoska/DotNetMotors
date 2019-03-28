using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Car : Vehicle
    {
        public override int NumberOfWheels { get; set; } = 4;
        public abstract int NumberOfDoors { get; set; }
        public virtual bool HasHorn { get; set; } = true;

        public virtual string Honk()
        {
            if (HasHorn == true)
            {
                return "Honk honk!";

            }
            return null;
        }
    }
}
