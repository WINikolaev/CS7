﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        None = 0,
        GreatPyramidOfGiza = 1,
        HangingGardensOfBabylon = 1 << 1, // то есть 2
        StatueOfZeusAtOlympia = 1 << 2, // то есть 4
        TempleOfArtemisAtEphesus = 1 << 3, // то есть 8
        MausoleumAtHalicarnassus = 1 << 4, // то есть 16
        ColossusOfRhodes = 1 << 5, // то есть 32
        LighthouseOfAlexandria = 1 << 6 // то есть 64
    }
}
