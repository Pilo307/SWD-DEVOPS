using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_1
{
    public abstract class FlashlightState
    {
        public abstract void HandlePowerPressed(Flashlight context);
        public abstract void HandleModePressed(Flashlight context);
    }

}
