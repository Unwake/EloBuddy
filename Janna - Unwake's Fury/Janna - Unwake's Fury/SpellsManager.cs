using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Spells;
using EloBuddy.SDK.Enumerations;

namespace Janna___Unwake_s_Fury
{
    class SpellsManager
    {
        public static Spell.Skillshot Q;
        public static Spell.Targeted W;
        public static Spell.Targeted E;
        public static Spell.Active R;
        public static Spell.Targeted Ignite;

        static SpellsManager()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 850, SkillShotType.Linear, 0, 900, 120)
                { AllowedCollisionCount = int.MaxValue };
            W = new Spell.Targeted(SpellSlot.W, 600);
            E = new Spell.Targeted(SpellSlot.E, 800);
            R = new Spell.Active(SpellSlot.R, 725);
            Ignite = new Spell.Targeted(SummonerSpells.Ignite.Slot, 600);
        }
    }
}
