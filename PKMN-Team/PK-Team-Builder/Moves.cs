using PK_Team_Builder.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder
{
    internal class Moves
    {
        public string name { get; }
        public Types type { get; }
        public MoveCategories category { get; }
        public int pp { get; }
        public int power { get; }
        public int accuracy { get; }

        public Moves(string name, Types type, MoveCategories category, int pp, int power, int accuracy)
        {
            this.name = name;
            this.type = type;
            this.category = category;
            this.pp = pp;
            this.power = power;
            this.accuracy = accuracy;
        }

        // Placeholder move
        public static readonly Moves empty = new("Empty", Types.None, MoveCategories.Status, 0, 0, 0);
        // Regular Moves
        // Generation 1
        public static readonly Moves Pound = new("Pound", Types.Normal, MoveCategories.Physical, 35, 40, 100);
        public static readonly Moves KarateChop = new("Karate Chop", Types.Fighting, MoveCategories.Physical, 25, 50, 100); // High critical hit ratio
        public static readonly Moves DoubleSlap = new("Double Slap", Types.Normal, MoveCategories.Physical, 10, 15, 85); // Hits 2-5 times
        public static readonly Moves CometPunch = new("Comet Punch", Types.Normal, MoveCategories.Physical, 15, 18, 85); // Hits 2-5 times
        public static readonly Moves MegaPunch = new("Mega Punch", Types.Normal, MoveCategories.Physical, 20, 80, 85);
        public static readonly Moves PayDay = new("Pay Day", Types.Normal, MoveCategories.Physical, 20, 40, 100); // Scatters coins
        public static readonly Moves FirePunch = new("Fire Punch", Types.Fire, MoveCategories.Physical, 15, 75, 100); // May burn target
        public static readonly Moves IcePunch = new("Ice Punch", Types.Ice, MoveCategories.Physical, 15, 75, 100); // May freeze target
        public static readonly Moves ThunderPunch = new("Thunder Punch", Types.Electric, MoveCategories.Physical, 15, 75, 100); // May paralyze target
        public static readonly Moves Scratch = new("Scratch", Types.Normal, MoveCategories.Physical, 35, 40, 100);
        public static readonly Moves ViseGrip = new("Vise Grip", Types.Normal, MoveCategories.Physical, 30, 55, 100);
        public static readonly Moves Guillotine = new("Guillotine", Types.Normal, MoveCategories.Physical, 5, -1, 30); // OHKO
        public static readonly Moves RazorWind = new("Razor Wind", Types.Normal, MoveCategories.Special, 10, 80, 100); // 2-turn, high crit rate
        public static readonly Moves SwordsDance = new("Swords Dance", Types.Normal, MoveCategories.Status, 20, 0, -1); // Raises user's Attack by 2 stages
        public static readonly Moves Cut = new("Cut", Types.Normal, MoveCategories.Physical, 30, 50, 95);
        public static readonly Moves Gust = new("Gust", Types.Flying, MoveCategories.Special, 35, 40, 100); // Can hit during Fly and Bounce
        public static readonly Moves WingAttack = new("Wing Attack", Types.Flying, MoveCategories.Physical, 35, 60, 100);
        public static readonly Moves Whirlwind = new("Whirlwind", Types.Normal, MoveCategories.Status, 20, 0, -1); // Escape from wild battle, forces switch in trainer battle
        public static readonly Moves Fly = new("Fly", Types.Flying, MoveCategories.Physical, 15, 90, 95); // Semi-invuln turn
        public static readonly Moves Bind = new("Bind", Types.Normal, MoveCategories.Physical, 20, 15, 85); // Deals 1/8 of the target's max HP per turn for 2-5 turns
        public static readonly Moves Slam = new("Slam", Types.Normal, MoveCategories.Physical, 20, 80, 75);
        public static readonly Moves VineWhip = new("Vine Whip", Types.Grass, MoveCategories.Physical, 25, 45, 100);
        public static readonly Moves Stomp = new("Stomp", Types.Normal, MoveCategories.Physical, 20, 65, 100); // May cause target to flinch, bypasses accuracy and doubles power if target has used Minimize
        public static readonly Moves DoubleKick = new("Double Kick", Types.Fighting, MoveCategories.Physical, 30, 30, 100);
    }
}
