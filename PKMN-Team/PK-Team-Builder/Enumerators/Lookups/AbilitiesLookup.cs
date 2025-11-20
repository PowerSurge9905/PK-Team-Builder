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
            // Not every species has 3 unique abilities, some have 1 regular ability and 1 hidden ability, some only have 1 ability
            // Species                           Ability 1           Ability 2           Hidden Ability
            // Generation 1
            {Species.Bulbasaur, new Abilities[] {Abilities.Overgrow, Abilities.Overgrow, Abilities.Chlorophyll} },
            {Species.Ivysaur, new Abilities[] {Abilities.Overgrow, Abilities.Overgrow, Abilities.Chlorophyll } },
            {Species.Venusaur, new Abilities[] {Abilities.Overgrow, Abilities.Overgrow, Abilities.Chlorophyll } },
            {Species.VenusaurMega, new Abilities[] {Abilities.ThickFat, Abilities.ThickFat, Abilities.ThickFat } },
            {Species.Charmander, new Abilities[] {Abilities.Blaze, Abilities.Blaze, Abilities.SolarPower } },
            {Species.Charmeleon, new Abilities[] {Abilities.Blaze, Abilities.Blaze, Abilities.SolarPower } },
            {Species.Charizard, new Abilities[] {Abilities.Blaze, Abilities.Blaze, Abilities.SolarPower } },
            {Species.CharizardMegaX, new Abilities[] {Abilities.ToughClaws, Abilities.ToughClaws , Abilities.ToughClaws } },
            {Species.CharizardMegaY, new Abilities[] {Abilities.Drought, Abilities.Drought, Abilities.Drought } },
            {Species.Squirtle, new Abilities[] {Abilities.Torrent, Abilities.Torrent, Abilities.RainDish } },
            {Species.Wartortle, new Abilities[] {Abilities.Torrent, Abilities.Torrent, Abilities.RainDish } },
            {Species.Blastoise, new Abilities[] {Abilities.Torrent, Abilities.Torrent, Abilities.RainDish } },
            {Species.BlastoiseMega, new Abilities[] {Abilities.MegaLauncher, Abilities.MegaLauncher, Abilities.MegaLauncher } },
        };
    }
}
