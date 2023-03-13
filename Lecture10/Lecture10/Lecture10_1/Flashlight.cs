using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_1
{
    public class Flashlight
    {

        public enum FlashLightEvent {PowerButtonPressed}

        public enum FlashLightState { On, Off }
        public enum FlashLightMode { Solid, Blinking}


        private FlashLightState _currentState; //the mode flash light will be in after next button press
        private FlashLightMode _currentMode;

        private FlashlightState _currentStateHandler;
        private FlashlightState _currentModeHandler;


        public Flashlight()
        {
            _currentMode = FlashLightMode.Solid;
            _currentState = FlashLightState.On;
            _currentStateHandler = new On();
            _currentModeHandler = new Solid();
        }
        
        public void PowerPressed()
        {
            _currentStateHandler.HandlePowerPressed(this);
        }

        public void ModePressed()
        {
            if (_currentState == FlashLightState.Off)
            {
                _currentModeHandler.HandleModePressed(this);
            }
        }

        public void SetModeState(FlashLightMode mode)
        {
            if (_currentState == FlashLightState.Off)
            {
                switch (mode)
                {
                    case FlashLightMode.Blinking:
                    {
                        _currentModeHandler = new Blinking();
                    }
                        break;

                    case FlashLightMode.Solid:
                    {
                        _currentModeHandler = new Solid();
                    }
                        break;

                    default:
                    {
                        throw new Exception("Invalid state");
                    }
                        break;
                }
            }
        }

        public void SetFlashLightState(FlashLightState state)
        {
            _currentState = state;

            switch (state)
            {
                case FlashLightState.On:
                {
                   _currentStateHandler = new On();
                }
                    break;

                case FlashLightState.Off:
                {
                    _currentStateHandler = new Off();
                }
                    break;

                default:
                {
                    throw new Exception("Invalid state");
                }
                    break;
            }
        }

        public void turnLampOn()
        {
            Console.WriteLine("Turn on lamp");
        }

        public void turnLampOff()
        {
            Console.WriteLine("Turn off lamp");
        }

        public void turnLampBlinkingOn()
        {
            Console.WriteLine("Lamp blinks");
        }

        public void turnLampBlinkingOff()
        {
            Console.WriteLine("Lamp is solid");
        }


    }
}
