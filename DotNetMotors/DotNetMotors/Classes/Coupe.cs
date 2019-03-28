using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Coupe : Car
    {
        public override int NumberOfDoors { get; set; } = 2;
        public abstract bool BackseatSpace { get; set; }
    }
}
