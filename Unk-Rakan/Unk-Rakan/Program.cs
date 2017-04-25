using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;

namespace Unk_Rakan
{
    class Program
    {
        public static string Version = "Version 1.0.0.4";
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.ChampionName != "Rakan")
            {
                return;
            }

            Menus.CreateMenu();
            Drawing.OnDraw += Drawings.Drawing_OnDraw;
            Game.OnTick += Game_OnTick;
            Game.OnUpdate += Game_OnGameUpdate;
            Interrupter.OnInterruptableSpell += Misc.Interrupter_OnInterruptableSpell;
            Gapcloser.OnGapcloser += Misc.AntiGapCloser;

            Chat.Print("Unk-Rakan 1.0.0.4 Loaded Successfully");
            Chat.Print("Please Report Any Issues in the Thread.");
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (Menus.GetCheckBoxItem(Menus.MiscMenu, "skinHack"))
            {
                Player.Instance.SetSkinId(Menus.GetSliderItem(Menus.MiscMenu, "SkinID"));
            }

            else
            {
                Player.Instance.SetSkinId(0);
            }

            HarassManager.Harass();

        }

        private static void Game_OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.Equals(Orbwalker.ActiveModes.Combo))
                Combos.Combo();

            if (Orbwalker.ActiveModesFlags.Equals(Orbwalker.ActiveModes.Harass))
                HarassManager.HarassWithC();

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Flee))
                Flee.AutoShieldEscape();
                Misc.AutoPotion();
        }
    }
}
