using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;

namespace Unk_Rakan
{
    class Misc
    {
        public static readonly Item HuntersPot = new Item((int)ItemId.Hunters_Potion);
        public static readonly Item CorruptPot = new Item((int)ItemId.Corrupting_Potion);
        public static readonly Item Biscuit = new Item((int)ItemId.Total_Biscuit_of_Rejuvenation);
        public static readonly Item HpPot = new Item((int)ItemId.Health_Potion);
        public static readonly Item RefillPot = new Item((int)ItemId.Refillable_Potion);

        public static void GapCloser_OnGapCloser(AIHeroClient sender, Gapcloser.GapcloserEventArgs e)
        {
            if (!sender.IsEnemy) return;

            if (e.Target.IsMe && sender.IsValidTarget() && Spells.W.IsReady() && Menus.GetCheckBoxItem(Menus.MiscMenu, "WGap") && sender.IsAttackingPlayer && sender.IsEnemy && sender.Distance(Player.Instance.Position) <= 600 && e.End.Distance(Player.Instance.Position) <= 600)
            {
                Spells.W.Cast(sender.Position);
            }
        }

        public static void Interrupter_OnInterruptableSpell(Obj_AI_Base sender, Interrupter.InterruptableSpellEventArgs e)
        {
            if (!sender.IsEnemy) return;
            var target = (AIHeroClient) sender;

            if (sender.IsValid && Menus.GetCheckBoxItem(Menus.InterrupterMenu, "Use W") && sender.IsEnemy && target.IsValidTarget(Spells.W.Range) && e.DangerLevel >= DangerLevel.High)
            {
                Spells.W.Cast(e.Sender);
            }
        }

        public static void AutoPotion()
        {
            if (Menus.GetCheckBoxItem(Menus.MiscMenu, "AutoPot") && !Player.Instance.IsInShopRange() &&
                Player.Instance.HealthPercent <= Menus.GetSliderItem(Menus.MiscMenu, "AutoPotHPPercent") && !(Player.HasBuff("RegenerationPotion") && Player.HasBuff("ItemCrystalFlaskJungle") && Player.HasBuff("ItemMiniRegenPotion") && Player.HasBuff("ItemCrystalFlask") && Player.HasBuff("ItemDarkCrystalFlask")))
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
    }
}
