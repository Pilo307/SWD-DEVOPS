using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture10_1
{
    public class Blinking : On
    {
        public override void HandleModePressed(Flashlight context)
        {
            context.turnLampBlinkingOn();
            context.SetModeState(Flashlight.FlashLightMode.Solid);
        }
    }
}