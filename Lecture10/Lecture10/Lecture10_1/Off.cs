using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_1
{
    public class Off : FlashlightState
    {
        public override void HandlePowerPressed(Flashlight context)
        {
            context.turnLampOff();
            context.SetFlashLightState(Flashlight.FlashLightState.On);
        }

        public override void HandleModePressed(Flashlight context)
        {
            //do nothing
        }
    }
}
