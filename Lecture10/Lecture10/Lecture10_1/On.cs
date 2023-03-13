using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_1
{
    public class On : FlashlightState
    {
        public override void HandlePowerPressed(Flashlight context)
        {
            context.turnLampOn();
            context.SetFlashLightState(Flashlight.FlashLightState.Off);
        }

        public override void HandleModePressed(Flashlight context)
        {
            //do nothing
        }
    }
}
