using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder
{
    internal enum HeldItems
    {
        None,
        // Berries
        CheriBerry, // Cures paralysis
        ChestoBerry, // Cures sleep
        PechaBerry, // Cures poison
        RawstBerry, // Cures burn
        AspearBerry, // Cures freeze
        LeppaBerry, // Restores 10 PP
        OranBerry, // Restores 10 HP
        PersimBerry, // Cures confusion
        LumBerry, // Cures any non-volatile status condition and confusion
        SitrusBerry, // Restores 25% max HP
    }
}
