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

        // Bind
        public readonly List<Moves> bindMoves = new List<Moves>
        {
            Moves.Bind,
        };

        // Bite
        public readonly List<Moves> biteMoves = new List<Moves>
        {

        };

        // Charge turn
        public readonly List<Moves> chargeMoves = new List<Moves>
        {
            Moves.RazorWind,
            Moves.Fly,
        };

        // Condition
        public readonly Dictionary<Moves, StatusConditions> conditionMoves = new Dictionary<Moves, StatusConditions>
        {
            { Moves.FirePunch, StatusConditions.Burn },
            { Moves.IcePunch, StatusConditions.Freeze }, // Frostbite in PL:A
            { Moves.ThunderPunch, StatusConditions.Paralysis }
        };

        // Contact
        public readonly List<Moves> contactMoves = new List<Moves>
        {
            Moves.Pound,
            Moves.KarateChop,
            Moves.DoubleSlap,
            Moves.CometPunch,
            Moves.MegaPunch,
            Moves.FirePunch,
            Moves.IcePunch,
            Moves.ThunderPunch,
            Moves.Scratch,
            Moves.ViseGrip,
            Moves.Guillotine,
            Moves.Cut,
            Moves.WingAttack,
            Moves.Fly,
            Moves.Bind,
            Moves.Slam,
            Moves.VineWhip,
            Moves.Stomp,
            Moves.DoubleKick,
        };

        // Dance, used for the Ability Dancer
        public readonly List<Moves> danceMoves = new List<Moves>
        {
            Moves.SwordsDance,
        };
        // Healing, used for the Ability Triage
        public readonly List<Moves> healingMoves = new List<Moves>
        {

        };

        // High Crit Rate
        public readonly List<Moves> highCritMoves = new List<Moves>
        {
            Moves.KarateChop,
            Moves.RazorWind,
        };

        // Multi-Hit
        public readonly Dictionary<Moves, int[]> multiHitMoves = new Dictionary<Moves, int[]>
        {
            // Move, min. hits, max. hits
            { Moves.DoubleSlap, [2, 5] },
            { Moves.CometPunch, [2, 5] },
        };

        // OHKO
        public readonly List<Moves> ohkoMoves = new List<Moves>
        {
            Moves.Guillotine,
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
            Moves.MegaPunch,
            Moves.FirePunch,
            Moves.IcePunch,
            Moves.ThunderPunch,
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
