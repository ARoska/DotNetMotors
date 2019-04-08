using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    interface INeedGas
    {
        /// <summary>
        /// Action of filling vehicle with gas.
        /// </summary>
        /// <returns>How much gas is filled.</returns>
        int FillWithGas();
    }
}
