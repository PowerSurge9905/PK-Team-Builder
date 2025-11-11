using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators
{
    internal enum Natures
    {
        // Neutral Natures
        Hardy,
        Docile,
        Bashful,
        Quirky,
        Serious,
        // +Attack
        Lonely, // -Defense
        Adamant, // -Special Attack
        Naughty, // -Special Defense
        Brave, // -Speed
        // +Defense
        Bold, // -Attack
        Impish, // -Special Attack
        Lax, // -Special Defense
        Relaxed, // -Speed
        // +Special Attack
        Modest, // -Attack
        Mild, // -Defense
        Rash, // -Special Defense
        Quiet, // -Speed
        // +Special Defense
        Calm, // -Attack
        Gentle, // -Defense
        Careful, // -Special Attack
        Sassy, // -Speed
        // +Speed
        Timid, // -Attack
        Hasty, // -Defense
        Jolly, // -Special Attack
        Naive // -Special Defense
    }
}
