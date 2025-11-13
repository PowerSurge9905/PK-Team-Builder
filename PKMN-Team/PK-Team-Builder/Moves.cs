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
        public bool contact { get; }

        public Moves(string name, Types type, MoveCategories category, int pp, int power, int accuracy, bool contact)
        {
            this.name = name;
            this.type = type;
            this.category = category;
            this.pp = pp;
            this.power = power;
            this.accuracy = accuracy;
            this.contact = contact;
        }

        // Placeholder move
        public static readonly Moves empty = new("Empty", Types.None, MoveCategories.Status, 0, 0, 0, false);
        // Regular Moves
        // Generation 1
        public static readonly Moves Pound = new("Pound", Types.Normal, MoveCategories.Physical, 35, 40, 100, true);
        public static readonly Moves KarateChop = new("Karate Chop", Types.Fighting, MoveCategories.Physical, 25, 50, 100, true); // High critical hit ratio
        public static readonly Moves DoubleSlap = new("Double Slap", Types.Normal, MoveCategories.Physical, 10, 15, 85, true); // Hits 2-5 times
        public static readonly Moves CometPunch = new("Comet Punch", Types.Normal, MoveCategories.Physical, 15, 18, 85, true); // Hits 2-5 times
    }
}
