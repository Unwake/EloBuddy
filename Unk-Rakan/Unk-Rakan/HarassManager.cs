using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace Unk_Rakan
{
    class HarassManager
    {
        public static void Harass()
        {
            var enemies = EntityManager.Heroes.Enemies.OrderByDescending(a => a.HealthPercent)
                .Where(a => !a.IsMe && a.IsValidTarget() && a.Distance(Player.Instance) <= Spells.Q.Range);
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);

            if (!target.IsValidTarget())
            {
                return;
            }

            if (Spells.Q.IsReady() && target.IsValidTarget(Spells.Q.Range))
                foreach (var eenimies in enemies)
                {
                    var useQ = Menus.GetCheckBoxItem(Menus.HarassMenu, "Use AutoQ");

                    if (useQ && Player.Instance.ManaPercent >=
                        Menus.GetSliderItem(Menus.HarassMenu, "Use AutoQ Mana Percent"))
                    {
                        var qPredHarass = Spells.Q.GetPrediction(target);
                        if (qPredHarass.HitChance >= HitChance.High)
                        {
                            Spells.Q.Cast(qPredHarass.CastPosition);
                        }
                    }
                }
        }

        public static void HarassWithC()
        {
            var enemies = EntityManager.Heroes.Enemies.OrderByDescending(a => a.HealthPercent)
                .Where(a => !a.IsMe && a.IsValidTarget() && a.Distance(Player.Instance) <= Spells.Q.Range);
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);

            if (!target.IsValidTarget())
            {
                return;
            }

            if (Spells.Q.IsReady() && target.IsValidTarget(Spells.Q.Range))
                foreach (var eenimies in enemies)
                {
                    var useQ = Menus.GetCheckBoxItem(Menus.HarassMenu, "Use Q");

                    if (useQ && Player.Instance.ManaPercent >=
                        Menus.GetSliderItem(Menus.HarassMenu, "Use Q Mana Percent"))
                    {
                        var qPredHarass = Spells.Q.GetPrediction(target);
                        if (qPredHarass.HitChance >= HitChance.High)
                        {
                            Spells.Q.Cast(qPredHarass.CastPosition);
                        }
                    }
                }
        }
    }
}
