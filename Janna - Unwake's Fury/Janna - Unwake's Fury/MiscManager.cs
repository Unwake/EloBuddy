using System.Linq;
using EloBuddy;
using EloBuddy.SDK;

namespace Janna___Unwake_s_Fury
{
    class MiscManager
    {
        public static readonly Item HuntersPot = new Item((int)ItemId.Hunters_Potion);
        public static readonly Item CorruptPot = new Item((int)ItemId.Corrupting_Potion);
        public static readonly Item Biscuit = new Item((int)ItemId.Total_Biscuit_of_Rejuvenation);
        public static readonly Item HpPot = new Item((int)ItemId.Health_Potion);
        public static readonly Item RefillPot = new Item((int)ItemId.Refillable_Potion);

        public static void AutoPotion()
        {
            if (MenuManager.GetCheckBoxItem(MenuManager.MiscMenu, "AutoPot") && !Player.Instance.IsInShopRange() &&
                Player.Instance.HealthPercent <= MenuManager.GetSliderItem(MenuManager.MiscMenu, "AutoPotHP") && !(Player.HasBuff("RegenerationPotion") && Player.HasBuff("ItemCrystalFlaskJungle") && Player.HasBuff("ItemMiniRegenPotion") && Player.HasBuff("ItemCrystalFlask") && Player.HasBuff("ItemDarkCrystalFlask")))
            {
                if (HuntersPot.IsReady() && HuntersPot.IsOwned())
                {
                    HuntersPot.Cast();
                }

                if (CorruptPot.IsReady() && CorruptPot.IsOwned())
                {
                    CorruptPot.Cast();
                }

                if (Biscuit.IsReady() && Biscuit.IsOwned())
                {
                    Biscuit.Cast();
                }

                if (HpPot.IsReady() && HpPot.IsOwned())
                {
                    HpPot.Cast();
                }

                if (RefillPot.IsReady() && RefillPot.IsOwned())
                {
                    RefillPot.Cast();
                }
            }
        }

        public static void AutoHeal()
        {
            var allies = EntityManager.Heroes.Allies.OrderBy(a => a.Health).FirstOrDefault(a => SpellsManager.R.IsInRange(a) && !a.IsMe);

            if (allies != null && allies.IsValidTarget(SpellsManager.R.Range) &&
                MenuManager.GetCheckBoxItem(MenuManager.MiscMenu, "Auto R") && allies.HealthPercent <=
                MenuManager.GetSliderItem(MenuManager.MiscMenu, "AutoRHP"))
            {
                SpellsManager.R.Cast();
            }
        }

        public static void AutoShield()
        {
            var allies = EntityManager.Heroes.Allies.OrderBy(a => a.Health).FirstOrDefault(a => SpellsManager.R.IsInRange(a) && !a.IsMe);

            if (allies != null && allies.IsValidTarget(SpellsManager.R.Range) &&
                MenuManager.GetCheckBoxItem(MenuManager.MiscMenu, "Auto E") && allies.HealthPercent <=
                MenuManager.GetSliderItem(MenuManager.MiscMenu, "AutoEHP"))
            {
                SpellsManager.E.Cast(allies);
            }
        }
    }
}
