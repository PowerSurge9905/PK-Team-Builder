using PK_Team_Builder.Enumerators;
using PK_Team_Builder.Enumerators.Lookups;
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
        protected int natDexNumber { get; set; } = 0;
        protected Species species;
        protected int baseHP { get; set; }
        protected int baseAtk { get; set; }
        protected int baseDef { get; set; }
        protected int baseSpAtk { get; set; }
        protected int baseSpDef { get; set; }
        protected int baseSpeed { get; set; }

        // Individual Values (IVs)
        protected int hpIV { get; set; } = 0;
        protected int atkIV { get; set; } = 0;
        protected int defIV { get; set; } = 0;
        protected int spAtkIV { get; set; } = 0;
        protected int spDefIV { get; set; } = 0;
        protected int speedIV { get; set; } = 0;

        // Effort Values (EVs)
        protected int hpEV { get; set; } = 0;
        protected int atkEV { get; set; } = 0;
        protected int defEV { get; set; } = 0;
        protected int spAtkEV { get; set; } = 0;
        protected int spDefEV { get; set; } = 0;
        protected int speedEV { get; set; } = 0;
        public int maxEVPerStat = 255;
        public const int maxEV = 510;

        protected int dynamaxLevel { get; set; } = 0;
        public const int maxDynamaxLevel = 10;

        protected Types[] types { get; set; } = {Types.None,Types.None};

        protected Types teraType { get; set; } = Types.None;

        protected Natures nature { get; set; } = Natures.Hardy;
        protected Natures statNature { get; set; } = Natures.Hardy;

        protected int level { get; set; } = 1;
        protected const int maxLevel = 100;
        protected int currentHP { get; set; } = 0;
        protected int maxHP { get; set; } = 0;
        protected Genders[] possibleGenders { get; set; } = { Genders.Unknown };
        protected Genders gender { get; set; } = Genders.Unknown;

        protected bool isNicknamed { get; set; } = false;
        protected string nickname { get; set; } = "";

        protected bool isShiny { get; set; } = false;

        protected Abilities[] possibleAbilities { get; set; } = { Abilities.None, Abilities.None, Abilities.None };
        protected Abilities ability { get; set; } = Abilities.None;

        protected HeldItems heldItem = HeldItems.None;

        protected Moves[] currentMoves { get; set; } = { Moves.empty, Moves.empty, Moves.empty, Moves.empty };
        protected Dictionary<int, Moves> levelUpMovePool { get; set; }
        protected List<Moves> TMMovePool { get; set; }
        protected List<Moves> moveTutorPool { get; set; }
        protected List<Moves> eggMovePool { get; set; }

        // Abstract methods for calculating HP and other stats (Gen 1 & 2)
        // Decide on whether to keep these, not sure if I want to include old calculations
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

        // Get nature modifier for a given stat
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

        public static decimal GetTypeEffectiveness(Moves move, Types defending)
        {
            // Attacking type is the row, defending type is the column
            decimal[,] matchupChart = {
               //NOR FIR WAT ELE GRA ICE FIG POI GRO FLY PSY BUG ROC GHO DRA DAR STE FAI NON
                {1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  .5m,0,  1,  1,  .5m,1,  1  }, /*NOR*/
                {1,  .5m,.5m,1,  2,  2,  1,  1,  1,  1,  1,  2,  .5m,1,  .5m,1,  2,  1,  1  }, /*FIR*/
                {1,  2,  .5m,1,  .5m,1,  1,  1,  2,  1,  1,  1,  2,  1,  .5m,1,  1,  1,  1  }, /*WAT*/
                {1,  1,  2,  .5m,.5m,1,  1,  1,  0,  2,  1,  1,  1,  1,  .5m,1,  1,  1,  1  }, /*ELE*/
                {1,  .5m,2,  1,  .5m,1,  1,  .5m,2,  .5m,1,  .5m,2,  1,  .5m,1,  .5m,1,  1  }, /*GRA*/
                {1,  .5m,.5m,1,  2,  .5m,1,  1,  2,  2,  1,  1,  1,  1,  2,  1,  .5m,1,  1  }, /*ICE*/
                {2,  1,  1,  1,  1,  2,  1,  .5m,1,  .5m,.5m,.5m,2,  0,  1,  2,  2,  .5m,1  }, /*FIG*/
                {1,  1,  1,  1,  2,  1,  1,  .5m,.5m,1,  1,  1,  .5m,.5m,1,  1,  0,  2,  1  }, /*POI*/
                {1,  2,  1,  2,  .5m,1,  1,  2,  1,  0,  1,  .5m,2,  1,  1,  1,  2,  1,  1  }, /*GRO*/
                {1,  1,  1,  .5m,2,  1,  2,  1,  1,  1,  1,  2,  .5m,1,  1,  1,  .5m,1,  1  }, /*FLY*/
                {1,  1,  1,  1,  1,  1,  2,  2,  1,  1,  .5m,1,  1,  1,  1,  0,  .5m,1,  1  }, /*PSY*/
                {1,  .5m,1,  1,  2,  1,  .5m,.5m,1,  .5m,2,  1,  1,  .5m,1,  2,  .5m,.5m,1  }, /*BUG*/
                {1,  2,  1,  1,  1,  2,  .5m,1,  .5m,2,  1,  2,  1,  1,  1,  1,  .5m,1,  1  }, /*ROC*/
                {0,  1,  1,  1,  1,  1,  1,  1,  1,  1,  2,  1,  1,  2,  1,  .5m,1,  1,  1  }, /*GHO*/
                {1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  2,  1,  .5m,0,  1  }, /*DRA*/
                {1,  1,  1,  1,  1,  1,  .5m,1,  1,  1,  2,  1,  1,  2,  1,  .5m,1,  .5m,1  }, /*DAR*/
                {1,  .5m,.5m,.5m,1,  2,  1,  1,  1,  1,  1,  1,  2,  1,  1,  1,  .5m,2,  1  }, /*STE*/
                {1,  .5m,1,  1,  1,  1,  2,  .5m,1,  1,  1,  1,  1,  1,  2,  2,  .5m,1,  1  }, /*FAI*/
                {1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1  }  /*NON*/
            };
            return matchupChart[(int)move.type, (int)defending];
        }

        public void InitializePokemon(Species species)
        {
            this.species = species;
            InitializeBaseStats(species);
            InitializeTypes(species);
            InitializeAbilities(species);
        }

        protected void InitializeBaseStats(Species species)
        {
            this.baseHP = BaseStatsLookup.baseStatsLookup[species][0];
            this.baseAtk = BaseStatsLookup.baseStatsLookup[species][1];
            this.baseDef = BaseStatsLookup.baseStatsLookup[species][2];
            this.baseSpAtk = BaseStatsLookup.baseStatsLookup[species][3];
            this.baseSpDef = BaseStatsLookup.baseStatsLookup[species][4];
            this.baseSpeed = BaseStatsLookup.baseStatsLookup[species][5];
            this.maxHP = CalculateHP();
            this.currentHP = this.maxHP;
        }

        protected void InitializeTypes(Species species)
        {
            this.types = TypesLookup.typesLookup[species];
            this.teraType = this.types[0];
        }

        protected void InitializeAbilities(Species species)
        {
            this.possibleAbilities = AbilitiesLookup.abilitiesLookup[species];
            this.ability = this.possibleAbilities[0];
        }
    }
}
