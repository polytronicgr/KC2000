﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteApplier
{
    class Program
    {
        static void Main(string[] args)
        {
            new DirectoryParser().ApplyPaletteForDirectory("Input", "Output");
        }
    }
}
