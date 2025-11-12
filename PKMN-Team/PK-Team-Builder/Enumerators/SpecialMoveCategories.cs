using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators
{
    internal enum SpecialMoveCategories
    {
        None,
        Sound,
        Punch,
        Recoil,
        Powder,
        Spore,
        Ball,
        Bomb,
        Bite,
        Pulse
    }

    // Instead of using an enum, try making multiple lists of the special move types
    // I.E. Aura Sphere is both a "Ball" and "Pulse" move, so have it be in both lists
}
