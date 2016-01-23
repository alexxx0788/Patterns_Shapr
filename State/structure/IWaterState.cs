using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State.structure
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
