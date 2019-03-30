using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class BRZ : Coupe, INeedGas
    {
        public override bool BackseatSpace { get; set; } = false;
        public override int Cost { get; set; } = 50000;

        public override void Start()
        {
            Console.WriteLine(DoTheThing());
        }

        public string DoTheThing()
        {
            return "Beep Beep VROOOM!";
        }

        public int FillWithGas()
        {
            return 18;
        }
    }
}
