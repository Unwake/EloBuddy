using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace Janna___Unwake_s_Fury
{
    class ComboManager
    {
        public static void Combo()
        {
            var allies = EntityManager.Heroes.Allies.OrderBy(a => a.Health).FirstOrDefault(a => SpellsManager.R.IsInRange(a) && !a.IsMe);
            var target = TargetSelector.GetTarget(SpellsManager.Q.Range, DamageType.Magical);

            if (MenuManager.GetCheckBoxItem(MenuManager.ComboMenu, "Use W") && target != null &&
                SpellsManager.W.IsReady())
            {
                SpellsManager.W.Cast(target);
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.ComboMenu, "Use Q") && target != null &&
                SpellsManager.Q.IsReady())
            {
                var Prediction = SpellsManager.Q.GetPrediction(target);

                if (Prediction.HitChance >= HitChance.High)
                {
                    SpellsManager.Q.Cast(Prediction.CastPosition);
                }
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.ComboMenu, "Use E") && target != null &&
                SpellsManager.E.IsReady())
            {
                SpellsManager.E.Cast(ObjectManager.Player);
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.ComboMenu, "UseEADC") && target != null &&
                SpellsManager.E.IsReady())
            {
                SpellsManager.E.Cast(allies);
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.ComboMenu, "Use Ignite") && target != null &&
                SpellsManager.Ignite.IsReady())
            {
                if (target.IsValidTarget(SpellsManager.Ignite.Range) && target.HealthPercent < 15 &&
                    SpellsManager.Ignite.IsReady())
                {
                    SpellsManager.Ignite.Cast(target);
                } 
            }
        }
    }
}
