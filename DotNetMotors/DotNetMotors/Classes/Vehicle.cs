using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Vehicle
    {
        public abstract int NumberOfWheels { get; set; }
        public abstract int Cost { get; set; }
        public virtual bool SelfPropelled { get; set; } = true;

        public abstract bool Start();
        public virtual string Drive()
        {
            return "Vroom vroom!";
        }
    }
}
