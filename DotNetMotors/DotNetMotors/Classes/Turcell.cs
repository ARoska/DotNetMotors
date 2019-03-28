using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Turcell : Coupe, INeedKey
    {
        public override bool BackseatSpace { get; set; } = true;
        public override int Cost { get; set; } = 2000;

        public override void Start()
        {
            Console.WriteLine(UseKey());
        }

        public string UseKey()
        {
            return "Turns key.";
        }
    }
}
