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
            var QWR = Menus.GetCheckBoxItem(Menus.ComboMenu, "Combo QWR");
            var WQE = Menus.GetCheckBoxItem(Menus.ComboMenu, "Combo WQE");
            var EWQE = Menus.GetCheckBoxItem(Menus.ComboMenu, "Combo EWQE");
            var REWQE = Menus.GetCheckBoxItem(Menus.ComboMenu, "Combo REWQE");

            var allies = EntityManager.Heroes.Allies.OrderBy(a => a.Health).FirstOrDefault(a => Spells.E.IsInRange(a) && !a.IsMe);

            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);

            if (WQE)
            {
                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use W") && target != null && Spells.W.IsReady())
                {
                    var wPred = Spells.W.GetPrediction(target);

                    if (wPred.HitChance >= HitChance.High)
                    {
                        Spells.W.Cast(wPred.CastPosition);
                    }
                }

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

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use E") && Spells.E.IsReady() && target != null)
                {
                    Spells.E.Cast(allies);
                }
            }

            if (EWQE)
            {
                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use E") && Spells.E.IsReady() && target != null)
                {
                    Spells.E.Cast(allies);
                }

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use W") && target != null && Spells.W.IsReady())
                {
                    var wPred = Spells.W.GetPrediction(target);

                    if (wPred.HitChance >= HitChance.High)
                    {
                        Spells.W.Cast(wPred.CastPosition);
                    }
                }

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

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use E") && Spells.E.IsReady() && target != null)
                {
                    Spells.E.Cast(allies);
                }
            }

            if (REWQE)
            {
                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use R") && Player.Instance.CountEnemyChampionsInRange(Spells.Q.Range) >= Menus.GetSliderItem(Menus.ComboMenu, "Use R in Min Enemies") && target != null && Spells.R.IsReady())
                {
                    {
                        Spells.R.Cast(target);
                    }
                }

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use E") && Spells.E.IsReady() && target != null)
                {
                    Spells.E.Cast(allies);
                }

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use W") && target != null && Spells.W.IsReady())
                {
                    var wPred = Spells.W.GetPrediction(target);

                    if (wPred.HitChance >= HitChance.High)
                    {
                        Spells.W.Cast(wPred.CastPosition);
                    }
                }

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

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use E") && Spells.E.IsReady() && target != null)
                {
                    Spells.E.Cast(allies);
                }
            }

            if (QWR)
            {
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

                if (Menus.GetCheckBoxItem(Menus.ComboMenu, "Use R") &&
                    Player.Instance.CountEnemyChampionsInRange(Spells.Q.Range) >=
                    Menus.GetSliderItem(Menus.ComboMenu, "Use R in Min Enemies") && target != null &&
                    Spells.R.IsReady())
                {
                    {
                        Spells.R.Cast(target);
                    }
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
