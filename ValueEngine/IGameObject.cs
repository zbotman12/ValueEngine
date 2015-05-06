﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueEngine
{
    public interface IGameObject
    {
        void Update(double elapsedTime);
        void Render();
    }
}
