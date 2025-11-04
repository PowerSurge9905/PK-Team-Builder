using PK_Team_Builder.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder
{
    internal abstract class Pokemon
    {
        protected Pokemon()
        {
        }

        // Species and Base Stats
        // Remember: Spe. Atk and Def are one stat - SPECIAL - in Gen 1 and 2
        protected Species species;
        protected int baseHP = 0;
        protected int baseAtk = 0;
        protected int baseDef = 0;
        protected int baseSpAtk = 0;
        protected int baseSpDef = 0;
        protected int baseSpeed = 0;

        // Individual Values (IVs)
        // Remember: Spe. Atk and Def are one stat - SPECIAL - in Gen 1 and 2
        protected int hpIV = 0;
        protected int atkIV = 0;
        protected int defIV = 0;
        protected int spAtkIV = 0;
        protected int spDefIV = 0;
        protected int speedIV = 0;

        // Effort Values (EVs)
        // Max EVs in Gen 1 and 2 is 65535 per stat, maxing out at 327675 total
        // Remember: Spe. Atk and Def are one stat - SPECIAL - in Gen 1 and 2
        protected int hpEV = 0;
        protected int atkEV = 0;
        protected int defEV = 0;
        protected int spAtkEV = 0;
        protected int spDefEV = 0;
        protected int speedEV = 0;
        // Use 65535 and ignore overall max if the user is calculating Gen 1 or 2 stats
        public const int maxEVPerStat = 255;
        public const int maxEV = 510;

        protected Types[] types = [Types.None, Types.None];

        protected Types teraType = Types.None;

        protected Natures nature = Natures.Hardy;
        protected Natures statNature = Natures.Hardy;

        protected int level = 1;
        protected int maxLevel = 100;
        protected int currentHP = 0;

        protected Genders gender = Genders.Unknown;

        protected bool isNicknamed = false;
        protected string nickname = "";

        protected bool isShiny = false;

        protected Abilities[] possibleAbilities = {Abilities.None, Abilities.None, Abilities.None};
        protected Abilities ability = Abilities.None;

        protected HeldItems heldItem = HeldItems.None;
        // Moveset - Current Moves
        // Moveset - Level up & evolution
        // Moveset - TMs/HMs
        // Moveset - Move Tutor
        // Moveset - Egg Moves

        // TODO: Determine whether to declare moveset here or in each species' class

        // Abstract methods for calculating HP and other stats (Gen 1 & 2)
        public int CalculateHPOld()
        {
            return (int)(Math.Floor((((baseHP + hpIV) * 2 + Math.Floor(Math.Ceiling(Math.Sqrt(hpEV)) / 4)) * level) / 100) + level + 10);
        }
        public int CalculateStatsOld(Stats stat)
        {
            int baseStat = 0;
            int IV = 0;
            int EV = 0;
            switch (stat)
            {
                case Stats.Attack:
                    baseStat = baseAtk;
                    IV = atkIV;
                    EV = atkEV;
                    break;
                case Stats.Defense:
                    baseStat = baseDef;
                    IV = defIV;
                    EV = defEV;
                    break;
                case Stats.Special:
                    baseStat = baseSpAtk; // In Gen 1 and 2, Special Attack and Special Defense share the same base stat
                    IV = spAtkIV;        // In Gen 1 and 2, Special Attack and Special Defense share the same IV
                    EV = spAtkEV;        // In Gen 1 and 2, Special Attack and Special Defense share the same EV
                    break;
                case Stats.Speed:
                    baseStat = baseSpeed;
                    IV = speedIV;
                    EV = speedEV;
                    break;
                default:
                    throw new ArgumentException("Invalid stat for Gen 1/2 calculation! Did you mean \\\"Special\\\"?");
            }
            return (int)(Math.Floor((((baseStat + IV) * 2 + Math.Floor(Math.Ceiling(Math.Sqrt(EV)) / 4)) * level) / 100) + 5);
        }

        // Abstract methods for calculating HP and other stats (Gen 3+)
        public int CalculateHP()
        {
            return ((2 * baseHP + hpIV + (hpEV / 4)) * level / 100) + level + 10;
        }
        public int CalculateStats(Stats stat)
        {
            int baseStat = 0;
            int IV = 0;
            int EV = 0;
            switch(stat)
            {
                case Stats.Attack:
                    baseStat = baseAtk;
                    IV = atkIV;
                    EV = atkEV;
                    break;
                case Stats.Defense:
                    baseStat = baseDef;
                    IV = defIV;
                    EV = defEV;
                    break;
                case Stats.SpecialAttack:
                    baseStat = baseSpAtk;
                    IV = spAtkIV;
                    EV = spAtkEV;
                    break;
                case Stats.SpecialDefense:
                    baseStat = baseSpDef;
                    IV = spDefIV;
                    EV = spDefEV;
                    break;
                case Stats.Speed:
                    baseStat = baseSpeed;
                    IV = speedIV;
                    EV = speedEV;
                    break;
                default:
                    throw new ArgumentException("Invalid stat for Gen 3+ calculation!");
            }

            return (int)Math.Floor((((2 * baseStat + IV + (EV / 4)) * level / 100) + 5) * GetNatureModifier(stat));
        }

        public decimal GetNatureModifier(Stats stat)
        {
            switch(statNature)
            {
                // Neutral natures
                case Natures.Hardy:
                case Natures.Docile:
                case Natures.Bashful:
                case Natures.Quirky:
                case Natures.Serious:
                    return 1.0m;
                // +Attack
                case Natures.Lonely:
                    return stat == Stats.Attack ? 1.1m : stat == Stats.Defense ? 0.9m : 1.0m;
                case Natures.Adamant:
                    return stat == Stats.Attack ? 1.1m : stat == Stats.SpecialAttack ? 0.9m : 1.0m;
                case Natures.Naughty:
                    return stat == Stats.Attack ? 1.1m : stat == Stats.SpecialDefense ? 0.9m : 1.0m;
                case Natures.Brave:
                    return stat == Stats.Attack ? 1.1m : stat == Stats.Speed ? 0.9m : 1.0m;
                // +Defense
                case Natures.Bold:
                    return stat == Stats.Defense ? 1.1m : stat == Stats.Attack ? 0.9m : 1.0m;
                case Natures.Impish:
                    return stat == Stats.Defense ? 1.1m : stat == Stats.SpecialAttack ? 0.9m : 1.0m;
                case Natures.Lax:
                    return stat == Stats.Defense ? 1.1m : stat == Stats.SpecialDefense ? 0.9m : 1.0m;
                case Natures.Relaxed:
                    return stat == Stats.Defense ? 1.1m : stat == Stats.Speed ? 0.9m : 1.0m;
                // +Special Attack
                case Natures.Modest:
                    return stat == Stats.SpecialAttack ? 1.1m : stat == Stats.Attack ? 0.9m : 1.0m;
                case Natures.Mild:
                    return stat == Stats.SpecialAttack ? 1.1m : stat == Stats.Defense ? 0.9m : 1.0m;
                case Natures.Rash:
                    return stat == Stats.SpecialAttack ? 1.1m : stat == Stats.SpecialDefense ? 0.9m : 1.0m;
                case Natures.Quiet:
                    return stat == Stats.SpecialAttack ? 1.1m : stat == Stats.Speed ? 0.9m : 1.0m;
                // +Special Defense
                case Natures.Calm:
                    return stat == Stats.SpecialDefense ? 1.1m : stat == Stats.Attack ? 0.9m : 1.0m;
                case Natures.Gentle:
                    return stat == Stats.SpecialDefense ? 1.1m : stat == Stats.Defense ? 0.9m : 1.0m;
                case Natures.Careful:
                    return stat == Stats.SpecialDefense ? 1.1m : stat == Stats.SpecialAttack ? 0.9m : 1.0m;
                case Natures.Sassy:
                    return stat == Stats.SpecialDefense ? 1.1m : stat == Stats.Speed ? 0.9m : 1.0m;
                // +Speed
                case Natures.Timid:
                    return stat == Stats.Speed ? 1.1m : stat == Stats.Attack ? 0.9m : 1.0m;
                case Natures.Hasty:
                    return stat == Stats.Speed ? 1.1m : stat == Stats.Defense ? 0.9m : 1.0m;
                case Natures.Jolly:
                    return stat == Stats.Speed ? 1.1m : stat == Stats.SpecialAttack ? 0.9m : 1.0m;
                case Natures.Naive:
                    return stat == Stats.Speed ? 1.1m : stat == Stats.SpecialDefense ? 0.9m : 1.0m;
                default:
                    throw new ArgumentException("Invalid nature for stat modifier calculation!");
            }
        }
    }
}
