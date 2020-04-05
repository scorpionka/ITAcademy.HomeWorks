using System;
using System.Collections.Generic;
using System.Text;
using AssemblyOne;

namespace AssemblyTwo
{
    internal class Chopper: Motorcycle
    {
        internal void ChopperRacingProtected()
        {
            RacingProtected();
        }

        internal void ChopperRacingProtectedInternal()
        {
            modelProtectedInternal = "Ural";
            RacingProtectedInternal();
        }
    }
}
