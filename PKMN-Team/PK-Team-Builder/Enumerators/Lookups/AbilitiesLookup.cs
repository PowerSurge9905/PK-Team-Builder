using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators.Lookups
{
    internal class AbilitiesLookup
    {
        public static Dictionary<Species, Abilities[]> abilitiesLookup = new Dictionary<Species, Abilities[]>()
        {
            // Not every species has 3 unique abilities, some have 1 regular ability and 1 hidden ability
            // Species                           Ability 1           Ability 2           Hidden Ability
            {Species.Bulbasaur, new Abilities[] {Abilities.Overgrow, Abilities.Overgrow, Abilities.Chlorophyll} },
        };
    }
}
