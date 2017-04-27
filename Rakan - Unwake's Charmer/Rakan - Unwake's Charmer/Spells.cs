using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Spells;

namespace Rakan___Unwake_s_Charmer
{
    class Spells
    {
        public static Spell.Skillshot Q;
        public static Spell.Skillshot W;
        public static Spell.Targeted E;
        public static Spell.Active R;
        public static Spell.Targeted Ignite;

        static Spells()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 800, SkillShotType.Linear, 250, 1850, 60)
                { AllowedCollisionCount = 0 };
            W = new Spell.Skillshot(SpellSlot.W, 600, SkillShotType.Circular, 0, 1500, 300);
            E = new Spell.Targeted(SpellSlot.E, 550);
            R = new Spell.Active(SpellSlot.R, 200);
            Ignite = new Spell.Targeted(SummonerSpells.Ignite.Slot, 600);
        }
    }
}
