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
        public int id { get; }
        public string name { get; }
        public Types type { get; }
        public MoveCategories category { get; }
        public SpecialMoveCategories specialCategory { get; }
        public int powerPoints { get; }
        public int power { get; }
        public int accuracy { get; }
        public bool contact { get; }
        public bool hasExtraEffect { get; }

        public Moves(int id, string name, Types type, MoveCategories category, SpecialMoveCategories specialCategory, int pp, int power, int accuracy, bool contact, bool hasExtraEffect)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.category = category;
            this.specialCategory = specialCategory;
            this.powerPoints = pp;
            this.power = power;
            this.accuracy = accuracy;
            this.contact = contact;
            this.hasExtraEffect = hasExtraEffect;
        }

        // Placeholder move
        public static readonly Moves empty = new(0, "Empty", Types.None, MoveCategories.Status, SpecialMoveCategories.None, 0, 0, 0, false, false);
        // Actual moves
        public static readonly Moves Pound = new(1, "Pound", Types.Normal, MoveCategories.Physical, SpecialMoveCategories.None, 35, 40, 100, true, false);
        public static readonly Moves KarateChop = new(2, "Karate Chop", Types.Fighting, MoveCategories.Physical, SpecialMoveCategories.None, 25, 50, 100, true, true); // High critical hit ratio
    }
}
