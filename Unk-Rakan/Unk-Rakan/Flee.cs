using System.Linq;
using EloBuddy;
using EloBuddy.SDK;

namespace Unk_Rakan
{
    class Flee
    {
        public static void AutoShieldEscape()
        {
            var allies = EntityManager.Heroes.Allies.OrderBy(a => a.Health).FirstOrDefault(a => Spells.E.IsInRange(a) && !a.IsMe);

            var usee = allies != null && allies.IsValidTarget(Spells.E.Range) &&
                       Menus.GetCheckBoxItem(Menus.FleeMenu, "AutoE");

            if (usee && allies.HealthPercent <= 100 && Player.Instance.ManaPercent >= Menus.GetSliderItem(Menus.FleeMenu, "AutoEManaCost"))
            {
                Spells.E.Cast(allies);
            }
        }

        public static void FleeWithR()
        {
            if (Player.Instance.HealthPercent <= Menus.GetSliderItem(Menus.FleeMenu, "AutoRHpPer") && Menus.GetCheckBoxItem(Menus.FleeMenu, "AutoRFlee") && Spells.R.IsReady())
            {
                Spells.R.Cast();
            }
        }
    }
}
