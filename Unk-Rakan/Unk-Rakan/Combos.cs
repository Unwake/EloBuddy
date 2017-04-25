using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace Unk_Rakan
{
    class Combos
    {
        public static void Combo()
        {
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);

            if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use Q") && target != null && Spells.Q.IsReady())
            {
                var qPred = Spells.Q.GetPrediction(target);

                if (qPred.HitChance >= HitChance.High)
                {
                    Spells.Q.Cast(qPred.CastPosition);
                }

                else if (qPred.HitChance == HitChance.Collision)
                {
                    var minionsHit = qPred.CollisionObjects;
                    var closest =
                        minionsHit.Where(m => m.NetworkId != ObjectManager.Player.NetworkId)
                            .OrderBy(m => m.Distance(ObjectManager.Player))
                            .FirstOrDefault();

                    if (closest != null && closest.Distance(qPred.UnitPosition) < 200)
                    {
                        Spells.Q.Cast(qPred.CastPosition);
                    }
                }
            }

            if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use W") && target != null && Spells.W.IsReady())
            {
                var wPred = Spells.W.GetPrediction(target);

                if (wPred.HitChance >= HitChance.High)
                {
                    Spells.W.Cast(wPred.CastPosition);
                }
            }

            if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use R") && Player.Instance.CountEnemyChampionsInRange(Spells.R.Range) >= Menus.GetSliderItem(Menus.ComboMenu, "Use R in Min Enemies") && target != null && Spells.R.IsReady())
            {
                {
                    Spells.R.Cast(target);
                }
            }

            if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use Ignite") && target != null && Spells.Ignite.IsReady())
            {
                if (target.IsValidTarget(Spells.Ignite.Range) && target.HealthPercent < 15 && Spells.Ignite.IsReady())
                {
                    Spells.Ignite.Cast(target);
                }
            }
        }
    }
}
