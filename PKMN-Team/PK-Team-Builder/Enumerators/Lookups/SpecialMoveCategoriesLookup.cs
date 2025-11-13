using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators.Lookups
{
    internal class SpecialMoveCategoriesLookup
    {
        // Ball & Bomb
        public readonly List<Moves> ballMoves = new List<Moves>
        {

        };

        // Bite
        public readonly List<Moves> biteMoves = new List<Moves>
        {

        };

        // Dance, used for the Ability Dancer
        public readonly List<Moves> danceMoves = new List<Moves>
        {

        };
        // Healing, used for the Ability Triage
        public readonly List<Moves> healingMoves = new List<Moves>
        {

        };

        // High Crit Rate
        public readonly List<Moves> highCritMoves = new List<Moves>
        {
            Moves.KarateChop,
        };

        // Multi-Hit
        public readonly Dictionary<Moves, int[]> multiHitMoves = new Dictionary<Moves, int[]>
        {
            // Move, min. hits, max. hits
            {Moves.DoubleSlap, [2, 5] },
            {Moves.CometPunch, [2, 5] },
        };

        // Powder
        public readonly List<Moves> powderMoves = new List<Moves>
        {

        };

        // Pulse
        public readonly List<Moves> pulseMoves = new List<Moves>
        {

        };
        
        // Punch
        public readonly List<Moves> punchMoves = new List<Moves>
        {
            Moves.CometPunch,
        };
        
        // Recoil
        public readonly List<Moves> recoilMoves = new List<Moves>
        {

        };

        // Slicing
        public readonly List<Moves> slicingMoves = new List<Moves>
        {

        };
        
        // Sound
        public readonly List<Moves> soundMoves = new List<Moves>
        {

        };
        
        // Spore
        public readonly List<Moves> sporeMoves = new List<Moves>
        {

        };

        // Wind
        public readonly List<Moves> windMoves = new List<Moves>
        {

        };
    }
}
