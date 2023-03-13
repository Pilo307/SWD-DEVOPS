using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Implement the control mechanism of a basic version of 3-LED flashlight along the lines of the below state machine
// diagram. The implementation shall be done using the switch/case approach.Ensure that the names of the states, events
// and actions are reflected in your implementation. Run your state machine.

namespace Lecture10
{
public class SwitchCase
{
    public void setSwitchState(string state, string mode)
    {
        switch (state)
        {
            case "ON": 
            {
                Console.WriteLine("Flash Light ON");
                switch (mode)
                {
                    case "FLASHING": 
                    {
                        Console.WriteLine("Flash Light Blinking");
                    }
                        break;

                    case "Solid":
                    {
                        Console.WriteLine("Flash Light solid");
                    }
                        break;

                }
            }
            break;

            case "OFF": 
            {
                Console.WriteLine("Flash Light OFF");
            }
        break;
        }
    }
}

}
