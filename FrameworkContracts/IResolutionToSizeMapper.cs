﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkContracts
{
    public interface IResolutionToSizeMapper
    {
        double GetSize(int resolution);
    }
}
