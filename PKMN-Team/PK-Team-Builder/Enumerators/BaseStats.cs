using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators
{
    internal class BaseStats
    {
        public static Dictionary<Species, int[]> baseStatsLookup = new Dictionary<Species, int[]>()
        {
            // Species                       HP, Atk,Def,SpA,SpD,Spe
            { Species.Bulbasaur, new int[] { 45, 49, 49, 65, 65, 45 } },
            { Species.Ivysaur, new int[] { 60, 62, 63, 80, 80, 60 } },
            { Species.Venusaur, new int[] { 80, 82, 83, 100, 100, 80 } },
            { Species.VenusaurMega, new int[] { 80, 100, 123, 122, 120, 80 } },
            { Species.Charmander, new int[] { 39, 52, 43, 60, 50, 65 } },
            { Species.Charmeleon, new int[] { 58, 64, 58, 80, 65, 80 } },
            { Species.Charizard, new int[] { 78, 84, 78, 109, 85, 100 } },
            { Species.CharizardMegaX, new int[] { 78, 130, 111, 130, 85, 100 } },
            { Species.CharizardMegaY, new int[] { 78, 104, 78, 159, 115, 100 } },
            { Species.Squirtle, new int[] { 44, 48, 65, 50, 64, 43 } },
            { Species.Wartortle, new int[] { 59, 63, 80, 65, 80, 58 } },
            { Species.Blastoise, new int[] { 79, 83, 100, 85, 105, 78 } },
            { Species.BlastoiseMega, new int[] { 79, 103, 120, 135, 115, 78 } },
            { Species.Caterpie, new int[] { 45, 30, 35, 20, 20, 45 } },
            { Species.Metapod, new int[] { 50, 20, 55, 25, 25, 30 } },
            { Species.Butterfree, new int[] { 60, 45, 50, 90, 80, 70 } },
            { Species.Weedle, new int[] { 40, 35, 30, 20, 20, 50 } },
            { Species.Kakuna, new int[] { 45, 25, 50, 25, 25, 35 } },
            { Species.Beedrill, new int[] { 65, 90, 40, 45, 80, 75 } },
            { Species.BeedrillMega, new int[] { 65, 150, 40, 15, 80, 145 } },
            { Species.Pidgey, new int[] { 40, 45, 40, 35, 35, 56 } },
            { Species.Pidgeotto, new int[] { 63, 60, 55, 50, 50, 71 } },
            { Species.Pidgeot, new int[] { 83, 80, 75, 70, 70, 101 } },
            { Species.PidgeotMega, new int[] { 83, 80, 80, 135, 80, 121 } },
            { Species.Rattata, new int[] { 30, 56, 35, 25, 35, 72 } },
            { Species.RattataAlolan, new int[] { 30, 56, 35, 25, 35, 72 } },
        };
    }
}
