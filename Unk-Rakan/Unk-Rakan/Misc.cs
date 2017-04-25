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

        public static void AntiGapCloser(AIHeroClient sender, Gapcloser.GapcloserEventArgs gapcloser)
        {
            if (gapcloser.Sender.IsValidTarget() && Spells.Q.IsReady() && Menus.GetCheckBoxItem(Menus.MiscMenu, "QGap") && gapcloser.Sender.Type != Player.Instance.Type && !gapcloser.Sender.IsEnemy && gapcloser.Sender.IsAlly)
            {
                Spells.Q.Cast(gapcloser.Sender.ServerPosition);
            }
        }

        public static void Interrupter_OnInterruptableSpell(Obj_AI_Base sender, Interrupter.InterruptableSpellEventArgs interruptableSpellEventArgs)
        {
            if (!sender.IsEnemy) return;

            if (interruptableSpellEventArgs.DangerLevel >= DangerLevel.High && Menus.GetCheckBoxItem(Menus.InterrupterMenu, "Use W") && Spells.W.IsReady())
            {
                Spells.W.Cast(sender.Position);
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
