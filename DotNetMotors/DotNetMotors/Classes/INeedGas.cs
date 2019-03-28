using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    interface INeedGas
    {
        /// <summary>
        /// Returns how much gas is needed to fill
        /// </summary>
        int FillWithGas();
    }
}
