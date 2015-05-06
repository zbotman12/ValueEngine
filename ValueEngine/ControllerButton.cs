using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.Sdl;

namespace ValueEngine
{
    public class ControllerButton
    {
        IntPtr _joystick;
        int _buttonId;

        public bool Held { get; private set; }

        public ControllerButton(IntPtr joystick, int buttonId)
        {
            _joystick = joystick;
            _buttonId = buttonId;
        }

        public void Update()
        {
            byte buttonState = Sdl.SDL_JoystickGetButton(_joystick, _buttonId);
            Held = (buttonState == 1);
        }
    }
}
