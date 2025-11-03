using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder
{
    internal enum Abilities
    {
        Stench, // May cause the target to flinch
        Drizzle, // Summons rain upon entering battle
        SpeedBoost, // Increases Speed stat each turn
        BattleArmor, // Prevents critical hits
        Sturdy, // Prevents being OHKOed from full health
        Damp, // Prevents explosive moves, nullifies Aftermath
        Limber, // Prevents paralysis
        SandVeil, // Increases evasion in a sandstorm
        Static, // May cause paralysis on contact
        VoltAbsorb, // Heals when hit by Electric-type moves
        WaterAbsorb, // Heals when hit by Water-type moves
        Oblivious, // Prevents infatuation, Taunt, and Intimidate
        CloudNine, // Negates weather effects
        CompoundEyes, // Increases accuracy
        Insomnia, // Prevents sleep
        ColorChange, // Changes type to the type of the move used against it
        Immunity, // Prevents poisoning
        FlashFire, // Powers up Fire-type moves if hit by one
        ShieldDust, // Blocks secondary effects of moves
        OwnTempo, // Prevents confusion and Intimidate
        SuctionCups, // Prevents being forced out of battle
        Intimidate, // Lowers opponent's Attack stat upon entering battle
        ShadowTag, // Prevents opponents from escaping
        RoughSkin, // Inflicts damage on contact
        WonderGuard, // Only super effective moves hit
        Levitate, // Immune to Ground-type moves and certain hazards
        EffectSpore, // May inflict paralysis, poison, or sleep on contact
        Synchronize, // Passes burn, paralysis, or poison to the attacker that inflicted it
        ClearBody, // Prevents stat reduction by others
        NaturalCure, // Heals status conditions upon switching out
        LightningRod // Draws in all Electric-type moves to boost Special Attack
    }
}
