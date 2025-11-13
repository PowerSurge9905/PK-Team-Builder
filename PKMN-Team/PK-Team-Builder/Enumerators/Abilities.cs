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
        Trace, // Copies opponent's Ability upon entering battle
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
        Forecast, // Transforms with the weather, changes type to Water, Fire, or Ice for Rain, Harsh Sunlight, or Hail/Snow respectively
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
        MoldBreaker, // The Pokémon's moves are unimpeded by the target's Ability
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
        SnowWarning, // Summons Hail/Snow on entering battle
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
        Stamina, // Boosts Defense when the Pokémon is hit by an attack
        WimpOut, // The Pokémon switches out when its HP drops to half or less
        EmergencyExit, // The Pokémon switches out when its HP drops to half or less
        WaterCompaction, // Sharply boosts Defense when the Pokémon is hit by a Water-type move
        Merciless, // The Pokémon's attacks become critical hits if the target is Poisoned
        ShieldsDown, // When its HP drops to half or less, the Pokémon's shell breaks
        Stakeout, // Doubles damage dealt to a target that has just switched into battle
        WaterBubble, // Takes less damage from Fire-type moves, cannot be burned
        Steelworker, // Powers up Steel-type moves
        Berserker, // Boosts Special Attack then the Pokémon takes a hit that causes its HP to drop to half or less
        SlushRush, // Boosts Speed in Hail/Snow
        LongReach, // The Pokémon can use contact moves without makin contact
        LiquidVoice, // Sound-based moves become Water-type
        Triage, // Gives priority to the Pokémon's healing moves
        Galvanize, // Normal-type moves become Electric-type, these moves get boosted
        SurgeSurfer, // Doubles Speed on Elecric Terrain
        Schooling, // The Pokémon forms a powerful school, stops schooling at low HP
        Disguise, // Once per battle, the Pokémon is protected from an attack at the cost of 12.5% of its HP
        BattleBond, // When the Pokémon KOs a target, its Attack, Special Attack, and Speed are boosted
        PowerConstruct, // When the Pokémon's HP drops to half or less, it changes to Complete Forme
        Corrosion, // The Pokémon can poison the target even if its' Steel- or Poison-type
        Comatose, // The Pokémon is always drowsing and can attack in its sleeping state
        QueenlyMajesty, // Opponents are unable to use priority moves against the Pokémon or its allies
        InnardsOut, // When the Pokémon is KOed, it damages its attacker by the amount equal to the HP it had before it was hit
        Dancer, // Whenever a dance move is used in battle, the Pokémon will cop the user to immediately perform that dance move itself
        Battery, // Powers up ally Pokémon's special moves
        Fluffy, // Halves contact damage recieved, doubles damage recieved from Fire-type moves
        Dazzling, // Opponents are unable to use priority moves against the Pokémon or its allies
        SoulHeart, // Boosts the Pokémon's Special Attack every time another Pokémon faints
        TanglingHair, // Contact with the Pokémon lowers the attacker's Speed
        Receiver, // The Pokémon copies the Ability of a defeated ally
        PowerOfAlchemy, // The Pokémon copies the Ability of a defeated ally
        BeastBoost, // Boosts the Pokémon's most proficient stat every time it KOs a target
        RKSSystem, // The Pokémon's type matches the memory it holds
        ElectricSurge, // Turns the ground into Electric Terrain upon entering battle
        PsychicSurge, // Turns the ground into Psychic Terrain upon entering battle
        MistySurge, // Turns the ground into Misty Terrain upon entering battle
        GrassySurge, // Turns the ground into Grassy Terrain upon entering battle
        FullMetalBody, // Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats
        ShadowShield, // Reduces the damage the Pokémon takes at full HP
        PrismArmor, // Reduces the power of supereffective attacks that hit the Pokémon
        Neuroforce, // Powers up the Pokémon's supereffective attacks even further
        // Generation 8
        IntrepidSword, // Boosts the Pokémon's Attack upon entering battle for the first time
        DauntlessShield, // Boosts the Pokémon's Defense upon entering battle for the first time
        Libero, // Once per entry/switch-in, the Pokémon changes its type to the type of the move it's about to use
        BallFetch, // If not holding an item, the Pokémon will fetch the Poké Ball from the first failed throw of the battle
        CottonDown, // When hit by an attack, lowers the Speed of all Pokémon except itself
        PropellerTail, // Ignores the effects of opposing Pokémon's Abilities and moves that draw in moves
        MirrorArmor, // Reflects only stat-lowering effects
        GulpMissile, // When the Pokémon uses Surf or Dive, it will come back with prey. When it takes damage, it will spit out the prey to attack
        Stalwart, // Ignores he effects of opposing Pokémon Abilites and moves that draw in moves
        SteamEngine, // Boosts Speed drastically when the Pokémon is hit by a Fire- or Water-type move
        PunkRock, // Boosts sound-based moves, halves damage recieved from sound-based moves
        SandSpit, // Creates a sandstorm when hit by an attack
        IceScales, // Halves damage taken from special moves
        Ripen, // Doubles the effects of berries
        IceFace, // The Pokémon's ice head acts as a substitute to physical moves, and is restored when Hail/Snow starts
        PowerSpot, // Boosts allies' moves
        Mimicry, // The Pokémon's type changes depending on Terrain
        ScreenCleaner, // Nullifies Light Screen, Reflect, and Aurora Veil on both sides upon entering battle
        SteelySpirit, // Powers up Steel-type moves of the Pokémon and its allies
        PerishBody, // When hit by a contact move, the Pokémon and the attacker will perish in three turns
        WanderingSpirit, // Exchanges ability with an attacker that makes contact
        GorillaTactics, // Boosts Attack, but only allows use of the first selected move
        NeutralizingGas, // While the Pokémon is in battle, other Pokémon's abilities are nullified or don't trigger
        PastelVeil, // Prevents the Pokémon and its allies from being Poisoned
        HungerSwitch, // The Pokémon changes between Full Belly Mode and Hangry Mode every turn
        QuickDraw, // Allows the Pokémon to move first occasionally
        UnseenFist, // If the Pokémon uses a contact move, it can attack the target even if the target protects itself
        CuriousMedicine, // Removes all stat changes from allies on entering battle
        Transistor, // Powers up Electric-type moves
        DragonsMaw, // Powers up Dragon-type moves
        ChillingNeigh, // Boosts Attack on KOing a target
        GrimNeigh, // Boosts Special Attack on KOing a target
        AsOneChilling, // Combines Unnerve and Chilling Neigh
        AsOneGrim, // Combines Unnerve and Grim Neigh
        // Generation 9
        LingeringAroma, // Contact with the Pokémon changes the attacker's Ability to Lingering Aroma
        SeedSower, // Turns the ground into Grassy Terrain when the Pokémon is hit by an attack
        ThermalExchnage, // Boosts Attack when hit by a Fire-type move, the Pokémon cannot be Burned
        AngerShell, // When an attack drops the Pokémon's HP to half or lower, lowers Defense and Special Defense, boosts Attack, Special Attack, and Speed
        PurifyingSalt, // Prevents status conditions, halves damage from Ghost-type moves
        WellBakedBody, // Takes no damage from Fire-type moves, instead sharply boosts Defense
        WindRider, // Boosts Attack if Tailwind takes effect or if the Pokémon is hit by a wind move, takes no damage from wind moves
        GuardDog, // Boosts Attack if Intimidated, cannot be forced to switch out
        RockyPayload, // Boosts the power of Rock-type moves
        WindPower, // When hit by a wind move, boosts the next Electric-type move the Pokémon uses
        ZeroToHero, // Transforms into Hero Form when it switches out
        Commander, // Enters the mouth of an ally Dondozo if one is on the field, issues commands from there
        Electromorphosis, // When damaged, boosts the power of the next Electric-type move the Pokémon uses
        Protosynthesis, // Boosts the Pokémon's most proficient stat in Harsh Sunlight or if the Pokémon is holding Booster Energy
        QuarkDrive, // Boosts the Pokémon's most proficient stat on Electric Terrain or if the Pokémon is holding Booster Energy
        GoodAsGold, // Immune to other Pokémon's status moves
        VesselOfRuin, // Lowers Special Attack of all Pokémon except itself
        SwordOfRuin, // Lowers Defense of all Pokémon except itself
        TabletOfRuin, // Lowers Attack of all Pokémon except itself
        BeadsOfRuin, // Lowers Special Defense of all Pokémon except itself
        OrichalcumPulse, // Summons Harsh Sunlight on entering battle, boosts Attack in Harsh Sunlight
        HadronEngine, // Turns the ground into Electric Terrain on enering battle, boosts Special Attack on Electric Terrain
        Opportunist, // If an opponent's stat is boosted, the Pokémon boosts the same stat for itself
        CudChew, // Can reuse a previously eaten berry once
        Sharpness, // Powers up slicing moves
        SupremeOverlord, // Boosts Attack and Special Attack for each ally in its party that has been defeated
        Costar, // Copies an ally's stat changes on entering battle
        ToxicDebris, // Scatters Poison spikes at the feet of the opponents on taking physical damage
        ArmorTail, // Opponents are unable to use priority moves against the Pokémon or its allies
        EarthEater, // Restores HP when hit by Gound-type moves
        MyceliumMight, // Acts slower when using status moves, but these moves will be unimpeded by the target's Ability
        Hospitality, // Restores an ally's HP upon that ally entering battle
        MindsEye, // Ignores changes to opponents' evasiveness, accuracy cannot be lowered, and can hit Ghost-types with Normal- and Fighting- type moves
        EmbodyAspectTeal, // Boosts Speed
        EmbodyAspectHearthflame, // Boosts Attack
        EmbodyAspectWellspring, // Boosts Special Defense
        EmbodyAspectCornerstone, // Boosts Defense
        ToxicChain, // Badly Poisons the target that the Pokémon hits with a move
        SupersweetSyrup, // Lowers opponents' evasiveness on entering battle
        TeraShift, // Transforms into Terastal Form on entering battle
        TeraShell, // Any damaging move that hits the Pokémon at full HP will be not very effective
        TeraformZero, // Eliminates weather and terrain on transforming to Stellar Form
        PoisonPuppeteer, // Targets Poisoned by the Pokémon's moves will also become confused
    }
}
