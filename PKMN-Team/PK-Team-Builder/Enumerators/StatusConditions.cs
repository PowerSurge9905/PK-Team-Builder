using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators
{
    internal enum StatusConditions
    {
        None,
        Burn,
        Freeze,
        Frostbite,
        Paralysis,
        Poison,
        BadPoison,
        Sleep,
        Drowsy
    }
    // Consider making a class for volatile status conditions
    // These interactions will likely be more complex than just an enum
    internal enum VolatileStatusConditions
    {
        None,
    }
}
