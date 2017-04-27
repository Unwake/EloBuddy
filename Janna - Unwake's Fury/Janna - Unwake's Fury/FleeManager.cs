using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace Janna___Unwake_s_Fury
{
    class FleeManager
    {
        public static void Flee()
        {
            var target = TargetSelector.GetTarget(SpellsManager.Q.Range, DamageType.Magical);

            if (MenuManager.GetCheckBoxItem(MenuManager.FleeMenu, "Use W") && target != null &&
                SpellsManager.W.IsReady())
            {
                SpellsManager.W.Cast(target);
            }

            if (MenuManager.GetCheckBoxItem(MenuManager.FleeMenu, "Use Q") && target != null &&
                SpellsManager.Q.IsReady())
            {
                var Prediction = SpellsManager.Q.GetPrediction(target);

                if (Prediction.HitChance >= HitChance.High)
                {
                    SpellsManager.Q.Cast(Prediction.CastPosition);
                }
            }
        }
    }
}
