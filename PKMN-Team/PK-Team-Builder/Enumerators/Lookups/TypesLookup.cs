using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators.Lookups
{
    internal class TypesLookup
    {
        public static Dictionary<Species, Types[]> typesLookup = new Dictionary<Species, Types[]>()
        {
            {Species.Bulbasaur, new Types[] {Types.Grass, Types.Poison} },
            {Species.Ivysaur, new Types[] {Types.Grass, Types.Poison} },
            {Species.Venusaur, new Types[] {Types.Grass, Types.Poison} },
            {Species.Charmander, new Types[] {Types.Fire, Types.None} },
            {Species.Charmeleon, new Types[] {Types.Fire, Types.None} },
            {Species.Charizard, new Types[] {Types.Fire, Types.Flying} },
        };
    }
}
