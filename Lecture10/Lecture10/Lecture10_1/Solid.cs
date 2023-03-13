using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture10_1
{
    public class Solid : On
    {
        public override void HandleModePressed(Flashlight context)
        {
            context.turnLampBlinkingOff();
            context.SetModeState(Flashlight.FlashLightMode.Blinking);
        }
    }
}