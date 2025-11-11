using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Enumerators
{
    internal enum Abilities
    {
        None, // Default, should not be actually used
        // Generation 3
        Stench, // May cause the target to flinch
        Drizzle, // Summons Rain upon entering battle
        SpeedBoost, // Increases Speed stat each turn
        BattleArmor, // Prevents critical hits
        Sturdy, // Prevents being OHKOed from full health
        Damp, // Prevents explosive moves, nullifies Aftermath
        Limber, // Prevents Paralysis
        SandVeil, // Increases Evasion in a Sandstorm
        Static, // May cause Paralysis on contact
        VoltAbsorb, // Heals when hit by Electric-type moves
        WaterAbsorb, // Heals when hit by Water-type moves
        Oblivious, // Prevents Infatuation, Taunt, and Intimidate
        CloudNine, // Negates weather effects
        CompoundEyes, // Increases Accuracy
        Insomnia, // Prevents Sleep
        ColorChange, // Changes type to the type of the move used against it
        Immunity, // Prevents Poison
        FlashFire, // Powers up Fire-type moves if hit by one
        ShieldDust, // Blocks secondary effects of moves
        OwnTempo, // Prevents Confusion and Intimidate
        SuctionCups, // Prevents being forced out of battle
        Intimidate, // Lowers opponent's Attack stat upon entering battle
        ShadowTag, // Prevents opponents from escaping
        RoughSkin, // Inflicts damage on contact
        WonderGuard, // Only super effective moves hit
        Levitate, // Immune to Ground-type moves and certain hazards
        EffectSpore, // May inflict Paralysis, Poison, or Sleep on contact
        Synchronize, // Passes Burn, Paralysis, or Poison to the attacker that inflicted it
        ClearBody, // Prevents stat reduction by others
        NaturalCure, // Heals status conditions upon switching out
        LightningRod, // Draws in all Electric-type moves to boost Special Attack
        SereneGrace, // Increases the chance of secondary effects occurring
        SwiftSwim, // Boosts Speed in Rain
        Chlorophyll, // Boosts Speed in Harsh Sunlight
        Illuminate, // Prevents accuracy from being lowered
        Trace, // Copies opponent's ability upon entering battle
        HugePower, // Doubles the Pokémon's attack stat
        PoisonPoint, // Contact may cause Poison
        InnerFocus, // Prevents flinching and Intimidate
        MagmaArmor, // Prevents Freeze
        WaterViel, // Prevents Burn
        MagnetPull, // Prevents Steel-type Pokémon from fleeing/switching out
        Soundproof, // Immunity to sound-based moves
        RainDish, // Gradually restores HP in Rain
        SandStream, // Summons Sandstorm on entering battle
        Pressure, // Opponents expend more PP when using moves
        ThickFat, // Halves damage from Fire- and Ice-type moves
        EarlyBird, // Awakens from Sleep twice as fast as other Pokémon
        FlameBody, // Contact may cause Burn
        RunAway, // Garuntees escape from wild Pokémon
        KeenEye, // Prevents accuracy from being lowered, ignores target's evasion
        HyperCutter, // Prevents other Pokémon from lowering its Attack stat
        Pickup, // May pick up an item another Pokémon used in battle
        Truant, // Loafs around every other turn
        Hustle, // Boosts Attack, lowers Accuracy
        CuteCharm, // Contact may cause Infatuation
        Plus, // Boosts Special Attack if an ally in battle has Plus or Minus
        Minus, // Boosts Special Attack if an ally in battle has Plus or Minus
        Forecast, // Transforms with the weather, changes type to Water, Fire, or Ice for Rain, Harsh Sunlight, or Hail respectively
        StickyHold, // Held item cannot by removed by other Pokémon
        ShedSkin, // 1/3 chance of curing status condition each turn
        Guts, // Status conditions boost Attack stat
        MarvelScale, // Status conditions boost Defense stat
        LiquidOoze, // Damages attackers that use HP-draining moves
        Overgrow, // Powers up Grass-type moves in a pinch
        Blaze, // Powers up Fire-type moves in a pinch
        Torrent, // Powers up Water-type moves in a pinch
        Swarm, // Powers up Bug-type moves in a pinch
        RockHead, // Prevents recoil damage
        Drought, // Summons Harsh Sunlight on entering battle
        ArenaTrap, // Prevents opponents from fleeing/swapping out
        VitalSpirit, // Prevents Sleep
        WhiteSmoke, // Prevents other Pokémon from lowering its stats
        PurePowder, // Doubles Attack stat
        ShellArmor, // Prevents critical hits
        AirLock, // Negates weather
        // Generation 4
        TangledFeet, // Boosts Evasiveness if the Pokémon is confused
        MotorDrive, // Boosts Speed when hit by Electric-type moves
        Rivalry, // Deals more damage to Pokémon of the same gender, deals less damage to Pokémon of the opposite gender
        Steadfast, // Boosts Speed if it flinches
        SnowCloak, // Boosts evasiveness during Hail/Snow
        Gluttony, // If the Pokémon is holding a berry to eat at low HP, instead eats it at half HP or less
        AngerPoint, // Maximizes Attack when hit with a critical hit
        Unburden, // Boosts speed if the Pokémon's held item is used or lost
        Heatproof, // Halves damage taken from Fire-type moves
        Simple, // Doubles the effects of the Pokémon's stat changes
        DrySkin, // Restores HP in Rain/when hit by Water-type moves, reduces HP in harsh sunlight, increases damage recieved from Fire-type moves
        Download, // Raises Attack or Special Attack depending on the opponent's lower defensive stat, increases Special Attack if opponent's defensive stats are equal
        IronFist, // Powers up punching moves
        PoisonHeal, // Restores HP when poisoned
        Adaptability, // 2x STAB damage instead of 1.5, Tera STAB becomes 2.25 instead of 2
        SkillLink, // Moves that hit a variable amount of times always hit the maximum amount of times
        Hydration, // Cures status conditions in rain
        SolarPower, // Boosts Special Attack but each turn decreases HP in Harsh Sunlight
        QuickFeet, // Boosts Speed if the Pokémon has a status condition
        Normalize, // The Pokémon's moves become Normal-type, recieve a 20% power boost
        Sniper, // The Pokémon's crits get even more power
        MagicGuard, // Only takes damage from attacking moves
        NoGuard, // Incoming and outgoing attacks always land
        Stall, // The Pokémon always moves last
        Technician, // Moves with 60 base power or less get a 50% boost
        LeafGuard, // Prevents status conditions in Harsh Sunlight
        Klutz, // The Pokémon cannot use held items
        MoldBreaker, // The Pokémon's moves are unimpeded by the target's ability
        SuperLuck, // Boosts the Pokémon's critical-hit ratio
        Aftermath, // Damages the attacker if the Pokémon is KOed with a contact move
        Anticipation, // On entering battle, the Pokémon can detect if an opponent has super-effective moves
        Forewarn, // On entering batle, the Pokémon tells one of the opponent's moves
        Unaware, // Ignores the opponent's stat changes when attacking
        TintedLens, // Not-very-effective moves deal regular damage
        Filter, // Reduces power of incoming super-effective moves
        SlowStart, // The Pokémon's Attack and Speed stats are halved for 5 turns
        Scrappy, // The Pokémon can hit Ghost-types with Normal- and Fighting-type moves, prevents Intimidate
        StormDrain, // Draws in all Water-type moves, boosts Special Attack
        IceBody, // Restores HP in Hail/Snow
        SolidRock, // Reduces power of incoming super-effective moves
        SnowWarning, // Summons Hail(Before Gen 9)/ Snow(After Gen 9) on entering battle
        HoneyGather, // The Pokémon may gather Honey after battle
        Frisk, // On entering battle, tells the opponent's held item
        Reckless, // Powers up recoil moves, except Struggle
        Mulitype, // The Pokémon's type matches the plate it holds
        FlowerGift, // Boosts it's and allies' Attack and Special Defense in Harsh Sunlight
        BadDreams, // Damages opponents that are Asleep
        // Generation 5
    }
}
