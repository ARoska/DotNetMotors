using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    interface INeedKey
    {
        /// <summary>
        /// Action of using key to start vehicle.
        /// </summary>
        /// <returns>String representing using key.</returns>
        string UseKey();
    }
}
