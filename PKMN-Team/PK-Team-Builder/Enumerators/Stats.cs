using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators
{
    internal enum Stats
    {
        HP,
        Attack,
        Defense,
        Special, // Used for Gen 1 and 2 special stat calculations
        SpecialAttack, // Used for Gen 3+ special attack stat calculations
        SpecialDefense, // Used for Gen 3+ special defense stat calculations
        Speed
    }
}
