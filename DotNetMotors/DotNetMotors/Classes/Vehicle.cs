using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Vehicle
    {
        public abstract int NumberOfWheels { get; set; }
        public abstract int Cost { get; set; }
        public virtual bool SelfPropelled { get; set; } = true;

        /// <summary>
        /// Action of starting the vehicle.  Abstract.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Action of driving the vehicle.  Virtual.
        /// </summary>
        /// <returns>String representing action of driving.</returns>
        public virtual string Drive()
        {
            return "Vroom vroom!";
        }
    }
}
