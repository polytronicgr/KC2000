﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkContracts
{
    public interface IMouseController
    {
        MouseEvents GetMouseEvents();

        void Reset();
    }
}
