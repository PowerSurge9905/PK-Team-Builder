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
        Pickpocket, // Steals held item from attackers that make contact
        SheerForce, // Removes additional effects from moves, but increases the moves' power
        Contrary, // Reverses stat changes
        Unnerve, // Opponents are unable to eat berries
        Defiant, // Boosts Attack if an opponent lowers any of its stats
        Defeatist, // Halves the Pokémon's Attack and Special Attack when its HP drops to half or less
        CursedBody, // May disable a move that has damaged the Pokémon
        Healer, // Sometimes cures allies' status conditions
        FriendGuard, // Reduces damage dealt to allies
        WeakArmor, // When hit by a physical move, reduces Defense and sharply boosts Speed
        HeavyMetal, // Doubles the Pokémon's weight
        LightMetal, // Halves the Pokémon's weight
        Multiscale, // Reduces damage recieved when the Pokémon is at full HP
        ToxicBoost, // Powers up physical moves when the Pokémon is Poisoned
        FlareBoost, // Powers up special moves when the Pokémon is Burned
        Harvest, // May create another berry after one is used
        Telepathy, // The Pokémon can anticipate and dodge attacks from its allies
        Moody, // Every turn, one stat will be sharply boosted, but another stat will be lowered
        Overcoat, // The Pokémon takes no damage from Sandstorms and is unaffected by powders and spores
        PoisonTouch, // May poison the target on contact
        Regenerator, // Restores a little HP when withdrawn from battle
        BigPecks, // Prevents the Pokémon's Defense from being lowered
        SandRush, // Boosts the Pokémon's Speed in a Sandstorm
        WonderSkin, // Status moves are more likely to miss the Pokémon
        Analytic, // Boosts the power of the Pokémon's move it is the last to act that turn
        Illusion, // The Pokémon enters battle disguised as the last Pokémon in the player's party
        Imposter, // The Pokémon transforms itself into the Pokémon it's facing
        Infiltrator, // The Pokémon's moves are unaffected by the target's barriers, substitutes, etc.
        Mummy, // Contact with the Pokémon changes the attacker's Ability to Mummy
        Moxie, // Boosts the Pokémon's Attack when it KOs a target
        Justified, // Boosts the Pokémon's Attack when it's hit by a Dark-type move
        Rattled, // Boosts the Pokémon's Speed when it's hit by a Dark-, Ghost-, or Bug-type move or when Intimidated
        MagicBounce, // Reflects status moves back at the attacker
        SapSipper, // Boosts the Pokémon's Attack when hit by Grass-type moves, takes no damage from them
        Prankster, // Gives priority to the Pokémon's status moves
        SandForce, // Boosts the power of Rock-, Ground-, and Steel-type moves in a Sandstorm
        IronBarbs, // Damages attackers that make contact
        ZenMode, // Changes the Pokémon to Zen mode when its HP is half or less
        VictoryStar, // Boosts the accuracy of the Pokémon and its allies
        Turboblaze, // The Pokémon's moves are unimpeded by the Ability of the target
        Teravolt, // The Pokémon's moves are unimpeded by the Ability of the target
        // Generation 6
        AromaVeil, // Protects the Pokémon and its allies from effects that prevent the use of moves
        FlowerVeil, // Ally Grass-type Pokémon are protected from status conditions and stat lowerings
        CheekPouch, // The Pokémon's HP is restored when it eats a berry, in addition the berry's regular effects
        Protean, // Once per entry/switch-in, the Pokémon changes its type to the type of the move it's about to use
        FurCoat, // Halves damage taken from physical moves
        Magician, // Steals the target's held item on hitting it with a move
        Bulletproof, // Protects the Pokémon from ball and bomb moves
        Competitive, // Boosts the Pokémon's Special Attack sharply when any stat is lowered by an opponent
        StrongJaw, // Boosts the power of biting moves
        Refrigerate, // Normal-type moves become Ice-type, these moves get boosted
        SweetVeil, // Prevents the Pokémon and its allies from falling asleep
        StanceChange, // The Pokémon changes to Blade Forme when using an attacking move, and Shield Forme when using King's Shield
        GaleWings, // Gives priority to the Pokémon's Flying-type moves when its HP is full
        MegaLauncher, // Powers up pulse moves
        GrassPelt, // Boosts the Pokémon's Defense on Grassy Terrain
        Symbiosis, // The Pokémon passes its held item to an ally that has used up an item
        ToughClaws, // Powers up contact moves
        Pixilate, // Normal-type moves become Fairy-type, these moves get boosted
        Gooey, // Contact with the Pokémon lowers the attacker's Speed
        Aerilate, // Normal-type moves become Flying-type, these moves get boosted
        ParentalBond, // The parent and child attack one after the other
        DarkAura, // Powers up Dark-type moves used by any Pokémon on the field
        FairyAura, // Powers up Fairy-type moves used by any Pokémon on the field
        AuraBreak, // The effects of "Aura" Abilities are reversed to lower the power of affected moves
        PrimordialSea, // The Pokémon changes the weather to nullify Fire-type moves
        DesolateLand, // The Pokémon changes the weather to nullify Water-type moves
        DeltaStream, // The Pokémon changes the weather so that no moves are supereffective against the Flying-type
        // Generation 7
    }
}
