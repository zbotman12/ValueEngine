﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueEngine
{
    public class Sound
    {

        public int Channel { get; set; }

        public bool FailedToPlay
        {
            get
            {
                //negative is an error state
                return (Channel == -1);
            }
        }

        public Sound(int channel)
        {
            Channel = channel;
        }

    }
}
