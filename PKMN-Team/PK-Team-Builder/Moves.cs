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
        public int powerPoints { get; }
        public int power { get; }
        public int accuracy { get; }
        public bool hasExtraEffect { get; }

        public Moves(int id, string name, Types type, MoveCategories category, int pp, int power, int accuracy, bool hasExtraEffect)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.category = category;
            this.powerPoints = pp;
            this.power = power;
            this.accuracy = accuracy;
            this.hasExtraEffect = hasExtraEffect;
        }

        public static readonly Moves Pound = new(1, "Pound", Types.Normal, MoveCategories.Physical, 35, 40, 100, false);
        public static readonly Moves KarateChop = new(2, "Karate Chop", Types.Fighting, MoveCategories.Physical, 25, 50, 100, true); // High critical hit ratio
    }
}
